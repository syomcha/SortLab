using System;
using System.Collections.Generic;

namespace SortLab.Sorts
{
    public class TreeSort
    {
        private class TreeNode
        {
            public string String { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(string str)
            {
                String = str;
            }

            // Рекурсивное добавление узла в дерево
            public void Insert(TreeNode node)
            {
                if (string.Compare(node.String, String) < 0)
                {
                    if (Left == null)
                        Left = node;
                    else
                        Left.Insert(node);
                }
                else
                {
                    if (Right == null)
                        Right = node;
                    else
                        Right.Insert(node);
                }
            }

            // Преобразование дерева в отсортированный массив
            public string[] ToArray(List<string> elements = null)
            {
                if (elements == null)
                    elements = new List<string>();

                if (Left != null)
                    Left.ToArray(elements);

                elements.Add(String);

                if (Right != null)
                    Right.ToArray(elements);

                return elements.ToArray();
            }
        }

        public static void Sort(string[] arr)
        {
            var treeNode = new TreeNode(arr[0]);

            for (var i = 1; i < arr.Length; i++)
                treeNode.Insert(new TreeNode(arr[i]));
        }

        public static string[] SortToArray(string[] arr)
        {
            var treeNode = new TreeNode(arr[0]);

            for (var i = 1; i < arr.Length; i++)
                treeNode.Insert(new TreeNode(arr[i]));

            return treeNode.ToArray();
        }
    }
}
