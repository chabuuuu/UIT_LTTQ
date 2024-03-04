using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3_MaTran
{
    class MaTran
    {
        public MaTran(int nRow, int nColumn) { 
            this.nRow = nRow;
            this.nColumn = nColumn;
            this.matrix = new int[nRow, nColumn];
        }
        static bool isPrime(int number)
        {
            for (int i = 2; i * i <= number; i++)
                if (number % i == 0) return false;
            return number > 1;
        }
        public void nhap()
        {
            for (int i = 0; i < nRow; i++) { 
                for (int j = 0; j < nColumn; j++)
                {
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void xuat()
        {
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nColumn; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public int dongCoTongLonNhat()
        {
            int maxSumOfEachRow = 0;
            int rowWithMaxSum = -1;
            for (int i = 0; i < nRow; i++)
            {
                int sumOfRow = 0;
                for (int j = 0; j < nColumn; j++)
                {
                    sumOfRow += matrix[i, j];
                }
                if (sumOfRow > maxSumOfEachRow)
                {
                    maxSumOfEachRow = sumOfRow;
                    rowWithMaxSum = i;
                }
            }
            return rowWithMaxSum + 1;
        }
        public int phanTuLonNhat()
        {
            int max = 0;
            foreach (int i in matrix)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
        public int columnOf(int k)
        {
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nColumn; j++)
                {
                    if (matrix[i, j] == k)
                    {
                        return j + 1;
                    }
                }
            }
            return -1;
        }
        public int phanTuBeNhat()
        {
            int min = matrix[0,0];
            foreach (int i in matrix)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
        public int sumNotPrime()
        {
            int sum = 0;
            foreach(int i in matrix)
            {
                if (!isPrime(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
        public void deleteRow(int k)
        {
            k -= 1;
            if (k < 0)
            {
                Console.WriteLine("Cant delete row");
                return;
            }
            int nRowAfterDelete = nRow - 1;
            int[,] deletedMatrix = new int[nRowAfterDelete, nColumn];
            this.nRow = nRowAfterDelete;
            bool meetDeleteRow = false;
            for (int i = 0; i < nRow; i++)
            {
                if (i == k)
                {
                    meetDeleteRow = true;
                }
                    for (int j = 0; j < nColumn; j++)
                    {
                        if (meetDeleteRow)
                    {
                        deletedMatrix[i, j] = this.matrix[i + 1, j];
                    }
                    else
                    {
                        deletedMatrix[i, j] = this.matrix[i, j];
                    }
                }
            }
            this.matrix = new int[nRow, nColumn];
            this.matrix = deletedMatrix;
        }
        public void deleteColumn(int k)
        {
            k -= 1;
            if (k < 0)
            {
                Console.WriteLine("Cant delete column");
                return;
            }
            int nColumnAfterDelete = nColumn - 1;
            this.nColumn = nColumnAfterDelete;
            int[,] deletedMatrix = new int[nRow, nColumn];
            bool meetDeleteColumn = false;
            for (int i = 0; i < nRow; i++)
            {
                meetDeleteColumn = false;
                    for (int j = 0; j < nColumn; j++)
                    {
                    if (j == k)
                    {
                        meetDeleteColumn = true;
                    }
                    if (meetDeleteColumn)
                    {
                        deletedMatrix[i, j] = this.matrix[i, j + 1];
                    }
                    else
                    {
                        deletedMatrix[i, j] = this.matrix[i, j];
                    }
                }
            }
            this.matrix = new int[nRow, nColumn];
            this.matrix = deletedMatrix;
        }
        private int nColumn;
        private int nRow;
        int[,] matrix;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int nRow, nColumn;
            Console.WriteLine("Nhap so dong: ");
            nRow = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            nColumn = int.Parse(Console.ReadLine());
            MaTran maTran = new MaTran(nRow, nColumn);
            Console.WriteLine("Nhap ma tran: ");
            maTran.nhap();
            Console.WriteLine("Xuat ma tran: ");
            maTran.xuat();
            Console.WriteLine("Phan tu lon nhat: " + maTran.phanTuLonNhat());
            Console.WriteLine("Phan tu be nhat: " + maTran.phanTuBeNhat());
            Console.WriteLine("Dong co tong lon nhat: " + maTran.dongCoTongLonNhat());
            Console.WriteLine("Tong cac so khong phai la nguyen to: " + maTran.sumNotPrime());
            Console.WriteLine("Nhap dong muon xoa: ");
            int k = int.Parse(Console.ReadLine());
            maTran.deleteRow(k);
            Console.WriteLine("Ma tran sau khi xoa: ");
            maTran.xuat();
            int maxOfMatrix = maTran.phanTuLonNhat();
            int columnContainMaxOfMatrix = maTran.columnOf(maxOfMatrix);
            Console.WriteLine(
                "Xoa cot {0} la cot chua phan tu lon nhat trong ma tran...", 
                columnContainMaxOfMatrix
                );
            maTran.deleteColumn(columnContainMaxOfMatrix);
            Console.WriteLine("Ma tran sau khi xoa: ");
            maTran.xuat();
            Console.ReadKey();
        }
    }
}
