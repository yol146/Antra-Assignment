using System;
using System.Collections.Generic;

namespace Assignment7;

//1. create stack
public class MyStack<T>
{
    private List<T> mylist = new List<T>();

    public int Count { get { return mylist.Count; } }

    public T Pop()
    {
        T result =  mylist[mylist.Count - 1];
        mylist.RemoveAt(mylist.Count - 1);
        return result;
    }

    public void Push(T item)
    {
        mylist.Add(item);
    }

}


// create mylist
class MyList<T>
{
    private List<T> list;

    public MyList()
    {
        list = new List<T>();
    }

    public void Add(T element)
    {
        list.Add(element);
    }

    public T Remove(int index)
    {
        T element = list[index];
        list.RemoveAt(index);
        return element;
    }

    public bool Contains(T element)
    {
        return list.Contains(element);
    }

    public void Clear()
    {
        list.Clear();
    }

    public void InsertAt(T element, int index)
    {
        list.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        list.RemoveAt(index);
    }

    public T Find(int index)
    {
        return list[index];
    }
}


//3. implement repository
public interface IEntity
{
    int Id { get; set; }
}
public interface IRepository<T>
{
    public void Add(T item);
    public void Remove(T item);
    public void Save();
    public IEnumerable<T> GetAll();
    public T GetById(int id);
}

public class GenericRepository<T> : IRepository<T> where T: class, IEntity
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public void Remove(T item)
    {
        items.Remove(item);
    }

    public void Save()
    {
        // code to save changes to the data source
    }

    public IEnumerable<T> GetAll()
    {
        return items;
    }

    public T GetById(int id)
    {
        return items.FirstOrDefault(i => i.Id == id);
    }
}



















