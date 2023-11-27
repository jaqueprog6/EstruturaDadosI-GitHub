using System.Collections;

// criar HashTable
Hashtable openWith = new Hashtable(); // tipo de variável: Hashtable (método construtor tem que ter o mesmo tipo da variável "Hashtable") new = método construtor

try {
    openWith.Add("txt", "notepad.exe"); // par: key, value
    openWith.Add("bmp", "paint.exe");
    openWith.Add("dib", "paint.exe");
    openWith.Add("rtf", "wordpad.exe");

    openWith.Add("txt", "notepad++.exe");
}

catch(ArgumentException aex) {
    Console.WriteLine("Oops. Invalid key.");
    Console.WriteLine($"Detalhes: {aex.Message}"); // $ = usar varíavel de uma forma mais fácil
}

catch(Exception ex) {
    Console.WriteLine("Error.");
    throw ex;
}

// openWith.Add("dib", "paint.exe");

// acessando o conteúdo na tabela hash
Console.WriteLine("Na \\ chave = \"rtf\" é {0}", openWith["rtf"]);

// alterando o conteúdo da tabela hash
openWith["rtf"] = "winword.exe";
Console.WriteLine("Na \\ chave = \"rtf\" é {0}", openWith["rtf"]);

// testar se chave existe na tabela hash

if (!openWith.Contains("ht")) {
    openWith.Add("ht", "hypertrm.exe");
    Console.WriteLine("Key ht added.");
}

// percorrendo o hash com foreach
Console.WriteLine();
foreach(DictionaryEntry de in openWith) {
    Console.WriteLine("Key = {0} - Value = {1}", de.Key, de.Value);
}

// obtendo apenas os valores do hash
ICollection valueCol = openWith.Values;
Console.WriteLine();
foreach(string s in valueCol) {
    Console.WriteLine("value = {0}", s);
}

// obtendo apenas as chaves do hash
ICollection keyCol = openWith.Keys;
Console.WriteLine();
foreach(string s in keyCol) {
    Console.WriteLine("key = {0}", s);
}

// remover registro do hash
Console.WriteLine("Removendo (\"doc\")");
openWith.Remove("doc");
if(!openWith.ContainsKey("doc")) {
    Console.WriteLine("Chave \"doc\" foi removida");
}

// Console.WriteLine("Program still loading.");