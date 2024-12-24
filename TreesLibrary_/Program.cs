using System.Collections.Generic;

namespace TreesLibrary_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new()
            { Root = new TreeNode<int> { Data = 100 } };

            tree.Root.Children = new List<TreeNode<int>>
            {
                new TreeNode<int> { Data = 50, Parent = tree.Root },
                new TreeNode<int> { Data = 1, Parent = tree.Root },
                new TreeNode<int> { Data = 150, Parent = tree.Root },
            };
            tree.Root.Children[2].Children = new List<TreeNode<int>> //Value of 150
            {
                new TreeNode<int> { Data = 30, Parent = tree.Root.Children[2] },
                new TreeNode<int> { Data = 5, Parent = tree.Root.Children[2] },
                new TreeNode<int> { Data = 11, Parent = tree.Root.Children[2] }
            };
            tree.Root.Children[2].Children[0].Children = new List<TreeNode<int>> //Value of 30
            {
               new TreeNode<int> { Data = 96, Parent = tree.Root.Children[2].Children[0] },
               new TreeNode<int> { Data = 9, Parent = tree.Root.Children[2].Children[0] }
            };
            tree.Root.Children[1].Children = new List<TreeNode<int>> //== 1
            {
                new TreeNode<int> { Data = 70, Parent = tree.Root.Children[1] },
                new TreeNode<int> { Data = 61, Parent = tree.Root.Children[1] }
            };
            tree.Root.Children[0].Children = new List<TreeNode<int>> //Value of 50
            {
              new TreeNode<int> { Data = 12, Parent = tree.Root.Children[0] }
            };
            tree.Root.Children[0].Children[0].Children = new List<TreeNode<int>> //Value of 12
            {
                 new TreeNode<int> { Data = 45, Parent = tree.Root.Children[0].Children[0] },
                 new TreeNode<int> { Data = 21, Parent = tree.Root.Children[0].Children[0] }
            };
            tree.Root.Children[0].Children[0].Children[1].Children = new List<TreeNode<int>> //Value of 21
            {
                 new TreeNode<int> { Data = 6, Parent = tree.Root.Children[0].Children[0].Children[1]} //== 6
            };
        }
    }
}