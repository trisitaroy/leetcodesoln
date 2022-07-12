// C# program to print cousins of a node
using System;

public class GfG
{

	// A Binary Tree Node
	class Node
	{
		public int data;
		public Node left, right;
	}

	// A utility function to create
	// a new Binary Tree Node
	static Node newNode(int item)
	{
		Node temp = new Node();
		temp.data = item;
		temp.left = null;
		temp.right = null;
		return temp;
	}

	/* It returns level of the node
	if it is present in tree,
	otherwise returns 0.*/
	static int getLevel(Node root,
				Node node, int level)
	{
		// base cases
		if (root == null)
			return 0;
		if (root == node)
			return level;

		// If node is present in left subtree
		int downlevel = getLevel(root.left, node, level + 1);
		if (downlevel != 0)
			return downlevel;

		// If node is not present in left subtree
		return getLevel(root.right, node, level + 1);
	}

	/* Print nodes at a given level
	such that sibling of node is
	not printed if it exists */
	static void printGivenLevel(Node root,
						Node node, int level)
	{
		// Base cases
		if (root == null || level < 2)
			return;

		// If current node is parent of a node with
		// given level
		if (level == 2)
		{
			if (root.left == node || root.right == node)
				return;
			if (root.left != null)
				Console.Write(root.left.data + " ");
			if (root.right != null)
				Console.Write(root.right.data + " ");
		}

		// Recur for left and right subtrees
		else if (level > 2)
		{
			printGivenLevel(root.left, node, level - 1);
			printGivenLevel(root.right, node, level - 1);
		}
	}

	// This function prints cousins of a given node
	static void printCousins(Node root, Node node)
	{
		// Get level of given node
		int level = getLevel(root, node, 1);

		// Print nodes of given level.
		printGivenLevel(root, node, level);
	}
	static int heightOfBinaryTree(Node node)
	{
		if (node == null)
			return 0; // If node is null then height is 0 for that node.
		else
		{
			// compute the height of each subtree
			int leftHeight = heightOfBinaryTree(node.left);
			int rightHeight = heightOfBinaryTree(node.right);

			//use the larger among the left and right height and plus 1 (for the root)
			return Math.Max(leftHeight, rightHeight) + 1;
		}
	}
	

	// Driver code
	public static void Main(String[] args)
	{
		Node root = newNode(1);
		root.left = newNode(2);
		root.left.left = newNode(5);
		root.left.right = newNode(7);
		root.right = newNode(3);		
		root.right.left = newNode(2);
		root.right.right = newNode(9);
		MaxDepth(root);
		//			1
		//		2		3
		//	  5	  7   2	  9 
		//int x = HasPathSum(root, 3);
		//printCousins(root, root.left.right);
	}

	static bool HasPathSum(Node root, int targetSum)
	{
		bool L = false;
		bool R = false;

		int rem = targetSum- root.data; //3 1
		if(rem==0 && root.left== null && root.right == null)
        {
			return true;
			
		}
		


		if (root.left!=null)
		L=	HasPathSum(root.left, rem);

		if (root.right != null)
		R=	HasPathSum(root.right, rem);
		
	return(L || R);


	}
	 static Node  InvertTree(Node root)
	{
		if (root==null)
			return root;

		Node x = root.left;
		root.left = root.right;
		root.right = x;


		InvertTree(root.left);
		InvertTree(root.right);
		

		return root;
	}

	 static int MaxDepth(Node root)
	{
		if (root == null) return 0;



		int left = MaxDepth(root.left);

		int right = MaxDepth(root.right);

		return Math.Max(left, right) + 1;
	}
	

}


// This code is contributed Rajput-Ji
