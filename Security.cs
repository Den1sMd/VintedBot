using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Security.Cryptography.X509Certificates;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Runtime.Intrinsics.Arm;

namespace Vinted_UK_Bot
{
    internal class Security
    {


        public static string realhwid;

        private static readonly string hwidPath = "cache/secu.txt";

        private static string genHwid;

        private static string genHash;


        public static string hwid()
        {
            try
            {
                string cpu = "";
                string cartem = "";
                string b1os = "";
                string disquedur = "";

                ManagementObjectSearcher cpuSearcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
                foreach (ManagementObject obj in cpuSearcher.Get())
                {
                    cpu = obj["ProcessorId"].ToString();
                    break;
                }


                ManagementObjectSearcher Carte = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
                foreach (ManagementObject obj in Carte.Get())
                {
                    cartem = obj["SerialNumber"].ToString();
                    break;
                }

                if (String.IsNullOrEmpty(cartem) || cartem == "Default" || cartem == "Default string")
                {
                    ManagementObjectSearcher Bios = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BIOS");

                    foreach (ManagementObject obj in Bios.Get())
                    {
                        b1os = obj["SerialNumber"].ToString();
                        break;
                    }


                }

                if (String.IsNullOrEmpty(b1os) || b1os == "Default" || b1os == "Default string")
                {
                    ManagementObjectSearcher Disque = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_DiskDrive");
                    foreach (ManagementObject obj in Disque.Get())
                    {
                        disquedur = obj["SerialNumber"].ToString();
                        break;
                    }
                }

                string id = !string.IsNullOrEmpty(cartem) && cartem != "Default" && cartem != "Default string"
                            ? cartem
                            : !string.IsNullOrEmpty(b1os) && b1os != "Default" && b1os != "Default string"
                                ? b1os
                                : !string.IsNullOrEmpty(disquedur) && disquedur != "Default" && disquedur != "Default string"
                                    ? disquedur
                                    : "UnknownHW";


                var hwid = cpu + "-" + id;

                realhwid = hwid;



                return hwid;





            }
            catch
            {
                return "Error";
            }
        }

        public static string hashHwid1()
        {
            if (string.IsNullOrEmpty(realhwid))
            {
                try
                {
                    realhwid = hwid();
                }
                catch
                {
                    realhwid = "Unknown-HW";
                }
            }

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(realhwid);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }

        public static string securityTest(string hwid, string hashHwid)
        {
            if (!string.IsNullOrEmpty(hwid) && (!string.IsNullOrEmpty(hashHwid)))
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(hwid);
                    byte[] hash = sha256.ComputeHash(bytes);
                    string value = BitConverter.ToString(hash).Replace("-", "");

                    if (value == hashHwid)
                    {
                        return "success";
                    }
                    else
                    {
                        return "error";
                    }
                }
            }
            return "error";
        }

        public static string sec2(string hashHwid)
        {
            string io = File.ReadAllText(hwidPath);

            if (!string.IsNullOrEmpty(io))
            {
                if (io == hashHwid)
                {
                    return "suc";
                }
                return "error";
            }

            return "error";
        }


        public static string sec3(string hashHwid)
        {
            if (File.Exists(hwidPath))
            {
                string io = File.ReadAllText(hwidPath);

                if (!string.IsNullOrEmpty(io))
                {
                    if (io == hashHwid)
                    {
                        return "suc";
                    }
                    else
                    {
                        return "error";
                    }
                }
                else
                {
                    return "error";
                }
            }


            else
            {
               
                genHash = hashHwid1();

                Directory.CreateDirectory(Path.GetDirectoryName(hwidPath));
                File.WriteAllText(hwidPath, genHash);

                

                if (File.Exists(hwidPath))
                {
                    return "suc";
                }
                return "error";
                
            }



        }
    }
}
