public class FileReader
{
    Dictionary<string, List<string>> groupList;
    Dictionary<string, List<string>> questionList;
    
    public FileReader()
    {
        string[] groupsFiles = Directory.GetFiles("data/groups");
        string[] questionsFiles = Directory.GetFiles("data/questions");
        foreach (var f in groupsFiles)
        {
            string fileName = f.Split('\\')[1];
            groupList.Add(fileName.Split('.')[0],new List<string>());
            using (StreamReader reader = new StreamReader(f))
            {
                string text = reader.ReadLine();
                Console.WriteLine(text);
            }
        }
    }
}
