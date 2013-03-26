using System;
using System.Collections.Generic;

public class DocumentSystem
{
    private static List<IDocument> documments = new List<IDocument>();

    static void Main()
    {
        IList<string> allCommands = ReadAllCommands();
        ExecuteCommands(allCommands);
    }

    private static IList<string> ReadAllCommands()
    {
        List<string> commands = new List<string>();
        while (true)
        {
            string commandLine = Console.ReadLine();
            if (commandLine == "")
            {
                // End of commands
                break;
            }
            commands.Add(commandLine);
        }
        return commands;
    }

    private static void ExecuteCommands(IList<string> commands)
    {
        foreach (var commandLine in commands)
        {
            int paramsStartIndex = commandLine.IndexOf("[");
            string cmd = commandLine.Substring(0, paramsStartIndex);
            int paramsEndIndex = commandLine.IndexOf("]");
            string parameters = commandLine.Substring(
                paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
            ExecuteCommand(cmd, parameters);
        }
    }

    private static void ExecuteCommand(string cmd, string parameters)
    {
        string[] cmdAttributes = parameters.Split(
            new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        if (cmd == "AddTextDocument")
        {
            AddTextDocument(cmdAttributes);
        }
        else if (cmd == "AddPDFDocument")
        {
            AddPdfDocument(cmdAttributes);
        }
        else if (cmd == "AddWordDocument")
        {
            AddWordDocument(cmdAttributes);
        }
        else if (cmd == "AddExcelDocument")
        {
            AddExcelDocument(cmdAttributes);
        }
        else if (cmd == "AddAudioDocument")
        {
            AddAudioDocument(cmdAttributes);
        }
        else if (cmd == "AddVideoDocument")
        {
            AddVideoDocument(cmdAttributes);
        }
        else if (cmd == "ListDocuments")
        {
            ListDocuments();
        }
        else if (cmd == "EncryptDocument")
        {
            EncryptDocument(parameters);
        }
        else if (cmd == "DecryptDocument")
        {
            DecryptDocument(parameters);
        }
        else if (cmd == "EncryptAllDocuments")
        {
            EncryptAllDocuments();
        }
        else if (cmd == "ChangeContent")
        {
            ChangeContent(cmdAttributes[0], cmdAttributes[1]);
        }
        else
        {
            throw new InvalidOperationException("Invalid command: " + cmd);
        }
    }
  
    private static void AddTextDocument(string[] attributes)
    {
        TextDocument textDocument = new TextDocument();
        foreach (var item in attributes)
        {
            string[] temp = item.Split('=');
            textDocument.LoadProperty(temp[0], temp[1]);
        }
        if (textDocument.Name != null)
        {
            AddDocument(textDocument);
        }
        else
        {
            NoNameResponse();
        }
    }

    private static void AddPdfDocument(string[] attributes)
    {
        PDFDocument pdfDocument = new PDFDocument();
        foreach (var attribute in attributes)
        {
            string[] temp = attribute.Split('=');
            pdfDocument.LoadProperty(temp[0], temp[1]);
        }
        if (pdfDocument.Name != null)
        {
            AddDocument(pdfDocument);
        }
        else
        {
            NoNameResponse();
        }
    }

    private static void AddWordDocument(string[] attributes)
    {
        WordDocument wordDocument = new WordDocument();
        foreach (var attribute in attributes)
        {
            string[] temp = attribute.Split('=');
            wordDocument.LoadProperty(temp[0], temp[1]);
        }
        if (wordDocument.Name != null)
        {
            AddDocument(wordDocument);
        }
        else
        {
            NoNameResponse();
        }
    }

    private static void AddExcelDocument(string[] attributes)
    {
        ExcelDocument excelDocument = new ExcelDocument();
        foreach (var attribute in attributes)
        {
            string[] temp = attribute.Split('=');
            excelDocument.LoadProperty(temp[0], temp[1]);
        }
        if (excelDocument.Name != null)
        {
            AddDocument(excelDocument);
        }
        else
        {
            NoNameResponse();
        }
    }

    private static void AddAudioDocument(string[] attributes)
    {
        AudioDocument audioDocument = new AudioDocument();
        foreach (var attribute in attributes)
        {
            string[] temp = attribute.Split('=');
            audioDocument.LoadProperty(temp[0], temp[1]);
        }
        if (audioDocument.Name != null)
        {
            AddDocument(audioDocument);
        }
        else
        {
            NoNameResponse();
        }
    }

    private static void AddVideoDocument(string[] attributes)
    {
        VideoDocument videoDocument = new VideoDocument();
        foreach (var attribute in attributes)
        {
            string[] temp = attribute.Split('=');
            videoDocument.LoadProperty(temp[0], temp[1]);
        }
        if (videoDocument.Name != null)
        {
            AddDocument(videoDocument);
        }
        else
        {
            NoNameResponse();
        }
    }

    private static void NoNameResponse()
    {
        Console.WriteLine("Document has no name");
    }

    private static void AddDocument(IDocument newDocument)
    {
        documments.Add(newDocument);
        Console.WriteLine("Document added: {0}", newDocument.Name);
    }
    
    private static void ListDocuments()
    {
        if (documments.Count == 0)
        {
            Console.WriteLine("No documents found");
        }
        else
        {
            foreach (var document in documments)
            {
                Console.WriteLine(document);
            }
        }
    }

    private static void EncryptDocument(string name)
    {
        bool success = false;
        foreach (var document in documments)
        {
            if (name == document.Name)
            {
                success = true;
                if (document is IEncryptable)
                {
                    ((IEncryptable)document).Encrypt();
                    Console.WriteLine("Document encrytped: {0}", document.Name);
                }
                else
                {
                    Console.WriteLine("Document does not support encryption: {0}", document.Name);
                }
            }
        }
        if (!success)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }

    private static void DecryptDocument(string name)
    {
        bool success = false;
        foreach (var document in documments)
        {
            success = true;
            if (name == document.Name)
            {
                if (document is IEncryptable)
                {
                    ((IEncryptable)document).Decrypt();
                    Console.WriteLine("Documen decrypted: {0}", document.Name);
                }
                else
                {
                    Console.WriteLine("Document does not support encryption: {0}", document.Name);
                }
            }
        }
        if (!success)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }

    private static void EncryptAllDocuments()
    {
        bool success = false;
        foreach (var document in documments)
        {
            if (document is IEncryptable)
            {
                ((IEncryptable)document).Encrypt();
                success = true;
            }
        }
        if (success)
        {
            Console.WriteLine("All documentrs encrypted");
        }
        else
        {
            Console.WriteLine("No encryptable documents found");
        }
    }

    private static void ChangeContent(string name, string content)
    {
        bool success = false;
        foreach (var document in documments)
        {
            if (name == document.Name)
            {
                success = true;
                if (document is IEditable)
                {
                    ((IEditable)document).ChangeContent(content);
                    Console.WriteLine("Document content changed: {0}", document.Name);
                }
                else
                {
                    Console.WriteLine("Document is not editable: {0}", document.Name);
                }
            }
        }
        if (success == false)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }
}