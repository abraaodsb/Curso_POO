﻿using System;
using System.Collections.Generic;
using Curso.Entities;
using Curso.Enums;

namespace Curso.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public workerLevel level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department  { get; set; }
        public List<HourContract> contracts { get; set; } = new List<HourContract>(); 
         
        public Worker()
        {
        }

        public Worker(string name, workerLevel level, double baseSalary, Department department)
        {
            Name = name;
            this.level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
