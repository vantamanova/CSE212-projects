using Microsoft.VisualStudio.TestPlatform.Utilities;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2

        if (value == Data)
        {
            return true;
        }
        if (value < Data && Left != null)
        {
            // CHeck left
            return Left.Contains(value);
        }
        if (value > Data && Right != null)
        {
            // CHeck right
            return Right.Contains(value);

        }
        else return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (Left == null && Right == null) return 1;

        int leftHeight = Left != null ? Left.GetHeight() : 0;
        int rightHeight = Right != null ? Right.GetHeight() : 0;

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}