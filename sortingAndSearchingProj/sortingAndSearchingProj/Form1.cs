using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sortingAndSearchingProj
{
    public partial class Form1 : Form
    {
        int[] numbers = { 33, 2, 5, 56, 77, 45, 48, 34, 23, 99, 18, 59, 60, 52, 13, 78, 63, 72, 96, 20 };
        
        int[] sortedNumbers = new int[20];
        int[] sortedNumbers2 = new int[20];
        int[] sortedNumbers3 = new int[20];
        int[] sortedNumbers4 = new int[20];
        int[] sortedNumbers5 = new int[20];
        int[] sortedNumbers6 = new int[20];

        int[] unsorted = new int[10000];
        int[] unsorted1 = new int[10000];
        int[] unsorted2 = new int[10000];
        int[] unsorted3 = new int[10000];
        int[] unsorted4 = new int[10000];
        int[] unsorted5 = new int[10000];
        int[] unsorted6 = new int[10000];

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < numbers.Length; i++)
            {
                lblArrayDisplay.Text += numbers[i] + ", ";
            }
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\dataToSort.txt";

            string[] readText = File.ReadAllLines(fileName);
           unsorted = Array.ConvertAll(readText, Int32.Parse);
        }
        
         // unsorted is your global array from before


        private void button1_Click(object sender, EventArgs e)
        {
            int searchValue = Convert.ToInt32(txtSearch.Text);
            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchValue)
                {
                    lblFound.Text = "The index of the number " + searchValue + " is " + i;
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                lblFound.Text = "The number you entered is not in the array";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int searchItem = int.Parse(txtSearch.Text);
            int foundPosition = intArrayBinarySearch(numbers, searchItem);
            Array.Copy(numbers, sortedNumbers, 20);
            Array.Sort(sortedNumbers);
            for (int i = 0; i < sortedNumbers.Length; i++)
            {
                lbl2.Text += sortedNumbers[i] + " , ";
            }

            if (foundPosition < 0)
            {
                lblFound.Text = "Item " + searchItem + " not found";
            }
            else
            {
                lblFound.Text = ("Item " + searchItem + " found at position " + foundPosition);
            }
        }

        public static int intArrayBinarySearch(int[] data, int item)
        {

            int min = 0;
            int N = data.Length;
            int max = N - 1;
            Array.Sort(data);

            do
            {
                int mid = (min + max) / 2;
                if (item > data[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
                if (data[mid] == item)
                {

                    return mid;
                }


            } while (min <= max);
            return -1;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblSorted.Text = "";
            Array.Copy(numbers, sortedNumbers6, 20);
            selectionSort(sortedNumbers6, sortedNumbers6.Length);
            for (int i = 0; i < sortedNumbers6.Length; i++)
            {
                lblSorted.Text += sortedNumbers6[i] + " , ";
            }

            Array.Copy(unsorted, unsorted6, 10000);
            long oldTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            selectionSort(unsorted6, unsorted6.Length);
            long newTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long totalTime = newTime - oldTime;
            lblTime.Text = totalTime.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblSorted.Text = "";
            Array.Copy(numbers, sortedNumbers2, 20);
            
            MergeSort(sortedNumbers2, 0, sortedNumbers2.Length - 1);
            for (int i = 0; i < sortedNumbers2.Length; i++)
            {
                lblSorted.Text += sortedNumbers2[i] + " , ";
            }

            Array.Copy(unsorted, unsorted2, 10000);
            long oldTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            MergeSort(unsorted2, 0, unsorted2.Length - 1);
            long newTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long totalTime = newTime - oldTime;
            lblTime.Text = totalTime.ToString();
        }

        //Merge sort

        public void MergeSort(int[] input, int low, int high)
        {
            if (low == high) return; int middle = (low / 2) + (high / 2);
            MergeSort(input, low, middle);
            MergeSort(input, middle + 1, high);
            Merge(input, low, middle, high);
        }

        public void Merge(int[] input, int low, int middle, int high)
        {
            int left = low; int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] > input[right])
                {
                    tmp[tmpIndex] = input[right]; right = right + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[left]; left = left + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }
            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right]; right = right + 1; tmpIndex = tmpIndex + 1;
                }
            }
            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }
        }

        //Quick sort

        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];
            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if (i <= j)
                {    // Swap                    
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;
                    i++;
                    j--;
                }            // Recursive calls            
                if (left < j)
                {
                    Quicksort(elements, left, j);
                }
                if (i < right)
                {
                    Quicksort(elements, i, right);
                }
            }

        }

        //bubble sort
        public static void bubbleSort(int[] a)
        {

            int t;
            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
        }

        //insertion sort
        public static void insertionSort(int[] arr, int n)
        {

            int i, j, val, flag;
            Console.WriteLine("Insertion Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
        }

        //selection sort
        public static void selectionSort(int[] arr, int n)
        {

            Console.WriteLine("Selection sort");
            Console.Write("Initial array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            lblSorted.Text = "";
            for (int i = 0; i < numbers.Length; i++)
            {

                lblSorted.Text += numbers[i] + ", ";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblSorted.Text = "";
            Array.Copy(numbers, sortedNumbers3, 20);
            
            Quicksort(sortedNumbers3, 0, sortedNumbers3.Length - 1);
            for (int i = 0; i < sortedNumbers3.Length; i++)
            {
                lblSorted.Text += sortedNumbers3[i] + " , ";
            }

            Array.Copy(unsorted, unsorted3, 10000);
            long oldTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Quicksort(unsorted3, 0, unsorted3.Length - 1);
            long newTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long totalTime = newTime - oldTime;
            lblTime.Text = totalTime.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblSorted.Text = "";
            Array.Copy(numbers, sortedNumbers4, 20);
            bubbleSort(sortedNumbers4);
            for (int i = 0; i < sortedNumbers4.Length; i++)
            {
                lblSorted.Text += sortedNumbers4[i] + " , ";
            }

            Array.Copy(unsorted, unsorted4, 10000);
            long oldTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            bubbleSort(unsorted4);
            long newTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long totalTime = newTime - oldTime;
            lblTime.Text = totalTime.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblSorted.Text = "";
            Array.Copy(numbers, sortedNumbers5, 20);
            insertionSort(sortedNumbers5, sortedNumbers5.Length);
            for (int i = 0; i < sortedNumbers5.Length; i++)
            {
                lblSorted.Text += sortedNumbers5[i] + " , ";
            }

            Array.Copy(unsorted, unsorted5, 10000);
            long oldTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            insertionSort(unsorted5, unsorted5.Length);
            long newTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long totalTime = newTime - oldTime;
            lblTime.Text = totalTime.ToString();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string sortedFileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\sortedData.txt";

            string[] numbers = Array.ConvertAll<int, string>(unsorted1, new Converter<int, string>(s => s.ToString()));

            File.WriteAllLines(sortedFileName, numbers);
            MessageBox.Show("Created! \n Go to your file explorer and look for the file 'sortedFileName'");

        }
    }
}
