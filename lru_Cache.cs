using System;
using System.Collections.Generic;

class LRUCache
{
    int capacity;

    Dictionary<int, LinkedListNode<KeyValuePair<int, int>>> map =
        new Dictionary<int, LinkedListNode<KeyValuePair<int, int>>>();

    LinkedList<KeyValuePair<int, int>> list =
        new LinkedList<KeyValuePair<int, int>>();

    public LRUCache(int size)
    {
        capacity = size;
    }

    public int Get(int key)
    {
        if (!map.ContainsKey(key))
            return -1;

        var node = map[key];

        list.Remove(node);
        list.AddFirst(node);

        return node.Value.Value;
    }

    public void Put(int key, int value)
    {
        if (map.ContainsKey(key))
        {
            list.Remove(map[key]);
        }
        else if (list.Count == capacity)
        {
            int oldKey = list.Last.Value.Key;
            list.RemoveLast();
            map.Remove(oldKey);
        }

        var node = new LinkedListNode<KeyValuePair<int, int>>(
            new KeyValuePair<int, int>(key, value));

        list.AddFirst(node);
        map[key] = node;
    }
}

class Program
{
    static void Main()
    {
        LRUCache cache = new LRUCache(2);

        cache.Put(1, 10);
        cache.Put(2, 20);

        Console.WriteLine(cache.Get(1));

        cache.Put(3, 30);

        Console.WriteLine(cache.Get(2));
        Console.WriteLine(cache.Get(3));
    }
}