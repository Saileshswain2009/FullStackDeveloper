using System;
using System.IO;

namespace ReadingAndWritingBinaryFiles_project
{
    class BinaryFiles
    {
        static void Main(string[] args)
        {
            BinaryReader br;
            BinaryWriter bw;
            int i = 625;
            double d = 45.5;
            char c = 'm';
            string str = "SAILESH";
            try
            {
                bw = new BinaryWriter(new FileStream("filedata", FileMode.Create));//bw pointer set to fileData.Through bw object we hv to write data in fileData file.
            }
            catch(IOException e)
            {
                Console.WriteLine("Cannot create a file");
                Console.WriteLine(e.Message);
                return;
            }

            //Writing into file
            try
            {
                bw.Write(i);//To write binary inside bw object.
                bw.Write(d);
                bw.Write(c);
                bw.Write(str);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message+"Cannot write into file");
                return;
            }
            bw.Close();//To close the file content of bw objects.


            //Reading Files
            try
            {
                br = new BinaryReader(new FileStream("filedata", FileMode.Open));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "file couldn't open");
                return;
            }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer data: " + i);
                d = br.ReadDouble();
                Console.WriteLine("Double data: " + d);
                c = br.ReadChar();
                Console.WriteLine("Character data: " + c);
                str = br.ReadString();
                Console.WriteLine("String data: " + str);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message+"Cannot found the file to read");
                return;    
            }
            br.Close();
            Console.ReadKey();
        }
    }
}
//information comes in output means reading and writing is successful in Files.