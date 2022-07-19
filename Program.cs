// See https://aka.ms/new-console-template for more information
string payload = @"X5O!P%@AP[4\PZX54(P^)7CC)7}$" +
    "EICAR-STANDARD-ANT" + (char)0x49 +
    "VIRUS-TEST-FILE!$H+H*";

string path = Path.Combine(
    Environment.GetFolderPath(
    Environment.SpecialFolder.Desktop),
    Guid.NewGuid().ToString().Replace("-", "0"));

if (Directory.Exists(path) == false)
{
    Directory.CreateDirectory(path);
}

for(int i = 0; i < 4096; i++)
{
    File.WriteAllText(Path.Combine(path, $"{i}.com"), payload);
}

Console.WriteLine("ethical.blue");

