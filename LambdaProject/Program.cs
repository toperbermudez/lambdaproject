using LambdaProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Programmers> programmers = GetProgrammers();
            List<Projects> projects = GetProjects();


            var str = "";
            Programmers programmer;

            //foreach (var item in programmers)
            //{
            //    str = string.Format("EmpCode: {0}, EmpName: {1}, Tenure: {2}", item.EmpCode, item.EmpName, item.Tenure);
            //    Console.WriteLine(str);
            //};

            Console.WriteLine(projects.All(x => x.Active == true));
            Console.WriteLine(programmers.Exists(x => x.EmpName.IndexOf("Chris") >= 0));
            Console.WriteLine(programmers.Max(x => x.Age));
            Console.WriteLine(programmers.Min(x => x.Tenure));

            //programmer = programmers.First();
            //programmer = programmers.Last();
            //programmer = programmers.OrderByDescending(x => x.Age).ThenBy(x => x.Tenure).First();
            //programmer = programmers.OrderByDescending(x => x.Age).Last();
            //programmer = programmers.First(x => x.Tenure == (programmers.Max(m => m.Tenure)));

            //str = string.Format("EmpCode: {0}, EmpName: {1}, Age: {3}, Tenure: {2}", programmer.EmpCode, programmer.EmpName, programmer.Tenure, programmer.Age);
            //Console.WriteLine(str);

            //foreach (var item in programmers.OrderBy(x => x.Age))
            //{
            //    str = string.Format("EmpCode: {0}, EmpName: {1}, Age: {3}, Tenure: {2}", item.EmpCode, item.EmpName, item.Tenure, item.Age);
            //    Console.WriteLine(str);
            //}

            //foreach (var item in programmers.OrderByDescending(x => x.Age).Take(3))
            //{
            //    str = string.Format("EmpCode: {0}, EmpName: {1}, Age: {3}, Tenure: {2}", item.EmpCode, item.EmpName, item.Tenure, item.Age);
            //    Console.WriteLine(str);
            //}

            //foreach (var item in programmers.Select(x => new { x.Tenure,x.Age }).Distinct())
            //{
            //    Console.WriteLine(item);
            //}

            foreach (var item in programmers.Where(x => x.Tenure > 2))
            {
                str = string.Format("EmpCode: {0}, EmpName: {1}, Tenure: {2}", item.EmpCode, item.EmpName, item.Tenure);
                Console.WriteLine(str);
            }

            //foreach (var item in projects.Select(x => new { x.Active, x.DevCode }).Distinct())
            //{
            //    Console.WriteLine(item);
            //}

            foreach (var item in programmers.GroupBy(x => new { x.Tenure }, (key, val) => new { key.Tenure, Count = val.Count() }))
            {
                Console.WriteLine(item.Tenure + ": " + item.Count);
            }

            foreach (var pogi in programmers)
            {
                Console.WriteLine(pogi.EmpName + ": " + projects.Where(x => x.DevCode == pogi.EmpCode && x.Active == true).Count());                   
            }

            Console.ReadLine();
        }

        private static List<Programmers> GetProgrammers()
        {
            List<Programmers> model = new List<Programmers>();
            model.Add(new Programmers()
            {
                EmpCode = "14011669",
                EmpName = "Almadin, Josef Benjamin Miguel",
                Tenure = 5,
                Age = 26
            });
            model.Add(new Programmers()
            {
                EmpCode = "14011686",
                EmpName = "Alora, Harland Mikee Queqquegan",
                Tenure = 5,
                Age = 26
            });
            model.Add(new Programmers()
            {
                EmpCode = "15013008",
                EmpName = "Agno, Marlon Sanguir",
                Tenure = 4,
                Age = 28
            });
            model.Add(new Programmers()
            {
                EmpCode = "15053258",
                EmpName = "Gaquit, Edrian Pacamarra",
                Tenure = 4,
                Age = 25
            });
            model.Add(new Programmers()
            {
                EmpCode = "150873424",
                EmpName = "Yeban, Rizza Maul",
                Tenure = 4,
                Age = 25
            });
            model.Add(new Programmers()
            {
                EmpCode = "15114483",
                EmpName = "Miranda, Raemon Rene Greg Perez",
                Tenure = 4,
                Age = 24
            });
            model.Add(new Programmers()
            {
                EmpCode = "16095178",
                EmpName = "Caoile, Dominique Ladra",
                Tenure = 3,
                Age = 23
            });
            model.Add(new Programmers()
            {
                EmpCode = "16115250",
                EmpName = "Alba, Ranjie R.",
                Tenure = 3,
                Age = 24
            });
            model.Add(new Programmers()
            {
                EmpCode = "16115297",
                EmpName = "Bermudez, Christopher Loyo",
                Tenure = 3,
                Age = 30
            });
            model.Add(new Programmers()
            {
                EmpCode = "17025456",
                EmpName = "Perez, Kenneth Sam Loresto",
                Tenure = 2,
                Age = 26
            });
            model.Add(new Programmers()
            {
                EmpCode = "17065873",
                EmpName = "Lazo, Mark Joseph Leal",
                Tenure = 2,
                Age = 26
            });
            model.Add(new Programmers()
            {
                EmpCode = "17065882",
                EmpName = "Gonzales, Karl Theodore Paterno",
                Tenure = 2,
                Age = 26
            });
            model.Add(new Programmers()
            {
                EmpCode = "18016325",
                EmpName = "Manalo, Eduardo N.",
                Tenure = 1,
                Age = 25
            });
            model.Add(new Programmers()
            {
                EmpCode = "18016326",
                EmpName = "Moreno, Mico .",
                Tenure = 1,
                Age = 23
            });
            model.Add(new Programmers()
            {
                EmpCode = "18016385",
                EmpName = "Cesar, Jessie Dayata",
                Tenure = 1,
                Age = 28
            });
            model.Add(new Programmers()
            {
                EmpCode = "18046586",
                EmpName = "Ramos, Meljohn Lucky Cruz",
                Tenure = 1,
                Age = 26
            });
            model.Add(new Programmers()
            {
                EmpCode = "18046627",
                EmpName = "Dela Peña, Ferdie Estarez",
                Tenure = 1,
                Age = 26
            });
            model.Add(new Programmers()
            {
                EmpCode = "18056679",
                EmpName = "Quintia, Vladimer Munda",
                Tenure = 1,
                Age = 28
            });
            model.Add(new Programmers()
            {
                EmpCode = "18074858",
                EmpName = "Bergonia, Francis Bryan Revester",
                Tenure = 1,
                Age = 27
            });
            model.Add(new Programmers()
            {
                EmpCode = "19026202",
                EmpName = "Salino, Ralph Andrew Vesagas",
                Tenure = 0,
                Age = 31
            });
            model.Add(new Programmers()
            {
                EmpCode = "19036528",
                EmpName = "Valte, Martin Abraham Roldan",
                Tenure = 0,
                Age = 35
            });
            model.Add(new Programmers()
            {
                EmpCode = "19036535",
                EmpName = "Bongbonga, Alven Tungala",
                Tenure = 0,
                Age = 25
            });
            model.Add(new Programmers()
            {
                EmpCode = "19036548",
                EmpName = "Quintana, Carl Elton Magno",
                Tenure = 0,
                Age = 25
            });
            model.Add(new Programmers()
            {
                EmpCode = "19036699",
                EmpName = "Salvador, Aldrin De Vera",
                Tenure = 0,
                Age = 29
            });
            model.Add(new Programmers()
            {
                EmpCode = "19087502",
                EmpName = "Viojan, James De Silva",
                Tenure = 0,
                Age = 27
            });


            return model;
        }

        private static List<Projects> GetProjects()
        {
            List<Projects> model = new List<Projects>();

            model.Add(new Projects()
            {
                ProgId = 1,
                ProgName = "Accenture LOA Monitoring",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 2,
                ProgName = "ActiveOneTabulated",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 235,
                ProgName = "Admin",
                DevCode = "18016326",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 3,
                ProgName = "AIAReport",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 5,
                ProgName = "AMS",
                DevCode = "15013008",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 218,
                ProgName = "Annoucement MW",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 6,
                ProgName = "AOP",
                DevCode = "14011686",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 7,
                ProgName = "APM",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 9,
                ProgName = "Bacteriology Worksheet",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 10,
                ProgName = "Bank_Recon",
                DevCode = "16115297",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 11,
                ProgName = "BIS Generator",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 244,
                ProgName = "BNC",
                DevCode = "19036548",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 217,
                ProgName = "BRANCH DASHBOARD",
                DevCode = "15013008",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 219,
                ProgName = "Branch Pending Monitoring",
                DevCode = "15013008",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 12,
                ProgName = "BranchGoal",
                DevCode = "14011686",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 13,
                ProgName = "BSP XRAY",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 14,
                ProgName = "BTRH MW",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 198,
                ProgName = "CALL CENTER MW",
                DevCode = "17065873",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 15,
                ProgName = "CallCenterReport",
                DevCode = "16115297",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 197,
                ProgName = "CCONSOL MW",
                DevCode = "17065873",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 16,
                ProgName = "CheckList",
                DevCode = "16115297",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 17,
                ProgName = "CM Scanner",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 18,
                ProgName = "CMTV",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 19,
                ProgName = "CollationChecker",
                DevCode = "16115297",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 242,
                ProgName = "Consolidation of Multiple PID",
                DevCode = "17065873",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 21,
                ProgName = "COPS",
                DevCode = "15053258",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 22,
                ProgName = "CPM",
                DevCode = "14011686",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 23,
                ProgName = "CustActivity",
                DevCode = "14011686",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 24,
                ProgName = "Cycle Monitoring",
                DevCode = "15053258",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 229,
                ProgName = "Dashboard Sync MW.",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 25,
                ProgName = "DelayedTestRunningDays",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 26,
                ProgName = "Digital Monitoring",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 28,
                ProgName = "DSR",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 29,
                ProgName = "DumpScanner",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 220,
                ProgName = "EGFR Middleware",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 31,
                ProgName = "Encoder Report",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 32,
                ProgName = "Endorsement",
                DevCode = "150873424",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 33,
                ProgName = "Endoscopy",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 34,
                ProgName = "EPM",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 35,
                ProgName = "Evaluation",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 38,
                ProgName = "EyeScan",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 39,
                ProgName = "FecalysisWorksheet",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 188,
                ProgName = "FILE COPY",
                DevCode = "14011669",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 40,
                ProgName = "FileCopyR01",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 41,
                ProgName = "FindPatientOrder",
                DevCode = "15053258",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 42,
                ProgName = "FIT Work Sheet",
                DevCode = "150873424",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 43,
                ProgName = "GC Monitoring Program",
                DevCode = "15053258",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 44,
                ProgName = "Gift Certificate",
                DevCode = "15053258",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 45,
                ProgName = "GLTagging",
                DevCode = "16115297",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 46,
                ProgName = "GPCollectionReport",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 47,
                ProgName = "Hematology Monitoring",
                DevCode = "150873424",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 48,
                ProgName = "Hematology MW",
                DevCode = "150873424",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 231,
                ProgName = "HISTO PRINT",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 230,
                ProgName = "HISTO TAT",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 189,
                ProgName = "HISTOMAMMO MW",
                DevCode = "14011669",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 49,
                ProgName = "Histopath Monitoring",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 50,
                ProgName = "Histopath MW",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 232,
                ProgName = "HISTOPATH MW",
                DevCode = "15013008",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 190,
                ProgName = "HISTOPATH TRANSMITTAL",
                DevCode = "14011669",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 51,
                ProgName = "HistoSpecimen",
                DevCode = "14011686",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 52,
                ProgName = "HIV Count",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 53,
                ProgName = "HIVCount2013",
                DevCode = "14011669",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 233,
                ProgName = "HL7 Consolidator",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 185,
                ProgName = "HP - MISSION MONITORING",
                DevCode = "14011669",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 55,
                ProgName = "HP Game",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 221,
                ProgName = "HP GEN PDF",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 56,
                ProgName = "HP-Call Center",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 57,
                ProgName = "HP-Imaging",
                DevCode = "15013008",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 58,
                ProgName = "HP-Mission",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 59,
                ProgName = "HPD Manual",
                DevCode = "150873424",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 60,
                ProgName = "Imaging Printing Monitoring",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 61,
                ProgName = "ImagingPDFConsolidation",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 62,
                ProgName = "ImagingPXCount",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 63,
                ProgName = "ImaginPXCount",
                DevCode = "14011669",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 209,
                ProgName = "Import Micro PDF",
                DevCode = "150873424",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 224,
                ProgName = "IMPORT MONITORING",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 65,
                ProgName = "InterfaceResultAUTO",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 67,
                ProgName = "InventoryAudit",
                DevCode = "14011686",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 68,
                ProgName = "IssueLog",
                DevCode = "14011669",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 187,
                ProgName = "IT-MONITORING (FILE COUNT)",
                DevCode = "14011669",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 186,
                ProgName = "IT-MONITORING (NETWORK)",
                DevCode = "14011669",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 69,
                ProgName = "JGMAN",
                DevCode = "15053258",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 204,
                ProgName = "JO API",
                DevCode = "17065873",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 203,
                ProgName = "JO VEWING",
                DevCode = "17065873",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 201,
                ProgName = "JOB ORDER",
                DevCode = "17065873",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 210,
                ProgName = "Lab Monitor Delmonte",
                DevCode = "150873424",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 222,
                ProgName = "LAB MONITORING (LAS PINAS)",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 228,
                ProgName = "LAB. Scanner",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 70,
                ProgName = "Lapsing Schedule",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 71,
                ProgName = "LIS MW",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 72,
                ProgName = "LIS_IMPORT",
                DevCode = "14011686",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 223,
                ProgName = "LOA MW",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 75,
                ProgName = "LPM",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 76,
                ProgName = "Machine Report",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 77,
                ProgName = "Machine Separator",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 234,
                ProgName = "Macro Health",
                DevCode = "18016326",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 78,
                ProgName = "MasterData",
                DevCode = "14011686",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 79,
                ProgName = "MedTechExam",
                DevCode = "150873424",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 80,
                ProgName = "MEGA Queing",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 81,
                ProgName = "Messenger AT",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 82,
                ProgName = "MFC",
                DevCode = "150873424",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 84,
                ProgName = "MHInventory",
                DevCode = "14011686",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 207,
                ProgName = "Microbiology",
                DevCode = "150873424",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 191,
                ProgName = "MISSION PDF CONSOLIDATION",
                DevCode = "14011669",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 86,
                ProgName = "Mission Reports",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 87,
                ProgName = "MissionPayroll",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 88,
                ProgName = "Multi-File Transfer",
                DevCode = "15114483",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 89,
                ProgName = "NetworkStatusDisplay",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 90,
                ProgName = "NEWPEMW",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 206,
                ProgName = "Online Competency Exam",
                DevCode = "150873424",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 199,
                ProgName = "ONLINE INQUIRY",
                DevCode = "17065873",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 202,
                ProgName = "ONLINE MISSION",
                DevCode = "17065873",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 91,
                ProgName = "OP",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 92,
                ProgName = "OPUtils",
                DevCode = "15053258",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 93,
                ProgName = "Outgoing Payment",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 214,
                ProgName = "Parasite Identified",
                DevCode = "150873424",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 95,
                ProgName = "Patient Count Summary",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 96,
                ProgName = "Patient Search",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 97,
                ProgName = "Payment Requisition",
                DevCode = "15053258",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 215,
                ProgName = "PCR Test Summary",
                DevCode = "150873424",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 225,
                ProgName = "PDF CONSOLIDATION",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 99,
                ProgName = "PDF To Text",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 211,
                ProgName = "Pending Monitoring (Export Excel)",
                DevCode = "150873424",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 101,
                ProgName = "PendingAuthorize",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 102,
                ProgName = "PEndingSMTP",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 103,
                ProgName = "Petty Cash Fund",
                DevCode = "15053258",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 104,
                ProgName = "PEWalkin",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 105,
                ProgName = "PF",
                DevCode = "15114483",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 212,
                ProgName = "Phlebo Monitoring",
                DevCode = "150873424",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 106,
                ProgName = "PhleboMonitoring",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 236,
                ProgName = "PM Lab Monitorin",
                DevCode = "18016326",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 226,
                ProgName = "POS MW",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 196,
                ProgName = "PRICE CONSOLIDATOR MW",
                DevCode = "17065873",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 192,
                ProgName = "PRICE MASTER",
                DevCode = "17065873",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 195,
                ProgName = "PRICE MATRIX MW",
                DevCode = "17065873",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 107,
                ProgName = "ProcessAlert",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 213,
                ProgName = "Processing Monitoring",
                DevCode = "150873424",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 108,
                ProgName = "Processing MW",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 109,
                ProgName = "ProcessingMonitoring",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 110,
                ProgName = "ProcessingSpecimenMonitoring",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 111,
                ProgName = "ProcessingSupply",
                DevCode = "14011686",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 113,
                ProgName = "ProgramUpdater",
                DevCode = "15114483",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 114,
                ProgName = "PushingOfResult",
                DevCode = "14011669",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 115,
                ProgName = "PxReg MW",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 116,
                ProgName = "QueingReport",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 117,
                ProgName = "Query Executor",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 227,
                ProgName = "QUEUE TAT MW",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 216,
                ProgName = "Raffle Ticket",
                DevCode = "150873424",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 237,
                ProgName = "Reagent Import",
                DevCode = "18016326",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 119,
                ProgName = "Releasing System",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 120,
                ProgName = "Repeat Test Report",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 121,
                ProgName = "Report Generator",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 122,
                ProgName = "Requisition",
                DevCode = "16115250",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 123,
                ProgName = "Result Block",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 124,
                ProgName = "ResultFileEditor",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 125,
                ProgName = "RIATestSummary",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 126,
                ProgName = "Sales",
                DevCode = "14011686",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 200,
                ProgName = "SALES PRICING",
                DevCode = "17065873",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 127,
                ProgName = "SAP Credit Memo",
                DevCode = "14011686",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 128,
                ProgName = "SAP-OP",
                DevCode = "15053258",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 129,
                ProgName = "SAPSet Maintenance",
                DevCode = "16115297",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 205,
                ProgName = "Scheduler",
                DevCode = "150873424",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 130,
                ProgName = "Scrap",
                DevCode = "15053258",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 132,
                ProgName = "Serology",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 241,
                ProgName = "Serology Daily Order Summary",
                DevCode = "150873424",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 133,
                ProgName = "Slide Drawer",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 194,
                ProgName = "SOURCE REPLICATOR MW",
                DevCode = "17065873",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 136,
                ProgName = "SplashScreen",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 137,
                ProgName = "SRLReport",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 138,
                ProgName = "StorageMonitoring",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 139,
                ProgName = "SummaryPatientResult",
                DevCode = "150873424",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 140,
                ProgName = "SunCellular",
                DevCode = "15013008",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 142,
                ProgName = "SystemScanner",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 143,
                ProgName = "Tabulated Report",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 144,
                ProgName = "TAT",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 193,
                ProgName = "TEST REPLICATOR MW",
                DevCode = "17065873",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 145,
                ProgName = "TestCode Monitoring",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 146,
                ProgName = "TieUpContract",
                DevCode = "14011686",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 208,
                ProgName = "TRAINING MONITORING PROGRAM",
                DevCode = "150873424",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 147,
                ProgName = "Transmittal Generator",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 148,
                ProgName = "Trial Balance",
                DevCode = "16115297",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 149,
                ProgName = "UBP",
                DevCode = "15053258",
                Active = false
            });
            model.Add(new Projects()
            {
                ProgId = 150,
                ProgName = "VITEK Result",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 151,
                ProgName = "VitekCons",
                DevCode = "14011669",
                Active = true
            });
            model.Add(new Projects()
            {
                ProgId = 152,
                ProgName = "WeighingScale",
                DevCode = "14011669",
                Active = true
            });



            return model;
        }
    }
}
