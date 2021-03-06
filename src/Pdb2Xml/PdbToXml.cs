// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Microsoft.DiaSymReader.Tools
{
    internal static class PdbToXmlApp
    {
        public static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: Pdb2Xml <PEFile | DeltaPdb> [<output file>] [/tokens] [/methodSpans] [/delta] [/srcsvr]");
                return 1;
            }

            var argList = new List<string>(args);

            bool isDelta = argList.Remove("/delta");

            var options = PdbToXmlOptions.ResolveTokens;

            if (argList.Remove("/tokens"))
            {
                options |= PdbToXmlOptions.IncludeTokens;
            }

            if (argList.Remove("/methodSpans"))
            {
                options |= PdbToXmlOptions.IncludeMethodSpans;
            }

            if (argList.Remove("/srcsvr"))
            {
                options |= PdbToXmlOptions.IncludeSourceServerInformation;
            }

            string peFile;
            string pdbFile;

            if (isDelta)
            {
                peFile = null;
                pdbFile = argList[0];
            }
            else
            {
                peFile = argList[0];
                pdbFile = Path.ChangeExtension(peFile, ".pdb");
            }

            if (peFile != null && !File.Exists(peFile))
            {
                Console.WriteLine($"File not found: {peFile}");
                return 2;
            }

            if (!File.Exists(pdbFile))
            {
                Console.WriteLine($"PDB File not found: {pdbFile}");
                return 2;
            }

            string xmlFile;
            if (argList.Count > 1)
            {
                xmlFile = argList[1];
            }
            else
            {
                xmlFile = Path.ChangeExtension(pdbFile, ".xml");
            }

            if (File.Exists(xmlFile))
            {
                try
                {
                    File.Delete(xmlFile);
                }
                catch
                {
                }
            }

            try
            {
                if (isDelta)
                {
                    GenXmlFromDeltaPdb(pdbFile, xmlFile, options);
                }
                else
                {
                    GenXmlFromPdb(peFile, pdbFile, xmlFile, options);
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return e.HResult;
            }

            Console.WriteLine($"PDB dump written to {xmlFile}");
            return 0;
        }

        public static void GenXmlFromPdb(string exePath, string pdbPath, string outPath, PdbToXmlOptions options)
        {
            using (var exebits = new FileStream(exePath, FileMode.Open, FileAccess.Read))
            {
                using (var pdbbits = new FileStream(pdbPath, FileMode.Open, FileAccess.Read))
                {
                    using (var sw = new StreamWriter(outPath, append: false, encoding: Encoding.UTF8))
                    {
                        PdbToXmlConverter.ToXml(sw, pdbbits, exebits, options);
                    }
                }
            }
        }

        public static void GenXmlFromDeltaPdb(string pdbPath, string outPath, PdbToXmlOptions options)
        {
            using (var deltaPdb = new FileStream(pdbPath, FileMode.Open, FileAccess.Read))
            {
                // There is no easy way to enumerate all method tokens that are present in the PDB.
                // So dump the first 255 method tokens (the ones that are not present will be skipped):
                File.WriteAllText(outPath, PdbToXmlConverter.DeltaPdbToXml(deltaPdb, Enumerable.Range(0x06000001, 255)));
            }
        }
    }
}