using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi
{
    internal class WIES
    {
        public int Id { get; set; }
        public required bool isValid { get; set; }
        public string? requestDate { get; set;}
        public string? userError { get; set;}
        public required string name { get; set;}
        public required string address { get; set;}
        public string? requestIdentifier { get; set;}
        public required string originalVatNumber { get; set;}
        public required string vatNumber { get; set; }
        public override string ToString()
        {
            return $"ID: {Id}, isValid: {isValid}, requestDate: {requestDate}, name: {name}, address: {address}, requestIdentifier: {requestIdentifier}, originalVatNumber: {originalVatNumber}, vatNumber: {vatNumber}";
        }
    }
}
