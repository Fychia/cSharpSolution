using Microsoft.VisualBasic;
using Stowage;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Stowage2022
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string path = @"D:\wetok\Projetos\Stowage2022\README.txt";
            string pathCopy = @"D:\wetok\Projetos\Stowage2022\README3.txt";

            //Console.WriteLine("Pastas do diretório:");
            //string[] folderArray = Directory.GetDirectories("D:\\wetok\\Projetos\\Stowage2022");
            //string[] fileArray = Directory.GetFiles("D:\\wetok\\Projetos\\Stowage2022");
            //for (int i = 0; i < folderArray.Length; i++)
            //{
            //    Console.WriteLine(folderArray[i]);
            //}
            //Console.WriteLine("\n \n Arquivos do diretório");
            //for (int y = 0; y < fileArray.Length; y++)
            //{
            //    Console.WriteLine(fileArray[y]);
            //}
            //Console.ReadLine();
            //using (IFileStorage fs = Files.Of.LocalDisk("D:\\wetok\\Projetos\\Stowage2022"))
            //{
            //    string[] fileArray = Directory.GetFiles("D:\\wetok\\Projetos\\Stowage2022");
            //    for (int i = 0; i < fileArray.Length; i++)
            //    {

            //        Console.WriteLine(fileArray[i]);
            //    }
            //    Console.ReadLine();
            //}

            //using (IFileStorage fs = Files.Of.LocalDisk("D:\\wetok\\Projetos\\Stowage2022"))
            //{
            //    List<string> fileNames = new List<string>();
            //    var varFiles = fs.Ls();

            //    foreach (var varFile in varFiles.ToString())
            //    {
            //        fileNames.Add(varFile.ToString());
            //    }

            //    foreach (var fileName in fileNames)
            //    {
            //        Console.WriteLine(fileName);
            //    }
            //}
            //try
            //{
            //    //fs.OpenRead(pathCopy);
            //    //fs.WriteText(pathCopy, "");
            //    FileInfo fileInfo = new FileInfo(path);
            //    FileInfo fileInfoCopy = new FileInfo(pathCopy);
            //    if (fileInfo.Exists)
            //    {
            //        fileInfoCopy.Delete();
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("Ocorreu um erro" + e);
            //}
            /***********************************************************************************/
            //lISTA DIRETÓRIO
            //using (IFileStorage fs = Files.Of.LocalDisk("D:\\wetok\\Projetos\\Stowage2022"))
            //{
            //    string[] folders = System.IO.Directory.GetDirectories("D:\\wetok\\Projetos\\Stowage2022", "*", System.IO.SearchOption.AllDirectories);
            //    Console.WriteLine(folders[2]);
            //}
            /***********************************************************************************/
            //LISTA - PASTAS
            //using (IFileStorage fs = Files.Of.LocalDisk("D:\\wetok\\Projetos\\Stowage2022"))
            //{
            //    string[] fileArray = Directory.GetDirectories("D:\\wetok\\Projetos\\Stowage2022");
            //    for (int i = 0; i < fileArray.Length; i++)
            //    {

            //        Console.WriteLine(fileArray[i]);
            //    }
            //    Console.ReadLine();
            //}
            /***********************************************************************************/
            //LISTA DE ARQUIVO
            //using (IFileStorage fs = Files.Of.LocalDisk("D:\\wetok\\Projetos\\Stowage2022"))
            //{
            //    string[] fileArray = Directory.GetFiles("D:\\wetok\\Projetos\\Stowage2022");
            //    for (int i = 0; i < fileArray.Length; i++)
            //    {

            //        Console.WriteLine(fileArray[i]);
            //    }
            //    Console.ReadLine();
            //}
            /***********************************************************************************/
            //LISTA
            //Console.WriteLine("Pastas do diretório:");
            //string[] folderArray = Directory.GetDirectories("D:\\wetok\\Projetos\\Stowage2022");
            //string[] fileArray = Directory.GetFiles("D:\\wetok\\Projetos\\Stowage2022");
            //for (int i = 0; i < folderArray.Length; i++)
            //{
            //    Console.WriteLine(folderArray[i]);
            //}
            //Console.WriteLine("\n \n Arquivos do diretório");
            //for (int y = 0; y < fileArray.Length; y++)
            //{
            //    Console.WriteLine(fileArray[y]);
            //}
            //Console.ReadLine();
            /***********************************************************************************/
            //CREATE
            //using (IFileStorage fs = Files.Of.LocalDisk("D:\\wetok\\Projetos\\Stowage2022"))
            //{
            //    fs.WriteText("README.txt", "READMEREADMEREADMEREADMEADMEREADMEREADMEREADME");

            //    fs.WriteText("README2.txt", "");

            //    fs.WriteText("README1.pdf", "README");

            //    fs.WriteAsJson("JSON.json", "string jsonString = \"{\\\"name\\\":\\\"John\\\",\\\"age\\\":30,\\\"city\\\":\\\"New York\\\"}\";\r\n");

            //    fs.WriteAsJson("JSON.xml", "string jsonString = \"{\\\"name\\\":\\\"John\\\",\\\"age\\\":30,\\\"city\\\":\\\"New York\\\"}\";\r\n");

            //    fs.Ren("README.txt", "README8.txt"); // Copia melhorada

            //    fs.Ren("README.txt", "Transfer\\README8.txt"); //Copia para outra pasta

            //}
            /***********************************************************************************/
            //ALTERAÇÃO - FILE INFO algo Existente
            //using (IFileStorage fs = Files.Of.LocalDisk("D:\\wetok\\Projetos\\Stowage2022\\Transfer"))
            //{

            //    try
            //    {
            //        await fs.WriteText(pathCopy, "");
            //        await fs.OpenRead(pathCopy);
            //        FileInfo fileInfo = new FileInfo(path);
            //        FileInfo fileInfoCopy = new FileInfo(pathCopy);
            //        if (fileInfo.Exists)
            //        {
            //            fileInfoCopy.Delete();
            //            fileInfo.CopyTo(pathCopy);
            //        }
            //    }
            //    catch (IOException e)
            //    {
            //        Console.WriteLine("Ocorreu um erro" + e);
            //    }
            //}
            /***********************************************************************************/
            //DELETE()
            //using (IFileStorage fs = Files.Of.LocalDisk("D:\\wetok\\Projetos\\Stowage2022\\Transfer"))
            //{

            //    try
            //    {
            //        //fs.OpenRead(pathCopy);
            //        //fs.WriteText(pathCopy, "");
            //        FileInfo fileInfo = new FileInfo(path);
            //        FileInfo fileInfoCopy = new FileInfo(pathCopy);
            //        if (fileInfo.Exists)
            //        {
            //            fileInfoCopy.Delete();
            //        }
            //    }
            //    catch (IOException e)
            //    {
            //        Console.WriteLine("Ocorreu um erro" + e);
            //    }
            //}
            /***********************************************************************************/
            //PERCORER ARQUIVO E APRESENTAR
            //FileStream fileStream = null;
            //StreamReader fileStreamReader = null;

            //try
            //{
            //    fileStream = new FileStream(path, FileMode.Open);
            //    fileStreamReader = new StreamReader(fileStream);

            //    while (!fileStreamReader.EndOfStream)
            //    {
            //        string line = fileStreamReader.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("Um erro ocorreu " + ex.Message);
            //}

            /***********************************************************************************/
            //using (IFileStorage fs = Files.Of.LocalDisk("D:\\wetok\\Projetos\\Stowage2022"))
            //{
            //    FolderBrowserDialog fbd = new FolderBrowserDialog();

            //    DialogResult result = fbd.ShowDialog();

            //    string[] files = Directory.GetFiles(fbd.SelectedPath);
            //    string[] dirs = Directory.GetDirectories(fbd.SelectedPath);

            //    foreach (string item2 in dirs)
            //    {
            //        FileInfo f = new FileInfo(item2);

            //        listBox1.Items.Add(f.Name);

            //    }

            //    foreach (string item in files)
            //    {
            //        FileInfo f = new FileInfo(item);

            //        listBox1.Items.Add(f.Name);

            //    }
                /***********************************************************************************/








            }
    }

}




















