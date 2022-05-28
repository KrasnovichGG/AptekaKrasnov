using AptekaKrasnov;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApteka
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAptekaFarmacevt()
        {
            Farmacevt farmacevt1 = new Farmacevt("���������", "�������", "�����������", 1975, 20);
            Farmacevt farmacevt2 = new Farmacevt("���������", "������", "���������", 1968, 15);
            Farmacevt farmacevt3 = new Farmacevt("����", "��������", "���������", 1984, 10);
            Farmacevt farmacevt4 = new Farmacevt("����������", "�������", "�������������", 1992, 6);

            List<Farmacevt> farmacevts = new List<Farmacevt>() { farmacevt1};
           
            Farmacevt farmacevt = new Farmacevt();
            farmacevt.farmacevts.Add(farmacevt1);
            farmacevt.farmacevts.Add(farmacevt2);
            farmacevt.farmacevts.Add(farmacevt3);
            farmacevt.farmacevts.Add(farmacevt4);
      
            
            CollectionAssert.AreEqual(farmacevts.Where(x=>x.Age == 1975).ToList(), farmacevt.AgePrint(1975));
        }
        [TestMethod]
        public void TestNameLec()
        {
            Lekarstva lekarstva10 = new Lekarstva("�������", "������", 370, 50, "������� ������� 2�", true);
            Lekarstva lekarstva20 = new Lekarstva("���������", "������������", 1523, 27, "������� ����� 2�", true);
            Lekarstva lekarstva30 = new Lekarstva("��������", ", ��������", 760, 40, "������� ��������� 2�", false);
            Lekarstva lekarstva40 = new Lekarstva("�������� �������", "����������", 540, 30, "������� ������ 2�", true);

            List<Lekarstva> lekarstvas = new List<Lekarstva>() { lekarstva10 };

            Lekarstva lekarstva = new Lekarstva();
            lekarstva.lekarstvas.Add(lekarstva10);
            lekarstva.lekarstvas.Add(lekarstva20);
            lekarstva.lekarstvas.Add(lekarstva30);
            lekarstva.lekarstvas.Add(lekarstva40);
            

            CollectionAssert.AreEqual(lekarstvas.Where(x => x.Name == "�������").ToList(), lekarstva.GetLekName("�������"));

        }
        [TestMethod]
        public void TestNameProizvod()
        {
            Lekarstva lekarstva10 = new Lekarstva("�������", "������", 370, 50, "������� ������� 2�", true);
            Lekarstva lekarstva20 = new Lekarstva("���������", "������������", 1523, 27, "������� ����� 2�", true);
            Lekarstva lekarstva30 = new Lekarstva("��������", ", ��������", 760, 40, "������� ��������� 2�", false);
            Lekarstva lekarstva40 = new Lekarstva("�������� �������", "����������", 540, 30, "������� ������ 2�", true);

            List<Lekarstva> lekarstvas = new List<Lekarstva>() { lekarstva10 };

            Lekarstva lekarstva = new Lekarstva();
            lekarstva.lekarstvas.Add(lekarstva10);
            lekarstva.lekarstvas.Add(lekarstva20);
            lekarstva.lekarstvas.Add(lekarstva30);
            lekarstva.lekarstvas.Add(lekarstva40);

            CollectionAssert.AreEqual(lekarstvas.Where(x => x.Proizvoditel == "������").ToList(), lekarstva.GetProivodName("������"));

        }
        [TestMethod]
        public void TestGetMaxPrice()
        {
            List<Lekarstva> lekarstvas = new List<Lekarstva>();
            lekarstvas.Add(new Lekarstva("�������", "������", 370, 50, "������� ������� 2�", true));
            lekarstvas.Add(new Lekarstva("���������", "������������", 1523, 27, "������� ����� 2�", true));
            lekarstvas.Add(new Lekarstva("��������", ", ��������", 760, 40, "������� ��������� 2�", false));
            lekarstvas.Add(new Lekarstva("�������� �������", "����������", 540, 30, "������� ������ 2�", true));
            lekarstvas.Add(new Lekarstva("��������� �����", "������", 814, 10, "������� Ƹ���� 2�", false));
            Lekarstva farmacevt = new Lekarstva();
            Assert.AreNotEqual(lekarstvas.MaxBy(x=>x.Price), farmacevt.GetPrice(1523));
        }


        [TestMethod]
        public void SortUpPriceTest()
        {
            List<Lekarstva> lekarstvas = new List<Lekarstva>();
            lekarstvas.Add(new Lekarstva("�������", "������", 370, 50, "������� ������� 2�", true));
            lekarstvas.Add(new Lekarstva("�������� �������", "����������", 540, 30, "������� ������ 2�", true));
            lekarstvas.Add(new Lekarstva("��������", ", ��������", 760, 40, "������� ��������� 2�", false));
            lekarstvas.Add(new Lekarstva("��������� �����", "������", 814, 10, "������� Ƹ���� 2�", false));
            lekarstvas.Add(new Lekarstva("���������", "������������", 1523, 27, "������� ����� 2�", true));
            Lekarstva farmacevt = new Lekarstva();
            CollectionAssert.IsNotSubsetOf(lekarstvas, farmacevt.SortUpPrice());
        }

        [TestMethod]
        public void SortDownPriceTest()
        {
            List<Lekarstva> lekarstvas = new List<Lekarstva>();
            lekarstvas.Add(new Lekarstva("���������", "������������", 1523, 27, "������� ����� 2�", true));
            lekarstvas.Add(new Lekarstva("��������� �����", "������", 814, 10, "������� Ƹ���� 2�", false));
            lekarstvas.Add(new Lekarstva("��������", ", ��������", 760, 40, "������� ��������� 2�", false));
            lekarstvas.Add(new Lekarstva("�������� �������", "����������", 540, 30, "������� ������ 2�", true));
            lekarstvas.Add(new Lekarstva("�������", "������", 370, 50, "������� ������� 2�", true));
            Lekarstva farmacevt = new Lekarstva();
            CollectionAssert.IsNotSubsetOf(lekarstvas, farmacevt.SortDownPrice());
        }
    }
}