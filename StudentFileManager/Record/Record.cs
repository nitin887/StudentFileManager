/*
Each record contains:

Id,Name,Marks
*/
namespace Records{
 public class Record
{
    public int Id
    {
        get;
        set;
    }
    public string Name
    {
        get;
        set;
    }
    public double Marks
    {
        get;
        set;
    }
    public Record(int id,string name,double marks)
    {
        Id=id;
        Name=name;
        Marks=marks;
        
    }


 
}}