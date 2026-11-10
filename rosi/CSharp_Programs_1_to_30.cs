// C# PROGRAMMING: ALL 30 PROGRAMS IN ONE FILE
// To run a different program, change the #define below to PROGRAM_01 ... PROGRAM_30.
// Only one program should be enabled at a time because each has its own Main method.
// Create a Console App and replace its Program.cs with this file.
#define PROGRAM_01

// ====================================================================
// PROGRAM 01: First 50 Fibonacci numbers
// ====================================================================
#if PROGRAM_01
using System;
class Program {
    static void Main() {
        int a = 0, b = 1;
        for (int i = 1; i <= 50; i++) {
            Console.Write(a + " ");
            int c = a + b; a = b; b = c;
        }
    }
}
#endif

// ====================================================================
// PROGRAM 02: First 50 prime numbers
// ====================================================================
#if PROGRAM_02
using System;
class Program {
    static void Main() {
        int count = 0, num = 2;
        while (count < 50) {
            bool prime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0) { prime = false; break; }
            if (prime) { Console.Write(num + " "); count++; }
            num++;
        }
    }
}
#endif

// ====================================================================
// PROGRAM 03: Palindrome string
// ====================================================================
#if PROGRAM_03
using System;
class Program {
    static void Main() {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine(), rev = "";
        for (int i = s.Length - 1; i >= 0; i--) rev += s[i];
        Console.WriteLine(s.Equals(rev, StringComparison.OrdinalIgnoreCase)
            ? "Palindrome" : "Not a palindrome");
    }
}
#endif

// ====================================================================
// PROGRAM 04: Second largest number without sorting
// ====================================================================
#if PROGRAM_04
using System;
class Program {
    static void Main() {
        int[] a = { 10, 25, 45, 30, 60, 50 };
        int max = int.MinValue, second = int.MinValue;
        foreach (int x in a) {
            if (x > max) { second = max; max = x; }
            else if (x > second && x != max) second = x;
        }
        Console.WriteLine(second == int.MinValue ? "No second largest" :
            "Second largest: " + second);
    }
}
#endif

// ====================================================================
// PROGRAM 05: Anagram strings
// ====================================================================
#if PROGRAM_05
using System;
class Program {
    static void Main() {
        Console.Write("First string: "); string a = Console.ReadLine();
        Console.Write("Second string: "); string b = Console.ReadLine();
        char[] x = a.Replace(" ", "").ToLower().ToCharArray();
        char[] y = b.Replace(" ", "").ToLower().ToCharArray();
        Array.Sort(x); Array.Sort(y);
        Console.WriteLine(new string(x) == new string(y) ? "Anagrams" : "Not anagrams");
    }
}
#endif

// ====================================================================
// PROGRAM 06: Balanced parentheses and brackets
// ====================================================================
#if PROGRAM_06
using System;
using System.Collections.Generic;
class Program {
    static void Main() {
        Console.Write("Expression: "); string s = Console.ReadLine();
        Stack<char> st = new Stack<char>(); bool ok = true;
        foreach (char c in s) {
            if (c == '(' || c == '[' || c == '{') st.Push(c);
            else if (c == ')' || c == ']' || c == '}') {
                if (st.Count == 0) { ok = false; break; }
                char t = st.Pop();
                if ((c == ')' && t != '(') || (c == ']' && t != '[') ||
                    (c == '}' && t != '{')) { ok = false; break; }
            }
        }
        if (st.Count != 0) ok = false;
        Console.WriteLine(ok ? "Balanced" : "Not balanced");
    }
}
#endif

// ====================================================================
// PROGRAM 07: Reverse order of words
// ====================================================================
#if PROGRAM_07
using System;
class Program {
    static void Main() {
        Console.Write("Sentence: "); string s = Console.ReadLine();
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        Console.WriteLine(string.Join(" ", words));
    }
}
#endif

// ====================================================================
// PROGRAM 08: Two Sum indices
// ====================================================================
#if PROGRAM_08
using System;
class Program {
    static void Main() {
        int[] a = { 2, 7, 11, 15 };
        Console.Write("Target: "); int target = Convert.ToInt32(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < a.Length && !found; i++)
            for (int j = i + 1; j < a.Length; j++)
                if (a[i] + a[j] == target) {
                    Console.WriteLine("Indices: " + i + ", " + j);
                    found = true; break;
                }
        if (!found) Console.WriteLine("No pair found");
    }
}
#endif

// ====================================================================
// PROGRAM 09: Character frequency
// ====================================================================
#if PROGRAM_09
using System;
using System.Collections.Generic;
class Program {
    static void Main() {
        Console.Write("String: "); string s = Console.ReadLine();
        Dictionary<char, int> d = new Dictionary<char, int>();
        foreach (char c in s) {
            if (d.ContainsKey(c)) d[c]++;
            else d[c] = 1;
        }
        foreach (var p in d) Console.WriteLine(p.Key + " = " + p.Value);
    }
}
#endif

// ====================================================================
// PROGRAM 10: Missing number from 1 to N
// ====================================================================
#if PROGRAM_10
using System;
class Program {
    static void Main() {
        int[] a = { 1, 2, 4, 5, 6 }; int n = 6;
        int sum = 0;
        foreach (int x in a) sum += x;
        int missing = n * (n + 1) / 2 - sum;
        Console.WriteLine("Missing number: " + missing);
    }
}
#endif

// ====================================================================
// PROGRAM 11: First non-repeating character
// ====================================================================
#if PROGRAM_11
using System;
class Program {
    static void Main() {
        Console.Write("String: "); string s = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < s.Length; i++) {
            int count = 0;
            for (int j = 0; j < s.Length; j++) if (s[i] == s[j]) count++;
            if (count == 1) { Console.WriteLine(s[i]); found = true; break; }
        }
        if (!found) Console.WriteLine("No non-repeating character");
    }
}
#endif

// ====================================================================
// PROGRAM 12: Remove duplicates preserving order
// ====================================================================
#if PROGRAM_12
using System;
using System.Collections.Generic;
class Program {
    static void Main() {
        int[] a = { 10, 20, 10, 30, 20, 40, 50 };
        List<int> result = new List<int>();
        foreach (int x in a) if (!result.Contains(x)) result.Add(x);
        foreach (int x in result) Console.Write(x + " ");
    }
}
#endif

// ====================================================================
// PROGRAM 13: Armstrong number
// ====================================================================
#if PROGRAM_13
using System;
class Program {
    static void Main() {
        Console.Write("Number: "); int n = Convert.ToInt32(Console.ReadLine());
        int temp = n, sum = 0, digits = n.ToString().Length;
        while (temp > 0) {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, digits);
            temp /= 10;
        }
        Console.WriteLine(sum == n ? "Armstrong number" : "Not an Armstrong number");
    }
}
#endif

// ====================================================================
// PROGRAM 14: Binary search iterative and recursive
// ====================================================================
#if PROGRAM_14
using System;
class Program {
    static int Iterative(int[] a, int key) {
        int low = 0, high = a.Length - 1;
        while (low <= high) {
            int mid = low + (high - low) / 2;
            if (a[mid] == key) return mid;
            if (a[mid] < key) low = mid + 1; else high = mid - 1;
        }
        return -1;
    }
    static int Recursive(int[] a, int low, int high, int key) {
        if (low > high) return -1;
        int mid = low + (high - low) / 2;
        if (a[mid] == key) return mid;
        return a[mid] < key ? Recursive(a, mid + 1, high, key)
                            : Recursive(a, low, mid - 1, key);
    }
    static void Main() {
        int[] a = { 10, 20, 30, 40, 50, 60, 70 };
        Console.Write("Search value: "); int key = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Iterative index: " + Iterative(a, key));
        Console.WriteLine("Recursive index: " + Recursive(a, 0, a.Length - 1, key));
    }
}
#endif

// ====================================================================
// PROGRAM 15: Maximum subarray sum (Kadane)
// ====================================================================
#if PROGRAM_15
using System;
class Program {
    static void Main() {
        int[] a = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int max = a[0], current = a[0], start = 0, end = 0, temp = 0;
        for (int i = 1; i < a.Length; i++) {
            if (current < 0) { current = a[i]; temp = i; }
            else current += a[i];
            if (current > max) { max = current; start = temp; end = i; }
        }
        Console.WriteLine("Maximum sum: " + max);
        Console.Write("Subarray: ");
        for (int i = start; i <= end; i++) Console.Write(a[i] + " ");
    }
}
#endif

// ====================================================================
// PROGRAM 16: Merge two sorted arrays
// ====================================================================
#if PROGRAM_16
using System;
class Program {
    static void Main() {
        int[] a = { 1, 3, 5, 7 }, b = { 2, 4, 6, 8 };
        int[] c = new int[a.Length + b.Length];
        int i = 0, j = 0, k = 0;
        while (i < a.Length && j < b.Length)
            c[k++] = a[i] < b[j] ? a[i++] : b[j++];
        while (i < a.Length) c[k++] = a[i++];
        while (j < b.Length) c[k++] = b[j++];
        foreach (int x in c) Console.Write(x + " ");
    }
}
#endif

// ====================================================================
// PROGRAM 17: String rotation
// ====================================================================
#if PROGRAM_17
using System;
class Program {
    static void Main() {
        Console.Write("First string: "); string a = Console.ReadLine();
        Console.Write("Second string: "); string b = Console.ReadLine();
        bool ok = a.Length == b.Length && (a + a).Contains(b);
        Console.WriteLine(ok ? "Rotation" : "Not a rotation");
    }
}
#endif

// ====================================================================
// PROGRAM 18: Basic string compression
// ====================================================================
#if PROGRAM_18
using System;
class Program {
    static void Main() {
        Console.Write("String: "); string s = Console.ReadLine();
        string result = ""; int count = 1;
        for (int i = 0; i < s.Length; i++) {
            if (i + 1 < s.Length && s[i] == s[i + 1]) count++;
            else { result += s[i] + count.ToString(); count = 1; }
        }
        Console.WriteLine("Compressed: " + result);
    }
}
#endif

// ====================================================================
// PROGRAM 19: Reverse singly linked list in-place
// ====================================================================
#if PROGRAM_19
using System;
class Node {
    public int data; public Node next;
    public Node(int value) { data = value; next = null; }
}
class Program {
    static Node Reverse(Node head) {
        Node prev = null, current = head;
        while (current != null) {
            Node next = current.next;
            current.next = prev; prev = current; current = next;
        }
        return prev;
    }
    static void Display(Node head) {
        while (head != null) { Console.Write(head.data + " "); head = head.next; }
        Console.WriteLine();
    }
    static void Main() {
        Node head = new Node(10);
        head.next = new Node(20); head.next.next = new Node(30);
        head.next.next.next = new Node(40);
        Console.Write("Original: "); Display(head);
        head = Reverse(head);
        Console.Write("Reversed: "); Display(head);
    }
}
#endif

// ====================================================================
// PROGRAM 20: Detect cycle in linked list (Floyd)
// ====================================================================
#if PROGRAM_20
using System;
class Node {
    public int data; public Node next;
    public Node(int value) { data = value; next = null; }
}
class Program {
    static bool HasCycle(Node head) {
        Node slow = head, fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next; fast = fast.next.next;
            if (slow == fast) return true;
        }
        return false;
    }
    static void Main() {
        Node head = new Node(10);
        head.next = new Node(20); head.next.next = new Node(30);
        head.next.next.next = new Node(40);
        head.next.next.next.next = head.next;
        Console.WriteLine(HasCycle(head) ? "Cycle detected" : "No cycle");
    }
}
#endif

// ====================================================================
// PROGRAM 21: Generate all string permutations
// ====================================================================
#if PROGRAM_21
using System;
class Program {
    static void Permute(char[] a, int start) {
        if (start == a.Length) { Console.WriteLine(new string(a)); return; }
        for (int i = start; i < a.Length; i++) {
            char t = a[start]; a[start] = a[i]; a[i] = t;
            Permute(a, start + 1);
            t = a[start]; a[start] = a[i]; a[i] = t;
        }
    }
    static void Main() {
        Console.Write("String: "); string s = Console.ReadLine();
        Permute(s.ToCharArray(), 0);
    }
}
#endif

// ====================================================================
// PROGRAM 22: Longest substring without repeating characters
// ====================================================================
#if PROGRAM_22
using System;
using System.Collections.Generic;
class Program {
    static void Main() {
        Console.Write("String: "); string s = Console.ReadLine();
        Dictionary<char, int> map = new Dictionary<char, int>();
        int start = 0, max = 0;
        for (int i = 0; i < s.Length; i++) {
            if (map.ContainsKey(s[i]) && map[s[i]] >= start)
                start = map[s[i]] + 1;
            map[s[i]] = i;
            max = Math.Max(max, i - start + 1);
        }
        Console.WriteLine("Longest length: " + max);
    }
}
#endif

// ====================================================================
// PROGRAM 23: Rotate array right by K steps
// ====================================================================
#if PROGRAM_23
using System;
class Program {
    static void Main() {
        int[] a = { 1, 2, 3, 4, 5, 6, 7 };
        Console.Write("K: "); int k = Convert.ToInt32(Console.ReadLine());
        int n = a.Length; k %= n; int[] result = new int[n];
        for (int i = 0; i < n; i++) result[(i + k) % n] = a[i];
        foreach (int x in result) Console.Write(x + " ");
    }
}
#endif

// ====================================================================
// PROGRAM 24: Intersection of two arrays
// ====================================================================
#if PROGRAM_24
using System;
using System.Collections.Generic;
class Program {
    static void Main() {
        int[] a = { 1, 2, 3, 4, 5 }, b = { 3, 4, 5, 6, 7 };
        HashSet<int> set = new HashSet<int>(a);
        HashSet<int> common = new HashSet<int>();
        foreach (int x in b) if (set.Contains(x)) common.Add(x);
        foreach (int x in common) Console.Write(x + " ");
    }
}
#endif

// ====================================================================
// PROGRAM 25: Majority element (Boyer-Moore)
// ====================================================================
#if PROGRAM_25
using System;
class Program {
    static void Main() {
        int[] a = { 2, 2, 1, 1, 2, 2, 2 };
        int candidate = 0, count = 0;
        foreach (int x in a) {
            if (count == 0) candidate = x;
            count += x == candidate ? 1 : -1;
        }
        count = 0;
        foreach (int x in a) if (x == candidate) count++;
        Console.WriteLine(count > a.Length / 2 ?
            "Majority element: " + candidate : "No majority element");
    }
}
#endif

// ====================================================================
// PROGRAM 26: Thread-safe Singleton pattern
// ====================================================================
#if PROGRAM_26
using System;
class Singleton {
    private static readonly Lazy<Singleton> instance =
        new Lazy<Singleton>(() => new Singleton());
    private Singleton() { Console.WriteLine("Singleton created"); }
    public static Singleton Instance { get { return instance.Value; } }
    public void Display() { Console.WriteLine("Singleton executed"); }
}
class Program {
    static void Main() {
        Singleton a = Singleton.Instance, b = Singleton.Instance;
        a.Display();
        Console.WriteLine(Object.ReferenceEquals(a, b) ?
            "Same instance" : "Different instances");
    }
}
#endif

// ====================================================================
// PROGRAM 27: LRU Cache with O(1) Get and Put
// ====================================================================
#if PROGRAM_27
using System;
using System.Collections.Generic;
class LRUCache {
    int capacity;
    Dictionary<int, LinkedListNode<KeyValuePair<int, int>>> map =
        new Dictionary<int, LinkedListNode<KeyValuePair<int, int>>>();
    LinkedList<KeyValuePair<int, int>> list =
        new LinkedList<KeyValuePair<int, int>>();
    public LRUCache(int capacity) { this.capacity = capacity; }
    public int Get(int key) {
        if (!map.ContainsKey(key)) return -1;
        var node = map[key]; list.Remove(node); list.AddFirst(node);
        return node.Value.Value;
    }
    public void Put(int key, int value) {
        if (map.ContainsKey(key)) {
            var node = map[key]; list.Remove(node);
            node.Value = new KeyValuePair<int, int>(key, value);
            list.AddFirst(node);
        } else {
            if (map.Count == capacity) {
                var last = list.Last; map.Remove(last.Value.Key); list.RemoveLast();
            }
            var node = new LinkedListNode<KeyValuePair<int, int>>(
                new KeyValuePair<int, int>(key, value));
            list.AddFirst(node); map[key] = node;
        }
    }
}
class Program {
    static void Main() {
        LRUCache c = new LRUCache(2);
        c.Put(1, 10); c.Put(2, 20);
        Console.WriteLine("Get 1: " + c.Get(1));
        c.Put(3, 30);
        Console.WriteLine("Get 2: " + c.Get(2));
        Console.WriteLine("Get 3: " + c.Get(3));
    }
}
#endif

// ====================================================================
// PROGRAM 28: Validate Binary Search Tree
// ====================================================================
#if PROGRAM_28
using System;
class Node {
    public int data; public Node left, right;
    public Node(int value) { data = value; }
}
class Program {
    static bool IsBST(Node root, long min, long max) {
        if (root == null) return true;
        if (root.data <= min || root.data >= max) return false;
        return IsBST(root.left, min, root.data) &&
               IsBST(root.right, root.data, max);
    }
    static void Main() {
        Node root = new Node(50);
        root.left = new Node(30); root.right = new Node(70);
        root.left.left = new Node(20); root.left.right = new Node(40);
        root.right.left = new Node(60); root.right.right = new Node(80);
        Console.WriteLine(IsBST(root, long.MinValue, long.MaxValue) ?
            "Valid BST" : "Not a valid BST");
    }
}
#endif

// ====================================================================
// PROGRAM 29: Count set bits in an integer
// ====================================================================
#if PROGRAM_29
using System;
class Program {
    static void Main() {
        Console.Write("Integer: "); int n = Convert.ToInt32(Console.ReadLine());
        uint value = unchecked((uint)n); int count = 0;
        while (value != 0) { value &= value - 1; count++; }
        Console.WriteLine("Set bits: " + count);
    }
}
#endif

// ====================================================================
// PROGRAM 30: Producer-Consumer using BlockingCollection
// ====================================================================
#if PROGRAM_30
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
class Program {
    static BlockingCollection<int> queue = new BlockingCollection<int>();
    static void Producer() {
        for (int i = 1; i <= 5; i++) {
            queue.Add(i); Console.WriteLine("Produced: " + i);
        }
        queue.CompleteAdding();
    }
    static void Consumer() {
        foreach (int item in queue.GetConsumingEnumerable())
            Console.WriteLine("Consumed: " + item);
    }
    static void Main() {
        Task p = Task.Run(() => Producer());
        Task c = Task.Run(() => Consumer());
        Task.WaitAll(p, c);
        Console.WriteLine("Producer-Consumer completed");
    }
}
#endif
