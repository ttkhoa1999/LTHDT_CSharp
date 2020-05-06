﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_QuanLySinhVien
{
    class QuanLySinhVien
    {

        private string maSV;
        private string hoLot;
        private string tenSV;
        private float diemToan;
        public string HoLot
        {
            get { return hoLot; }
            set { hoLot = value; }
        }
        public string TenSV
        {
            get { return tenSV; }
            set { tenSV = value; }
        }
        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public float DiemToan {
            get { return diemToan; }
            set {diemToan=value; }
        }
        public QuanLySinhVien()
        {

        }
        public QuanLySinhVien(string ma, string ho, string ten)
        {
            maSV = ma;
            hoLot = ho;
            tenSV = ten;
           
        }
        public string XuatTen()
        {
            return tenSV;
        }
        public string XuatHoLot()
        {
            return this.hoLot;
        }
        public string XuatMaSoSV()
        {
            return maSV;
        }
        public void Nhap()
        {
            Console.Write("Nhap MSSV: ");
            maSV = Console.ReadLine();
            Console.Write("Nhap Ho Lot: ");
            hoLot = Console.ReadLine();
            Console.Write("Nhap Ten: ");
            tenSV = Console.ReadLine();
            
        }
        public void Xuat()
        {
            Console.WriteLine("MSSV: {0} \t\t Ho Lot: {1} \t\t Ten: {2} ", maSV, hoLot, tenSV);
        }
    }
}
