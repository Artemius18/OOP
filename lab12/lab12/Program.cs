using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab12
{
     internal class Programm
    {
        static void Main()
        {


            try
            {
                PAFLog PAFLog_01 = new PAFLog(@"D:\BSTU\2course\1term\OOP\lab12\lab12\PAFlogfile.txt");
                PAFDiskInfo.OnUpdate += PAFLog_01.WriteActionInFile;
                PAFFileInfo.OnUpdate += PAFLog_01.WriteActionInFile;
                PAFDirInfo.OnUpdate += PAFLog_01.WriteActionInFile;
                //PAFFileManager.OnUpdate += PAFLog_01.WriteActionInFile;

                //test DiskInfo
                PAFDiskInfo.ShowFreeSpace(@"C:\");
                PAFDiskInfo.ShowFileSystemInformation(@"C:\");

                //PAFDiskInfo.ShowFreeSpace(@"D:\");
                //PAFDiskInfo.ShowFileSystemInformation(@"D:\");

                //PAFDiskInfo.ShowFreeSpace(@"F:\");
                //PAFDiskInfo.ShowFileSystemInformation(@"F:\");

                PAFDiskInfo.ShowInformationAllDrivers();

                //test FileInfo
                PAFFileInfo.ShowFullPatch(@"D:\BSTU\2course\1term\OOP\lab12\lab12\PAFlogfile.txt");
                PAFFileInfo.ShowFileInformation(@"D:\BSTU\2course\1term\OOP\lab12\lab12\PAFlogfile.txt");
                PAFFileInfo.ShowFileDatesCreateAndUpdate(@"D:\BSTU\2course\1term\OOP\lab12\lab12\PAFlogfile.txt");

                //test DirInfo
                PAFDirInfo.ShowAmountOfFile(@"D:\BSTU\2course\1term\OOP\lab12\lab12");
                PAFDirInfo.ShowCreationTime(@"D:\BSTU\2course\1term\OOP\lab12\lab12");
                PAFDirInfo.ShowAmountOfSubdirectories(@"D:\BSTU\2course\1term\OOP");
                PAFDirInfo.ShowParentDirectory(@"D:\BSTU\2course\1term\OOP\lab12\lab12");

                //test FileManger         
                PAFLog PAFLog_02 = new PAFLog(@"D:\BSTU\2course\1term\OOP\lab12\lab12\PAFInspect\PAFdirinfo.txt");
                PAFFileManager.OnUpdate += PAFLog_02.WriteActionInFile;
                                            
                PAFFileManager.CreateDirectory(@"D:\BSTU\2course\1term\OOP\lab12\lab12\PAFInspect");
                PAFFileManager.CreateFile(@"D:\BSTU\2course\1term\OOP\lab12\lab12\PAFInspect\PAFdirinfo.txt");

                PAFFileManager.ShowListDirectoryAndFileDisk(@"D:\");
                PAFFileManager.CopyFile(@"D:\BSTU\2course\1term\OOP\lab12\lab12\PAFInspect\PAFdirinfo.txt");
                PAFFileManager.DeleteFile(@"D:\BSTU\2course\1term\OOP\lab12\lab12\PAFInspect\PAFdirinfo.txt");
                PAFFileManager.CopyFileFromDirectory(@"D:\BSTU\2course\1term\OOP\lab12\lab12\PAFInspect", ".txt");

                PAFFileManager.MoveDirectory(@"D:\BSTU\2course\1term\OOP\lab12\lab12\PAFFiles\", @"D:\BSTU\2course\1term\OOP\lab12\lab12\PAFInspect\PAFFiles");

                PAFFileManager.CreateZipFromDirectory(@"D:\BSTU\2course\1term\OOP\lab12\lab12\PAFInspect\PAFFiles");

                PAFFileManager.ShowDirectoryFromZip(@"D:\BSTU\2course\1term\OOP\lab12\lab12\PAFInspect\PAFFiles.zip", @"D:\BSTU\2course\1term\OOP\lab12\lab12\Unnarchive");

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine("Enter day: ");
                int dayUser = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter hour: ");
                int hourUser = int.Parse(Console.ReadLine());

                PAFFileManager.FindInformationFromDay(dayUser, hourUser, 0);
                Console.WriteLine("=======================================================================");
                Console.WriteLine("Enter number of action: ");
                int actionUser = int.Parse(Console.ReadLine());
                PAFFileManager.FindInformationFromDay(dayUser, hourUser, actionUser);
                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}