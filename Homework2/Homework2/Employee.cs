﻿using System;

namespace Homework2
{
    class Employee
    {
        public Employee(int id, string firstName, string lastName)
        {
            if (id < 0)
            {
                throw new ArgumentException(nameof(id), "ID can not be a negative number");
            }
            if (/*string.IsNullOrWhiteSpace(firstName) || */!Validations.IsAllLetters(firstName))
            {
                throw new ArgumentException(nameof(firstName), "The first name cannot be null or empty.");
            }
            if (/*string.IsNullOrWhiteSpace(lastName) ||*/ !Validations.IsAllLetters(lastName))
            {
                throw new ArgumentException(nameof(lastName), "The last name cannot be null or empty.");
            }
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
    }
}
