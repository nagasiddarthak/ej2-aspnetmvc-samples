#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJ2MVCSampleBrowser.Models
{
    public class PivotTableData
    {
        public List<RData> GetRData()
        {
            List<RData> rData = new List<RData>();
            rData.Add(new RData
            {
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 46,
                ProCost = 43
            });
            rData.Add(new RData
            {
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 30,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 125,
                ProCost = 96
            });
            rData.Add(new RData
            {
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 215,
                ProCost = 123
            });
            rData.Add(new RData
            {
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 263,
                ProCost = 125
            });
            rData.Add(new RData
            {
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 61,
                ProCost = 50
            });
            rData.Add(new RData
            {
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 31
            });
            rData.Add(new RData
            {
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 133,
                ProCost = 110
            });
            rData.Add(new RData
            {
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 33,
                ProCost = 65
            });
            rData.Add(new RData
            {
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 37,
                ProCost = 20
            });
            rData.Add(new RData
            {
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 109,
                ProCost = 96
            });
            rData.Add(new RData
            {
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 266,
                ProCost = 139
            });
            rData.Add(new RData
            {
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 257,
                ProCost = 143
            });
            rData.Add(new RData
            {
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 79,
                ProCost = 53
            });
            rData.Add(new RData
            {
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 28,
                ProCost = 48
            });
            rData.Add(new RData
            {
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 128,
                ProCost = 117
            });
            rData.Add(new RData
            {
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 68,
                ProCost = 48
            });
            rData.Add(new RData
            {
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 26,
                ProCost = 32
            });
            rData.Add(new RData
            {
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 141,
                ProCost = 98
            });
            rData.Add(new RData
            {
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 281,
                ProCost = 134
            });
            rData.Add(new RData
            {
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 228,
                ProCost = 107
            });
            rData.Add(new RData
            {
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 73,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 19,
                ProCost = 44
            });
            rData.Add(new RData
            {
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 149,
                ProCost = 82
            });
            rData.Add(new RData
            {
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 47,
                ProCost = 58
            });
            rData.Add(new RData
            {
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 25,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 127,
                ProCost = 93
            });
            rData.Add(new RData
            {
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 216,
                ProCost = 124
            });
            rData.Add(new RData
            {
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 267,
                ProCost = 100
            });
            rData.Add(new RData
            {
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 52,
                ProCost = 65
            });
            rData.Add(new RData
            {
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 39,
                ProCost = 33
            });
            rData.Add(new RData
            {
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 142,
                ProCost = 97
            });
            rData.Add(new RData
            {
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 53,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 23,
                ProCost = 44
            });
            rData.Add(new RData
            {
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 113,
                ProCost = 106
            });
            rData.Add(new RData
            {
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 270,
                ProCost = 101
            });
            rData.Add(new RData
            {
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 284,
                ProCost = 105
            });
            rData.Add(new RData
            {
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 62,
                ProCost = 43
            });
            rData.Add(new RData
            {
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 32,
                ProCost = 26
            });
            rData.Add(new RData
            {
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 133,
                ProCost = 83
            });
            rData.Add(new RData
            {
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 51,
                ProCost = 65
            });
            rData.Add(new RData
            {
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 13,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 139,
                ProCost = 101
            });
            rData.Add(new RData
            {
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 297,
                ProCost = 130
            });
            rData.Add(new RData
            {
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 236,
                ProCost = 119
            });
            rData.Add(new RData
            {
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 57,
                ProCost = 66
            });
            rData.Add(new RData
            {
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 16,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 110,
                ProCost = 93
            });
            rData.Add(new RData
            {
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 55,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 32,
                ProCost = 39
            });
            rData.Add(new RData
            {
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 128,
                ProCost = 120
            });
            rData.Add(new RData
            {
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 290,
                ProCost = 128
            });
            rData.Add(new RData
            {
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 201,
                ProCost = 105
            });
            rData.Add(new RData
            {
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 55,
                ProCost = 46
            });
            rData.Add(new RData
            {
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 37
            });
            rData.Add(new RData
            {
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 122,
                ProCost = 118
            });
            rData.Add(new RData
            {
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 69,
                ProCost = 54
            });
            rData.Add(new RData
            {
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 21,
                ProCost = 41
            });
            rData.Add(new RData
            {
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 140,
                ProCost = 83
            });
            rData.Add(new RData
            {
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 239,
                ProCost = 121
            });
            rData.Add(new RData
            {
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 283,
                ProCost = 127
            });
            rData.Add(new RData
            {
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 80,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 33,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 120,
                ProCost = 81
            });
            rData.Add(new RData
            {
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 41,
                ProCost = 69
            });
            rData.Add(new RData
            {
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 14,
                ProCost = 21
            });
            rData.Add(new RData
            {
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 144,
                ProCost = 93
            });
            rData.Add(new RData
            {
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 294,
                ProCost = 146
            });
            rData.Add(new RData
            {
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 217,
                ProCost = 103
            });
            rData.Add(new RData
            {
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 49,
                ProCost = 44
            });
            rData.Add(new RData
            {
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 36,
                ProCost = 21
            });
            rData.Add(new RData
            {
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 118,
                ProCost = 115
            });
            rData.Add(new RData
            {
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 56,
                ProCost = 41
            });
            rData.Add(new RData
            {
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 17,
                ProCost = 36
            });
            rData.Add(new RData
            {
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 140,
                ProCost = 81
            });
            rData.Add(new RData
            {
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 274,
                ProCost = 109
            });
            rData.Add(new RData
            {
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 284,
                ProCost = 145
            });
            rData.Add(new RData
            {
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 40,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 12,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 150,
                ProCost = 115
            });
            rData.Add(new RData
            {
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 73,
                ProCost = 64
            });
            rData.Add(new RData
            {
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 23,
                ProCost = 47
            });
            rData.Add(new RData
            {
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 102,
                ProCost = 112
            });
            rData.Add(new RData
            {
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 252,
                ProCost = 112
            });
            rData.Add(new RData
            {
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 222,
                ProCost = 131
            });
            rData.Add(new RData
            {
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 52,
                ProCost = 46
            });
            rData.Add(new RData
            {
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 35,
                ProCost = 30
            });
            rData.Add(new RData
            {
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 104,
                ProCost = 101
            });
            rData.Add(new RData
            {
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 46,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 19,
                ProCost = 31
            });
            rData.Add(new RData
            {
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 118,
                ProCost = 89
            });
            rData.Add(new RData
            {
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 227,
                ProCost = 130
            });
            rData.Add(new RData
            {
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 226,
                ProCost = 144
            });
            rData.Add(new RData
            {
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 40,
                ProCost = 52
            });
            rData.Add(new RData
            {
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 19,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 127,
                ProCost = 91
            });
            rData.Add(new RData
            {
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 70,
                ProCost = 66
            });
            rData.Add(new RData
            {
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 36,
                ProCost = 21
            });
            rData.Add(new RData
            {
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 144,
                ProCost = 85
            });
            rData.Add(new RData
            {
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 212,
                ProCost = 130
            });
            rData.Add(new RData
            {
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 210,
                ProCost = 110
            });
            rData.Add(new RData
            {
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 72,
                ProCost = 56
            });
            rData.Add(new RData
            {
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 13,
                ProCost = 47
            });
            rData.Add(new RData
            {
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 139,
                ProCost = 98
            });
            rData.Add(new RData
            {
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 59,
                ProCost = 54
            });
            rData.Add(new RData
            {
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 26,
                ProCost = 21
            });
            rData.Add(new RData
            {
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 120,
                ProCost = 97
            });
            rData.Add(new RData
            {
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 299,
                ProCost = 124
            });
            rData.Add(new RData
            {
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 240,
                ProCost = 110
            });
            rData.Add(new RData
            {
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 71,
                ProCost = 61
            });
            rData.Add(new RData
            {
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 40,
                ProCost = 33
            });
            rData.Add(new RData
            {
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 134,
                ProCost = 111
            });
            rData.Add(new RData
            {
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 33,
                ProCost = 50
            });
            rData.Add(new RData
            {
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 18,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 139,
                ProCost = 85
            });
            rData.Add(new RData
            {
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 217,
                ProCost = 141
            });
            rData.Add(new RData
            {
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 252,
                ProCost = 101
            });
            rData.Add(new RData
            {
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 31,
                ProCost = 42
            });
            rData.Add(new RData
            {
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 15,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 117,
                ProCost = 112
            });
            rData.Add(new RData
            {
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 34,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 10,
                ProCost = 43
            });
            rData.Add(new RData
            {
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 110,
                ProCost = 83
            });
            rData.Add(new RData
            {
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 212,
                ProCost = 137
            });
            rData.Add(new RData
            {
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 222,
                ProCost = 126
            });
            rData.Add(new RData
            {
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 75,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 31,
                ProCost = 37
            });
            rData.Add(new RData
            {
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 105,
                ProCost = 98
            });
            rData.Add(new RData
            {
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 72,
                ProCost = 45
            });
            rData.Add(new RData
            {
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 45
            });
            rData.Add(new RData
            {
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 143,
                ProCost = 92
            });
            rData.Add(new RData
            {
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 272,
                ProCost = 128
            });
            rData.Add(new RData
            {
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 208,
                ProCost = 136
            });
            rData.Add(new RData
            {
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 48,
                ProCost = 46
            });
            rData.Add(new RData
            {
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 22,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 150,
                ProCost = 100
            });
            rData.Add(new RData
            {
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 60,
                ProCost = 43
            });
            rData.Add(new RData
            {
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 15,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 107,
                ProCost = 97
            });
            rData.Add(new RData
            {
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 204,
                ProCost = 136
            });
            rData.Add(new RData
            {
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 210,
                ProCost = 111
            });
            rData.Add(new RData
            {
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 65,
                ProCost = 47
            });
            rData.Add(new RData
            {
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 26,
                ProCost = 45
            });
            rData.Add(new RData
            {
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 112,
                ProCost = 115
            });
            rData.Add(new RData
            {
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 54,
                ProCost = 66
            });
            rData.Add(new RData
            {
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 31,
                ProCost = 36
            });
            rData.Add(new RData
            {
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 120,
                ProCost = 112
            });
            rData.Add(new RData
            {
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 261,
                ProCost = 149
            });
            rData.Add(new RData
            {
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 226,
                ProCost = 124
            });
            rData.Add(new RData
            {
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 72,
                ProCost = 63
            });
            rData.Add(new RData
            {
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 35,
                ProCost = 33
            });
            rData.Add(new RData
            {
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 144,
                ProCost = 118
            });
            rData.Add(new RData
            {
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 293,
                ProCost = 118
            });
            rData.Add(new RData
            {
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 237,
                ProCost = 110
            });
            rData.Add(new RData
            {
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 36,
                ProCost = 50
            });
            rData.Add(new RData
            {
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 36
            });
            rData.Add(new RData
            {
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 120,
                ProCost = 95
            });
            rData.Add(new RData
            {
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 46,
                ProCost = 59
            });
            rData.Add(new RData
            {
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 31,
                ProCost = 33
            });
            rData.Add(new RData
            {
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 147,
                ProCost = 96
            });
            rData.Add(new RData
            {
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 230,
                ProCost = 100
            });
            rData.Add(new RData
            {
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 236,
                ProCost = 104
            });
            rData.Add(new RData
            {
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 60,
                ProCost = 57
            });
            rData.Add(new RData
            {
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 33,
                ProCost = 41
            });
            rData.Add(new RData
            {
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 140,
                ProCost = 105
            });
            rData.Add(new RData
            {
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 31,
                ProCost = 55
            });
            rData.Add(new RData
            {
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 30
            });
            rData.Add(new RData
            {
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 117,
                ProCost = 106
            });
            rData.Add(new RData
            {
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 259,
                ProCost = 127
            });
            rData.Add(new RData
            {
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 294,
                ProCost = 126
            });
            rData.Add(new RData
            {
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 51,
                ProCost = 63
            });
            rData.Add(new RData
            {
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 21,
                ProCost = 45
            });
            rData.Add(new RData
            {
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 102,
                ProCost = 108
            });
            rData.Add(new RData
            {
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 77,
                ProCost = 64
            });
            rData.Add(new RData
            {
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 29,
                ProCost = 26
            });
            rData.Add(new RData
            {
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 140,
                ProCost = 88
            });
            rData.Add(new RData
            {
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 244,
                ProCost = 144
            });
            rData.Add(new RData
            {
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 213,
                ProCost = 127
            });
            rData.Add(new RData
            {
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 69,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 30,
                ProCost = 33
            });
            rData.Add(new RData
            {
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 116,
                ProCost = 103
            });
            rData.Add(new RData
            {
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 79,
                ProCost = 47
            });
            rData.Add(new RData
            {
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 29,
                ProCost = 37
            });
            rData.Add(new RData
            {
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 116,
                ProCost = 96
            });
            rData.Add(new RData
            {
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 295,
                ProCost = 108
            });
            rData.Add(new RData
            {
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 225,
                ProCost = 127
            });
            rData.Add(new RData
            {
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 35,
                ProCost = 57
            });
            rData.Add(new RData
            {
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 37,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 138,
                ProCost = 118
            });
            rData.Add(new RData
            {
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 80,
                ProCost = 47
            });
            rData.Add(new RData
            {
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 22,
                ProCost = 42
            });
            rData.Add(new RData
            {
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 131,
                ProCost = 91
            });
            rData.Add(new RData
            {
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 240,
                ProCost = 115
            });
            rData.Add(new RData
            {
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 275,
                ProCost = 109
            });
            rData.Add(new RData
            {
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 46,
                ProCost = 42
            });
            rData.Add(new RData
            {
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 40,
                ProCost = 43
            });
            rData.Add(new RData
            {
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 112,
                ProCost = 105
            });
            rData.Add(new RData
            {
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 35,
                ProCost = 40
            });
            rData.Add(new RData
            {
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 22,
                ProCost = 31
            });
            rData.Add(new RData
            {
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 119,
                ProCost = 87
            });
            rData.Add(new RData
            {
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 298,
                ProCost = 148
            });
            rData.Add(new RData
            {
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 200,
                ProCost = 107
            });
            rData.Add(new RData
            {
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 30,
                ProCost = 42
            });
            rData.Add(new RData
            {
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 22,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 148,
                ProCost = 88
            });
            rData.Add(new RData
            {
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 37,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 23,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 130,
                ProCost = 102
            });
            rData.Add(new RData
            {
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 281,
                ProCost = 129
            });
            rData.Add(new RData
            {
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 228,
                ProCost = 113
            });
            rData.Add(new RData
            {
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 80,
                ProCost = 60
            });
            rData.Add(new RData
            {
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 39,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 119,
                ProCost = 93
            });
            rData.Add(new RData
            {
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 42,
                ProCost = 46
            });
            rData.Add(new RData
            {
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 18,
                ProCost = 37
            });
            rData.Add(new RData
            {
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 126,
                ProCost = 96
            });
            rData.Add(new RData
            {
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 222,
                ProCost = 150
            });
            rData.Add(new RData
            {
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 228,
                ProCost = 105
            });
            rData.Add(new RData
            {
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 54,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 16,
                ProCost = 33
            });
            rData.Add(new RData
            {
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 145,
                ProCost = 110
            });
            rData.Add(new RData
            {
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 35,
                ProCost = 41
            });
            rData.Add(new RData
            {
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 16,
                ProCost = 38
            });
            rData.Add(new RData
            {
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 118,
                ProCost = 114
            });
            rData.Add(new RData
            {
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 241,
                ProCost = 110
            });
            rData.Add(new RData
            {
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 281,
                ProCost = 136
            });
            rData.Add(new RData
            {
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 50,
                ProCost = 66
            });
            rData.Add(new RData
            {
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 23,
                ProCost = 26
            });
            rData.Add(new RData
            {
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 129,
                ProCost = 98
            });
            rData.Add(new RData
            {
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 78,
                ProCost = 53
            });
            rData.Add(new RData
            {
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 28,
                ProCost = 31
            });
            rData.Add(new RData
            {
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 147,
                ProCost = 120
            });
            rData.Add(new RData
            {
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 240,
                ProCost = 100
            });
            rData.Add(new RData
            {
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 232,
                ProCost = 116
            });
            rData.Add(new RData
            {
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 33,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 18,
                ProCost = 36
            });
            rData.Add(new RData
            {
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 114,
                ProCost = 113
            });
            rData.Add(new RData
            {
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 52,
                ProCost = 63
            });
            rData.Add(new RData
            {
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 31,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 129,
                ProCost = 88
            });
            rData.Add(new RData
            {
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 263,
                ProCost = 111
            });
            rData.Add(new RData
            {
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 241,
                ProCost = 105
            });
            rData.Add(new RData
            {
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 55,
                ProCost = 60
            });
            rData.Add(new RData
            {
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 13,
                ProCost = 30
            });
            rData.Add(new RData
            {
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 134,
                ProCost = 107
            });
            rData.Add(new RData
            {
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Hydro-electric",
                PowUnits = 33,
                ProCost = 69
            });
            rData.Add(new RData
            {
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Geo-thermal",
                PowUnits = 20,
                ProCost = 31
            });
            rData.Add(new RData
            {
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Free Energy",
                EneSource = "Solar",
                PowUnits = 146,
                ProCost = 109
            });
            rData.Add(new RData
            {
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Free Energy",
                EneSource = "Wind",
                PowUnits = 241,
                ProCost = 107
            });
            rData.Add(new RData
            {
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 10,
                ProCost = 30
            });
            rData.Add(new RData
            {
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 38,
                ProCost = 65
            });
            rData.Add(new RData
            {
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 6,
                ProCost = 24
            });
            rData.Add(new RData
            {
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 72,
                ProCost = 86
            });
            rData.Add(new RData
            {
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 13,
                ProCost = 20
            });
            rData.Add(new RData
            {
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 34,
                ProCost = 54
            });
            rData.Add(new RData
            {
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 5,
                ProCost = 20
            });
            rData.Add(new RData
            {
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 12,
                ProCost = 26
            });
            rData.Add(new RData
            {
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 48,
                ProCost = 57
            });
            rData.Add(new RData
            {
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 8,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 61,
                ProCost = 97
            });
            rData.Add(new RData
            {
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 19,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 40,
                ProCost = 47
            });
            rData.Add(new RData
            {
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 7,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 24
            });
            rData.Add(new RData
            {
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 45,
                ProCost = 42
            });
            rData.Add(new RData
            {
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 4,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 72,
                ProCost = 82
            });
            rData.Add(new RData
            {
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 19,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 32,
                ProCost = 42
            });
            rData.Add(new RData
            {
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 5,
                ProCost = 20
            });
            rData.Add(new RData
            {
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 43,
                ProCost = 66
            });
            rData.Add(new RData
            {
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 8,
                ProCost = 26
            });
            rData.Add(new RData
            {
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 86,
                ProCost = 87
            });
            rData.Add(new RData
            {
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 16,
                ProCost = 22
            });
            rData.Add(new RData
            {
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 43,
                ProCost = 54
            });
            rData.Add(new RData
            {
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 6,
                ProCost = 22
            });
            rData.Add(new RData
            {
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 15,
                ProCost = 20
            });
            rData.Add(new RData
            {
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 40,
                ProCost = 55
            });
            rData.Add(new RData
            {
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 3,
                ProCost = 24
            });
            rData.Add(new RData
            {
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 60,
                ProCost = 87
            });
            rData.Add(new RData
            {
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 12,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 37,
                ProCost = 50
            });
            rData.Add(new RData
            {
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 3,
                ProCost = 20
            });
            rData.Add(new RData
            {
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 17,
                ProCost = 21
            });
            rData.Add(new RData
            {
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 38,
                ProCost = 53
            });
            rData.Add(new RData
            {
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 8,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 88,
                ProCost = 92
            });
            rData.Add(new RData
            {
                Date = "2/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 14,
                ProCost = 22
            });
            rData.Add(new RData
            {
                Date = "3/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 31,
                ProCost = 69
            });
            rData.Add(new RData
            {
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 2,
                ProCost = 22
            });
            rData.Add(new RData
            {
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 16,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Date = "7/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 35,
                ProCost = 54
            });
            rData.Add(new RData
            {
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 7,
                ProCost = 24
            });
            rData.Add(new RData
            {
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 79,
                ProCost = 82
            });
            rData.Add(new RData
            {
                Date = "12/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 10,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Date = "1/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 50,
                ProCost = 65
            });
            rData.Add(new RData
            {
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 5,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 17,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Date = "5/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 46,
                ProCost = 54
            });
            rData.Add(new RData
            {
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 7,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 63,
                ProCost = 84
            });
            rData.Add(new RData
            {
                Date = "10/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 19,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Date = "11/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 47,
                ProCost = 52
            });
            rData.Add(new RData
            {
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 8,
                ProCost = 23
            });
            rData.Add(new RData
            {
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Date = "3/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 40,
                ProCost = 55
            });
            rData.Add(new RData
            {
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 7,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 67,
                ProCost = 88
            });
            rData.Add(new RData
            {
                Date = "8/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 20,
                ProCost = 29
            });
            rData.Add(new RData
            {
                Date = "9/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 38,
                ProCost = 61
            });
            rData.Add(new RData
            {
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 7,
                ProCost = 21
            });
            rData.Add(new RData
            {
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 11,
                ProCost = 26
            });
            rData.Add(new RData
            {
                Date = "1/1/2018",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 36,
                ProCost = 60
            });
            rData.Add(new RData
            {
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 2,
                ProCost = 24
            });
            rData.Add(new RData
            {
                Date = "1/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 83,
                ProCost = 90
            });
            rData.Add(new RData
            {
                Date = "4/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 11,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Date = "5/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 49,
                ProCost = 42
            });
            rData.Add(new RData
            {
                Date = "6/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 7,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Date = "8/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 13,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Date = "9/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 30,
                ProCost = 49
            });
            rData.Add(new RData
            {
                Date = "10/1/2015",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 4,
                ProCost = 26
            });
            rData.Add(new RData
            {
                Date = "11/1/2015",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 76,
                ProCost = 87
            });
            rData.Add(new RData
            {
                Date = "2/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 19,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Date = "3/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 45,
                ProCost = 55
            });
            rData.Add(new RData
            {
                Date = "4/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 1,
                ProCost = 23
            });
            rData.Add(new RData
            {
                Date = "6/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 23
            });
            rData.Add(new RData
            {
                Date = "7/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 34,
                ProCost = 51
            });
            rData.Add(new RData
            {
                Date = "8/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 3,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Date = "9/1/2016",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 85,
                ProCost = 80
            });
            rData.Add(new RData
            {
                Date = "12/1/2016",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 20,
                ProCost = 22
            });
            rData.Add(new RData
            {
                Date = "1/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 40,
                ProCost = 51
            });
            rData.Add(new RData
            {
                Date = "2/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 7,
                ProCost = 25
            });
            rData.Add(new RData
            {
                Date = "4/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 15,
                ProCost = 21
            });
            rData.Add(new RData
            {
                Date = "5/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 36,
                ProCost = 41
            });
            rData.Add(new RData
            {
                Date = "6/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 1,
                ProCost = 27
            });
            rData.Add(new RData
            {
                Date = "7/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 79,
                ProCost = 93
            });
            rData.Add(new RData
            {
                Date = "10/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wastage",
                PowUnits = 11,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Date = "11/1/2017",
                Sector = "Public Sector",
                EnerType = "Biomass",
                EneSource = "Ethenol Fuel",
                PowUnits = 41,
                ProCost = 51
            });
            rData.Add(new RData
            {
                Date = "12/1/2017",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Bio-diesel",
                PowUnits = 8,
                ProCost = 28
            });
            rData.Add(new RData
            {
                Date = "2/1/2018",
                Sector = "Private Sector",
                EnerType = "Biomass",
                EneSource = "Wood",
                PowUnits = 20,
                ProCost = 23
            });
            return rData;
        }

        public List<RenewableData> GetrenewableEnergy()
        {
            List<RenewableData> renewableEnergy = renewableEnergyData();
            return renewableEnergy;
        }

        public List<RenewableData> renewableEnergyData()
        {
            List<RenewableData> renewableEnergy = new List<RenewableData>();
            List<RData> data = GetRData();
            for (int ln = 0; ln < data.Count; ln++)
            {
                DateTime date = Convert.ToDateTime(data[ln].Date.ToString());
                int dtYr = date.Year;
                int dtMn = date.Month;
                int dtdv = (dtMn) / 3;
                data[ln].Year = "FY " + dtYr;
                data[ln].Quarter = dtdv <= 1 ? "Q1 " + ("FY " + dtYr) : dtdv <= 2 ? "Q2 " + ("FY " + dtYr) :
                dtdv <= 3 ? "Q3 " + ("FY " + dtYr) : "Q4 " + ("FY " + dtYr);
                data[ln].HalfYear = (dtMn) / 6 <= 1 ? "H1 " + ("FY " + dtYr) : "H2 " + ("FY " + dtYr);
                renewableEnergy.Add(new RenewableData
                {
                    Sector = data[ln].Sector,
                    EnerType = data[ln].EnerType,
                    EneSource = data[ln].EneSource,
                    PowUnits = data[ln].PowUnits,
                    ProCost = data[ln].ProCost,
                    Year = data[ln].Year,
                    Quarter = data[ln].Quarter,
                    HalfYear = data[ln].HalfYear
                });
            }
            return renewableEnergy;
        }

        public List<Pivot_Data> GetPivot_Data()
        {
            List<Pivot_Data> pivot_Data = new List<Pivot_Data>();
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 51, Amount = 383, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 423, Amount = 3595.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 234, Amount = 1813.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 127, Amount = 952.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 89, Amount = 668, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 340, Amount = 2890, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 379, Amount = 2937.25, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 269, Amount = 2017.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 15, Amount = 113, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 369, Amount = 3136.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 410, Amount = 3177.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 99, Amount = 742.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 50, Amount = 375.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 129, Amount = 1096.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 404, Amount = 3131, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 132, Amount = 990, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 56, Amount = 420.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 481, Amount = 4088.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 71, Amount = 550.25, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 455, Amount = 3412.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 25, Amount = 188, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 466, Amount = 3961, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 198, Amount = 1534.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 421, Amount = 3157.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 10, Amount = 75.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 348, Amount = 2958, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 118, Amount = 914.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 207, Amount = 1552.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 45, Amount = 338, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 97, Amount = 824.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 271, Amount = 2100.25, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 501, Amount = 3757.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 63, Amount = 473, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 456, Amount = 3876, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 155, Amount = 1201.25, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 140, Amount = 1050, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 31, Amount = 233, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 402, Amount = 3417, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 254, Amount = 1968.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 314, Amount = 2355, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 91, Amount = 683, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 202, Amount = 1717, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 298, Amount = 2309.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 166, Amount = 1245, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 11, Amount = 83, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 416, Amount = 3536, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 55, Amount = 426.25, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 510, Amount = 3825, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 199, Amount = 1691.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 103, Amount = 798.25, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 227, Amount = 1702.5, Country = "France", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 16, Amount = 72, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 250, Amount = 1250, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 386, Amount = 1640.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 165, Amount = 660, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 83, Amount = 373.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 221, Amount = 1105, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 249, Amount = 1058.25, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 418, Amount = 1672, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 55, Amount = 247.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 415, Amount = 2075, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 57, Amount = 242.25, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 252, Amount = 1008, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 19, Amount = 85.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 64, Amount = 320, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 66, Amount = 280.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 263, Amount = 1052, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 61, Amount = 274.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 257, Amount = 1285, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 386, Amount = 1640.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 503, Amount = 2012, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 43, Amount = 193.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 322, Amount = 1610, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 305, Amount = 1296.25, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 171, Amount = 684, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 22, Amount = 99, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 254, Amount = 1270, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 72, Amount = 306, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 286, Amount = 1144, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 95, Amount = 427.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 271, Amount = 1355, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 67, Amount = 284.75, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 92, Amount = 368, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 86, Amount = 387, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 320, Amount = 1600, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 244, Amount = 1037, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 403, Amount = 1612, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 45, Amount = 202.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 323, Amount = 1615, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 256, Amount = 1088, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 361, Amount = 1444, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 57, Amount = 256.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 269, Amount = 1345, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 448, Amount = 1904, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 376, Amount = 1504, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 15, Amount = 67.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 157, Amount = 785, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 170, Amount = 722.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 542, Amount = 2168, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 96, Amount = 432, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 212, Amount = 1060, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 342, Amount = 1453.5, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 84, Amount = 336, Country = "France", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 42, Amount = 483, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 287, Amount = 3444, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 371, Amount = 4173.75, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 414, Amount = 4554, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 14, Amount = 161, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 81, Amount = 972, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 438, Amount = 4927.5, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 507, Amount = 5577, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 65, Amount = 747.5, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 382, Amount = 4584, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 322, Amount = 3622.5, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 313, Amount = 3443, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 48, Amount = 552, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 345, Amount = 4140, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 77, Amount = 866.25, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 339, Amount = 3729, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 21, Amount = 241.5, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 355, Amount = 4260, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 76, Amount = 855, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 180, Amount = 1980, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 44, Amount = 506, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 453, Amount = 5436, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 410, Amount = 4612.5, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 163, Amount = 1793, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 77, Amount = 885.5, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 489, Amount = 5868, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 265, Amount = 2981.25, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 360, Amount = 3960, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 47, Amount = 540.5, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 201, Amount = 2412, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 383, Amount = 4308.75, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 83, Amount = 913, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 24, Amount = 276, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 141, Amount = 1692, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 332, Amount = 3735, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 253, Amount = 2783, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 31, Amount = 356.5, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 352, Amount = 4224, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 443, Amount = 4983.75, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 185, Amount = 2035, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 17, Amount = 195.5, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 165, Amount = 1980, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 466, Amount = 5242.5, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 512, Amount = 5632, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 42, Amount = 483, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 102, Amount = 1224, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 133, Amount = 1496.25, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 391, Amount = 4301, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 20, Amount = 230, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 145, Amount = 1740, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 398, Amount = 4477.5, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 472, Amount = 5192, Country = "France", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 32, Amount = 504.96, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 258, Amount = 4200.24, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 442, Amount = 6864.26, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 317, Amount = 4843.76, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 32, Amount = 504.96, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 133, Amount = 2165.24, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 117, Amount = 1817.01, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 129, Amount = 1971.12, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 80, Amount = 1262.4, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 139, Amount = 2262.92, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 234, Amount = 3634.02, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 444, Amount = 6784.32, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 60, Amount = 946.8, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 470, Amount = 7651.6, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 448, Amount = 6957.44, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 118, Amount = 1803.04, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 15, Amount = 236.7, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 95, Amount = 1546.6, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 191, Amount = 2966.23, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 426, Amount = 6509.28, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 78, Amount = 1230.84, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 69, Amount = 1123.32, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 221, Amount = 3432.13, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 285, Amount = 4354.8, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 56, Amount = 883.68, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 303, Amount = 4932.84, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 419, Amount = 6507.07, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 397, Amount = 6066.16, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 90, Amount = 1420.2, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 337, Amount = 5486.36, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 74, Amount = 1149.22, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 203, Amount = 3101.84, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 83, Amount = 1309.74, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 152, Amount = 2474.56, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 144, Amount = 2236.32, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 231, Amount = 3529.68, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 47, Amount = 741.66, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 464, Amount = 7553.92, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 460, Amount = 7143.8, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 343, Amount = 5241.04, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 22, Amount = 347.16, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 161, Amount = 2621.08, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 188, Amount = 2919.64, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 233, Amount = 3560.24, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 17, Amount = 268.26, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 121, Amount = 1969.88, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 469, Amount = 7283.57, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 297, Amount = 4538.16, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 30, Amount = 473.4, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 288, Amount = 4688.64, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 155, Amount = 2407.15, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 121, Amount = 1848.88, Country = "France", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 46, Amount = 1414.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 328, Amount = 10250, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 393, Amount = 11986.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 415, Amount = 12553.75, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 63, Amount = 1937.25, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 411, Amount = 12843.75, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 106, Amount = 3233, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 222, Amount = 6715.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 98, Amount = 3013.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 59, Amount = 1843.75, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 355, Amount = 10827.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 76, Amount = 2299, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 38, Amount = 1168.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 189, Amount = 5906.25, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 458, Amount = 13969, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 436, Amount = 13189, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 19, Amount = 584.25, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 444, Amount = 13875, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 186, Amount = 5673, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 225, Amount = 6806.25, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 11, Amount = 338.25, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 61, Amount = 1906.25, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 272, Amount = 8296, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 150, Amount = 4537.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 51, Amount = 1568.25, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 490, Amount = 15312.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 487, Amount = 14853.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 184, Amount = 5566, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 24, Amount = 738, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 101, Amount = 3156.25, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 301, Amount = 9180.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 506, Amount = 15306.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 89, Amount = 2736.75, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 80, Amount = 2500, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 196, Amount = 5978, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 103, Amount = 3115.75, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 35, Amount = 1076.25, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 159, Amount = 4968.75, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 392, Amount = 11956, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 438, Amount = 13249.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 75, Amount = 2306.25, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 383, Amount = 11968.75, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 160, Amount = 4880, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 378, Amount = 11434.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 18, Amount = 553.5, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 140, Amount = 4375, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 258, Amount = 7869, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 508, Amount = 15367, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 59, Amount = 1814.25, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 83, Amount = 2593.75, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 414, Amount = 12627, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 341, Amount = 10315.25, Country = "France", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 48, Amount = 936, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 174, Amount = 3480, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 202, Amount = 3888.5, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 469, Amount = 8911, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 53, Amount = 1033.5, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 74, Amount = 1480, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 467, Amount = 8989.75, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 322, Amount = 6118, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 53, Amount = 1033.5, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 468, Amount = 9360, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 277, Amount = 5332.25, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 236, Amount = 4484, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 49, Amount = 955.5, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 191, Amount = 3820, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 165, Amount = 3176.25, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 185, Amount = 3515, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 92, Amount = 1794, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 128, Amount = 2560, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 258, Amount = 4966.5, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 274, Amount = 5206, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 58, Amount = 1131, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 322, Amount = 6440, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 168, Amount = 3234, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 120, Amount = 2280, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 18, Amount = 351, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 142, Amount = 2840, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 133, Amount = 2560.25, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 377, Amount = 7163, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 56, Amount = 1092, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 318, Amount = 6360, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 456, Amount = 8778, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 408, Amount = 7752, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 34, Amount = 663, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 226, Amount = 4520, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 355, Amount = 6833.75, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 237, Amount = 4503, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 94, Amount = 1833, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 273, Amount = 5460, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 280, Amount = 5390, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 146, Amount = 2774, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 37, Amount = 721.5, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 219, Amount = 4380, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 497, Amount = 9567.25, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 378, Amount = 7182, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 83, Amount = 1618.5, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 211, Amount = 4220, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 372, Amount = 7161, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 537, Amount = 10203, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 58, Amount = 1131, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 155, Amount = 3100, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 211, Amount = 4061.75, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 134, Amount = 2546, Country = "France", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 58, Amount = 98832, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 474, Amount = 810066, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 447, Amount = 762582, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 289, Amount = 491011, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 60, Amount = 102240, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 93, Amount = 158937, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 96, Amount = 163776, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 401, Amount = 681299, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 83, Amount = 141432, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 427, Amount = 729743, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 396, Amount = 675576, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 98, Amount = 166502, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 48, Amount = 81792, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 288, Amount = 492192, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 352, Amount = 600512, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 426, Amount = 723774, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 85, Amount = 144840, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 432, Amount = 738288, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 267, Amount = 455502, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 434, Amount = 737366, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 39, Amount = 66456, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 171, Amount = 292239, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 304, Amount = 518624, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 441, Amount = 749259, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 68, Amount = 115872, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 406, Amount = 693854, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 50, Amount = 85300, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 231, Amount = 392469, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 31, Amount = 52824, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 254, Amount = 434086, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 455, Amount = 776230, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 304, Amount = 516496, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 40, Amount = 68160, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 204, Amount = 348636, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 231, Amount = 394086, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 531, Amount = 902169, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 45, Amount = 76680, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 275, Amount = 469975, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 292, Amount = 498152, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 197, Amount = 334703, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 35, Amount = 59640, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 234, Amount = 399906, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 127, Amount = 216662, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 377, Amount = 640523, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 40, Amount = 68160, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 474, Amount = 810066, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 168, Amount = 286608, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 521, Amount = 885179, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 55, Amount = 93720, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 309, Amount = 528081, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 466, Amount = 794996, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 296, Amount = 502904, Country = "France", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 76, Amount = 113929, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 202, Amount = 304818, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 285, Amount = 429210, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 345, Amount = 571119, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 61, Amount = 91444, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 94, Amount = 141846, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 241, Amount = 362946, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 186, Amount = 795969, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 79, Amount = 118426, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 341, Amount = 514569, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 401, Amount = 603906, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 204, Amount = 517155, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 71, Amount = 106434, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 368, Amount = 555312, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 500, Amount = 753000, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 275, Amount = 278814, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 41, Amount = 61464, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 172, Amount = 259548, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 432, Amount = 650592, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 241, Amount = 305796, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 40, Amount = 59965, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 350, Amount = 528150, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 468, Amount = 704808, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 250, Amount = 412225, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 98, Amount = 146907, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 228, Amount = 344052, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 407, Amount = 612942, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 217, Amount = 361259, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 63, Amount = 94442, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 303, Amount = 457227, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 364, Amount = 548184, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 191, Amount = 374750, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 47, Amount = 70458, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 325, Amount = 490425, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 469, Amount = 706314, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 183, Amount = 325283, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 84, Amount = 125921, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 374, Amount = 564366, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 314, Amount = 472884, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 427, Amount = 286309, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 81, Amount = 121424, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 80, Amount = 120720, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 314, Amount = 472884, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 495, Amount = 274317, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 83, Amount = 124422, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 380, Amount = 573420, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 157, Amount = 236442, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 450, Amount = 640073, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 10, Amount = 14995, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 330, Amount = 497970, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 324, Amount = 487944, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 346, Amount = 742005, Country = "France", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 83, Amount = 132426.5, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 51, Amount = 81396, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 483, Amount = 770505.75, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 233, Amount = 371635, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 46, Amount = 73393, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 306, Amount = 488376, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 124, Amount = 197811, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 409, Amount = 652355, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 66, Amount = 105303, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 172, Amount = 274512, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 193, Amount = 307883.25, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 510, Amount = 813450, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 56, Amount = 89348, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 61, Amount = 97356, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 51, Amount = 81357.75, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 360, Amount = 574200, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 51, Amount = 81370.5, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 176, Amount = 280896, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 372, Amount = 593433, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 473, Amount = 754435, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 85, Amount = 135617.5, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 457, Amount = 729372, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 305, Amount = 486551.25, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 513, Amount = 818235, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 89, Amount = 141999.5, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 87, Amount = 138852, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 378, Amount = 603004.5, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 65, Amount = 103675, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 84, Amount = 134022, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 118, Amount = 188328, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 242, Amount = 386050.5, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 396, Amount = 631620, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 85, Amount = 135617.5, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 98, Amount = 156408, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 251, Amount = 400407.75, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 144, Amount = 229680, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 85, Amount = 135617.5, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 465, Amount = 742140, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 421, Amount = 671600.25, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 355, Amount = 566225, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 17, Amount = 27123.5, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 125, Amount = 199500, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 256, Amount = 408384, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 126, Amount = 200970, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 77, Amount = 122853.5, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 139, Amount = 221844, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 371, Amount = 591837.75, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 353, Amount = 563035, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 80, Amount = 127640, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 168, Amount = 268128, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 492, Amount = 784863, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 320, Amount = 510400, Country = "France", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 54, Amount = 324.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 107, Amount = 856, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 86, Amount = 537.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 332, Amount = 1992, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 75, Amount = 450.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 155, Amount = 1240, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 479, Amount = 2993.75, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 227, Amount = 1362, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 52, Amount = 312.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 107, Amount = 856, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 457, Amount = 2856.25, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 122, Amount = 732, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 28, Amount = 168.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 490, Amount = 3920, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 464, Amount = 2900, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 329, Amount = 1974, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 81, Amount = 486.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 94, Amount = 752, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 230, Amount = 1437.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 404, Amount = 2424, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 27, Amount = 162.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 106, Amount = 848, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 358, Amount = 2237.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 140, Amount = 840, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 48, Amount = 288.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 155, Amount = 1240, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 176, Amount = 1100, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 501, Amount = 3006, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 14, Amount = 84.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 98, Amount = 784, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 280, Amount = 1750, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 285, Amount = 1710, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 67, Amount = 402.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 103, Amount = 824, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 247, Amount = 1543.75, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 153, Amount = 918, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 49, Amount = 294.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 348, Amount = 2784, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 461, Amount = 2881.25, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 536, Amount = 3216, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 83, Amount = 498.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 68, Amount = 544, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 390, Amount = 2437.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 154, Amount = 924, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 38, Amount = 228.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 413, Amount = 3304, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 380, Amount = 2375, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 226, Amount = 1356, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 65, Amount = 390.5, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 176, Amount = 1408, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 217, Amount = 1356.25, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 318, Amount = 1908, Country = "France", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 21, Amount = 598.5, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 68, Amount = 1972, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 277, Amount = 7825.25, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 191, Amount = 5348, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 63, Amount = 1795.5, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 84, Amount = 2436, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 226, Amount = 6384.5, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 143, Amount = 4004, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 78, Amount = 2223, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 391, Amount = 11339, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 216, Amount = 6102, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 269, Amount = 7532, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 27, Amount = 769.5, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 495, Amount = 14355, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 499, Amount = 14096.75, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 135, Amount = 3780, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 32, Amount = 912, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 328, Amount = 9512, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 230, Amount = 6497.5, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 101, Amount = 2828, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 78, Amount = 2223, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 76, Amount = 2204, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 264, Amount = 7458, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 508, Amount = 14224, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 29, Amount = 826.5, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 274, Amount = 7946, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 357, Amount = 10085.25, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 268, Amount = 7504, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 87, Amount = 2479.5, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 288, Amount = 8352, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 109, Amount = 3079.25, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 434, Amount = 12152, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 13, Amount = 370.5, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 292, Amount = 8468, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 439, Amount = 12401.75, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 449, Amount = 12572, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 68, Amount = 1938, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 274, Amount = 7946, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 394, Amount = 11130.5, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 382, Amount = 10696, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 36, Amount = 1026, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 120, Amount = 3480, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 277, Amount = 7825.25, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 439, Amount = 12292, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 50, Amount = 1425, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 258, Amount = 7482, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 269, Amount = 7599.25, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 427, Amount = 11956, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 61, Amount = 1738.5, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 192, Amount = 5568, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 431, Amount = 12175.75, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 506, Amount = 14168, Country = "France", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 79, Amount = 1698.5, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 476, Amount = 8092, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 483, Amount = 7848.75, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 541, Amount = 8656, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 21, Amount = 451.5, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 251, Amount = 4267, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 484, Amount = 7865, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 467, Amount = 7472, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 75, Amount = 1612.5, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 121, Amount = 2057, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 456, Amount = 7410, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 193, Amount = 3088, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 34, Amount = 731, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 416, Amount = 7072, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 280, Amount = 4550, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 363, Amount = 5808, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 92, Amount = 1978, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 187, Amount = 3179, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 226, Amount = 3672.5, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 243, Amount = 3888, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 75, Amount = 1612.5, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 117, Amount = 1989, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 326, Amount = 5297.5, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 440, Amount = 7040, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 93, Amount = 1999.5, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 123, Amount = 2091, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 52, Amount = 845, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 91, Amount = 1456, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 14, Amount = 301, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 458, Amount = 7786, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 120, Amount = 1950, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 295, Amount = 4720, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 60, Amount = 1290, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 101, Amount = 1717, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 380, Amount = 6175, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 266, Amount = 4256, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 21, Amount = 451.5, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 296, Amount = 5032, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 355, Amount = 5768.75, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 286, Amount = 4576, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 58, Amount = 1247, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 343, Amount = 5831, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 229, Amount = 3721.25, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 146, Amount = 2336, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 19, Amount = 408.5, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 395, Amount = 6715, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 224, Amount = 3640, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 298, Amount = 4768, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 100, Amount = 2150, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 362, Amount = 6154, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 84, Amount = 1365, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 244, Amount = 3904, Country = "France", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 47, Amount = 5217.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 416, Amount = 46592, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 459, Amount = 51063.75, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 206, Amount = 6660, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 58, Amount = 6438.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 317, Amount = 35504, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 103, Amount = 11458.75, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 151, Amount = 4440, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 69, Amount = 7659.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 326, Amount = 36512, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 391, Amount = 43498.75, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 104, Amount = 5217, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 36, Amount = 3996.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 479, Amount = 53648, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 77, Amount = 8566.25, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 121, Amount = 6438, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 33, Amount = 3663.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 407, Amount = 45584, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 155, Amount = 17243.75, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 171, Amount = 7659, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 13, Amount = 1443.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 62, Amount = 6944, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 319, Amount = 35488.75, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 141, Amount = 3996, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 44, Amount = 4884.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 94, Amount = 10528, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 304, Amount = 33820, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 368, Amount = 3663, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 21, Amount = 2331.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 120, Amount = 13440, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 67, Amount = 7453.75, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 371, Amount = 1443, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 49, Amount = 5439.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 153, Amount = 17136, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 127, Amount = 14128.75, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 99, Amount = 4884, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 14, Amount = 1554.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 411, Amount = 46032, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 434, Amount = 48282.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 251, Amount = 2331, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 42, Amount = 4662.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 495, Amount = 55440, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 77, Amount = 8566.25, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 208, Amount = 5439, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 22, Amount = 2442.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 410, Amount = 45920, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 242, Amount = 26922.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 323, Amount = 1554, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 42, Amount = 4662.5, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 483, Amount = 54096, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 159, Amount = 17688.75, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 533, Amount = 4662, Country = "France", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 80, Amount = 2460, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 16, Amount = 184, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 25, Amount = 188, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 51, Amount = 229.5, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 83, Amount = 1309.74, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 29, Amount = 565.5, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 84, Amount = 125921, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 26, Amount = 41483, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 54, Amount = 92016, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 76, Amount = 456.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 34, Amount = 969, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 72, Amount = 1548, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 44, Amount = 4884.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 76, Amount = 2375, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 300, Amount = 3600, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 148, Amount = 1258, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 392, Amount = 1960, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 76, Amount = 1237.28, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 141, Amount = 2820, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 371, Amount = 559839, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 220, Amount = 351120, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 317, Amount = 541753, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 416, Amount = 3328, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 346, Amount = 10034, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 172, Amount = 2924, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 205, Amount = 22960, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 291, Amount = 8875.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 374, Amount = 4207.5, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 63, Amount = 488.25, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 314, Amount = 1334.5, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 69, Amount = 1071.57, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 487, Amount = 9374.75, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 89, Amount = 134034, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 69, Amount = 110072.25, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 212, Amount = 361672, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 239, Amount = 1493.75, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 72, Amount = 2034, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 149, Amount = 2421.25, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 180, Amount = 20025, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 397, Amount = 12009.25, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 285, Amount = 3135, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 481, Amount = 3607.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 347, Amount = 1388, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 263, Amount = 4018.64, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 514, Amount = 9766, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 370, Amount = 223351, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 251, Amount = 400345, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 311, Amount = 528389, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 179, Amount = 1074, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 452, Amount = 12656, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 400, Amount = 6400, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 456, Amount = 31635, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 60, Amount = 1845, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 38, Amount = 437, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 78, Amount = 585.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 24, Amount = 108, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 82, Amount = 1293.96, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 16, Amount = 312, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 98, Amount = 146907, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 61, Amount = 97325.5, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 38, Amount = 64752, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 59, Amount = 354.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 16, Amount = 456, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 67, Amount = 1440.5, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 28, Amount = 3108.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 468, Amount = 14625, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 132, Amount = 1584, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 353, Amount = 3000.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 269, Amount = 1345, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 232, Amount = 3776.96, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 252, Amount = 5040, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 249, Amount = 375741, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 298, Amount = 475608, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 216, Amount = 369144, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 50, Amount = 400, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 433, Amount = 12557, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 53, Amount = 901, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 320, Amount = 35840, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 479, Amount = 14609.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 286, Amount = 3217.5, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 398, Amount = 3084.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 328, Amount = 1394, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 379, Amount = 5885.87, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 460, Amount = 8855, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 148, Amount = 222888, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 62, Amount = 98905.5, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 87, Amount = 148422, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 400, Amount = 2500, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 277, Amount = 7825.25, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 137, Amount = 2226.25, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 221, Amount = 24586.25, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 302, Amount = 9135.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 77, Amount = 847, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 131, Amount = 982.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 425, Amount = 1700, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 99, Amount = 1512.72, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 73, Amount = 1387, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 279, Amount = 205363, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 337, Amount = 537515, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 399, Amount = 677901, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 381, Amount = 2286, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 460, Amount = 12880, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 119, Amount = 1904, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 234, Amount = 8547, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 87, Amount = 2675.25, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 85, Amount = 977.5, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 83, Amount = 623, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 24, Amount = 108, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 27, Amount = 426.06, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 52, Amount = 1014, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 60, Amount = 89945, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 32, Amount = 51056, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 12, Amount = 20448, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 52, Amount = 312.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 96, Amount = 2736, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 74, Amount = 1591, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 61, Amount = 6771.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 487, Amount = 15218.75, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 307, Amount = 3684, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 202, Amount = 1717, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 212, Amount = 1060, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 264, Amount = 4297.92, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 451, Amount = 9020, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 293, Amount = 442137, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 422, Amount = 673512, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 205, Amount = 350345, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 122, Amount = 976, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 121, Amount = 3509, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 103, Amount = 1751, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 332, Amount = 37184, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 464, Amount = 14152, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 82, Amount = 922.5, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 188, Amount = 1457, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 182, Amount = 773.5, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 398, Amount = 6180.94, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 173, Amount = 3330.25, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 118, Amount = 177708, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 122, Amount = 194620.5, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 458, Amount = 781348, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 139, Amount = 868.75, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 415, Amount = 11723.75, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 297, Amount = 4826.25, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 298, Amount = 33152.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 183, Amount = 5535.75, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 174, Amount = 1914, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 217, Amount = 1627.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 175, Amount = 700, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 496, Amount = 7578.88, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 236, Amount = 4484, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 211, Amount = 445203, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 351, Amount = 559845, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 115, Amount = 195385, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 70, Amount = 420, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 539, Amount = 15092, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 262, Amount = 4192, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 472, Amount = 19314, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 59, Amount = 443, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 371, Amount = 3153.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 277, Amount = 2146.75, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 503, Amount = 3772.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 27, Amount = 203, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 455, Amount = 3867.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 195, Amount = 1511.25, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 216, Amount = 1620, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 17, Amount = 128, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 201, Amount = 1708.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 73, Amount = 565.75, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 183, Amount = 1372.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 23, Amount = 173, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 143, Amount = 1215.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 380, Amount = 2945, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 289, Amount = 2167.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 88, Amount = 660.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 365, Amount = 3102.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 307, Amount = 2379.25, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 109, Amount = 817.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 83, Amount = 623, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 70, Amount = 595, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 471, Amount = 3650.25, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 493, Amount = 3697.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 66, Amount = 495.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 54, Amount = 459, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 493, Amount = 3820.75, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 519, Amount = 3892.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 90, Amount = 675.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 121, Amount = 1028.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 175, Amount = 1356.25, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 116, Amount = 870, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 55, Amount = 413, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 369, Amount = 3136.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 500, Amount = 3875, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 85, Amount = 637.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 67, Amount = 503, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 66, Amount = 561, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 444, Amount = 3441, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 429, Amount = 3217.5, Country = "Germany", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 58, Amount = 261, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 134, Amount = 670, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 312, Amount = 1326, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 428, Amount = 1712, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 12, Amount = 54, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 372, Amount = 1860, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 265, Amount = 1126.25, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 343, Amount = 1372, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 59, Amount = 265.5, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 474, Amount = 2370, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 400, Amount = 1700, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 394, Amount = 1576, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 80, Amount = 360, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 152, Amount = 760, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 185, Amount = 786.25, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 105, Amount = 420, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 80, Amount = 360, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 171, Amount = 855, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 326, Amount = 1385.5, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 429, Amount = 1716, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 96, Amount = 432, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 78, Amount = 390, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 211, Amount = 896.75, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 530, Amount = 2120, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 21, Amount = 94.5, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 334, Amount = 1670, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 229, Amount = 973.25, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 228, Amount = 912, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 13, Amount = 58.5, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 225, Amount = 1125, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 246, Amount = 1045.5, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 292, Amount = 1168, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 62, Amount = 279, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 141, Amount = 705, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 389, Amount = 1653.25, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 438, Amount = 1752, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 37, Amount = 166.5, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 431, Amount = 2155, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 116, Amount = 493, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 512, Amount = 2048, Country = "Germany", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 74, Amount = 851, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 338, Amount = 4056, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 492, Amount = 5535, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 332, Amount = 3652, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 68, Amount = 782, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 96, Amount = 1152, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 302, Amount = 3397.5, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 93, Amount = 1023, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 98, Amount = 1127, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 295, Amount = 3540, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 94, Amount = 1057.5, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 201, Amount = 2211, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 97, Amount = 1115.5, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 117, Amount = 1404, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 145, Amount = 1631.25, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 525, Amount = 5775, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 34, Amount = 391, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 248, Amount = 2976, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 72, Amount = 810, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 452, Amount = 4972, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 82, Amount = 943, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 297, Amount = 3564, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 140, Amount = 1575, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 447, Amount = 4917, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 56, Amount = 644, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 218, Amount = 2616, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 304, Amount = 3420, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 132, Amount = 1452, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 29, Amount = 333.5, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 236, Amount = 2832, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 102, Amount = 1147.5, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 357, Amount = 3927, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 20, Amount = 230, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 299, Amount = 3588, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 372, Amount = 4185, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 190, Amount = 2090, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 93, Amount = 1069.5, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 394, Amount = 4728, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 452, Amount = 5085, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 347, Amount = 3817, Country = "Germany", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 50, Amount = 789, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 140, Amount = 2279.2, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 338, Amount = 5249.14, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 205, Amount = 3132.4, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 77, Amount = 1215.06, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 377, Amount = 6137.56, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 442, Amount = 6864.26, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 246, Amount = 3758.88, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 59, Amount = 931.02, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 430, Amount = 7000.4, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 420, Amount = 6522.6, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 232, Amount = 3544.96, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 17, Amount = 268.26, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 323, Amount = 5258.44, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 329, Amount = 5109.37, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 528, Amount = 8067.84, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 61, Amount = 962.58, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 413, Amount = 6723.64, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 494, Amount = 7671.82, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 456, Amount = 6967.68, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 39, Amount = 615.42, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 255, Amount = 4151.4, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 349, Amount = 5419.97, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 175, Amount = 2674, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 56, Amount = 883.68, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 188, Amount = 3060.64, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 179, Amount = 2779.87, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 247, Amount = 3774.16, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 81, Amount = 1278.18, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 126, Amount = 2051.28, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 500, Amount = 7765, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 495, Amount = 7563.6, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 67, Amount = 1057.26, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 116, Amount = 1888.48, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 127, Amount = 1972.31, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 416, Amount = 6356.48, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 85, Amount = 1341.3, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 301, Amount = 4900.28, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 360, Amount = 5590.8, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 298, Amount = 4553.44, Country = "Germany", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 77, Amount = 2367.75, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 89, Amount = 2781.25, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 179, Amount = 5459.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 344, Amount = 10406, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 94, Amount = 2890.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 481, Amount = 15031.25, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 57, Amount = 1738.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 463, Amount = 14005.75, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 17, Amount = 522.75, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 404, Amount = 12625, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 402, Amount = 12261, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 531, Amount = 16062.75, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 74, Amount = 2275.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 210, Amount = 6562.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 450, Amount = 13725, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 432, Amount = 13068, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 29, Amount = 891.75, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 224, Amount = 7000, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 63, Amount = 1921.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 258, Amount = 7804.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 22, Amount = 676.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 61, Amount = 1906.25, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 227, Amount = 6923.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 263, Amount = 7955.75, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 47, Amount = 1445.25, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 341, Amount = 10656.25, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 144, Amount = 4392, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 374, Amount = 11313.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 73, Amount = 2244.75, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 496, Amount = 15500, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 416, Amount = 12688, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 415, Amount = 12553.75, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 48, Amount = 1476, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 500, Amount = 15625, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 364, Amount = 11102, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 310, Amount = 9377.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 37, Amount = 1137.75, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 426, Amount = 13312.5, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 258, Amount = 7869, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 344, Amount = 10406, Country = "Germany", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 86, Amount = 1677, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 318, Amount = 6360, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 97, Amount = 1867.25, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 264, Amount = 5016, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 12, Amount = 234, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 479, Amount = 9580, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 478, Amount = 9201.5, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 382, Amount = 7258, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 29, Amount = 565.5, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 85, Amount = 1700, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 480, Amount = 9240, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 142, Amount = 2698, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 98, Amount = 1911, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 155, Amount = 3100, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 432, Amount = 8316, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 482, Amount = 9158, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 14, Amount = 273, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 442, Amount = 8840, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 95, Amount = 1828.75, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 191, Amount = 3629, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 51, Amount = 994.5, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 403, Amount = 8060, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 152, Amount = 2926, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 399, Amount = 7581, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 14, Amount = 273, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 183, Amount = 3660, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 124, Amount = 2387, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 125, Amount = 2375, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 77, Amount = 1501.5, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 313, Amount = 6260, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 115, Amount = 2213.75, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 254, Amount = 4826, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 100, Amount = 1950, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 387, Amount = 7740, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 455, Amount = 8758.75, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 377, Amount = 7163, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 21, Amount = 409.5, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 292, Amount = 5840, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 142, Amount = 2733.5, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 326, Amount = 6194, Country = "Germany", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 60, Amount = 102240, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 127, Amount = 217043, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 419, Amount = 714814, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 264, Amount = 448536, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 28, Amount = 47712, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 179, Amount = 305911, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 407, Amount = 694342, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 298, Amount = 506302, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 86, Amount = 146544, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 318, Amount = 543462, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 134, Amount = 228604, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 322, Amount = 547078, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 76, Amount = 129504, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 177, Amount = 302493, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 216, Amount = 368496, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 172, Amount = 292228, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 16, Amount = 27264, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 471, Amount = 804939, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 468, Amount = 798408, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 516, Amount = 876684, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 70, Amount = 119280, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 383, Amount = 654547, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 152, Amount = 259312, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 381, Amount = 647319, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 46, Amount = 78384, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 76, Amount = 129884, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 190, Amount = 324140, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 481, Amount = 817219, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 41, Amount = 69864, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 361, Amount = 616949, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 60, Amount = 102360, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 171, Amount = 290529, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 23, Amount = 39192, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 305, Amount = 521245, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 475, Amount = 810350, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 519, Amount = 881781, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 70, Amount = 119280, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 346, Amount = 591314, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 252, Amount = 429912, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 524, Amount = 890276, Country = "Germany", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 56, Amount = 83949, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 165, Amount = 248985, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 409, Amount = 615954, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 456, Amount = 777981, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 36, Amount = 53969, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 329, Amount = 496461, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 108, Amount = 162648, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 434, Amount = 683544, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 41, Amount = 61464, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 148, Amount = 223332, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 54, Amount = 81324, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 313, Amount = 739007, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 24, Amount = 35981, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 304, Amount = 458736, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 346, Amount = 521076, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 503, Amount = 650566, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 63, Amount = 94442, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 136, Amount = 205224, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 300, Amount = 451800, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 504, Amount = 753997, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 92, Amount = 137913, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 448, Amount = 676032, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 367, Amount = 552702, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 288, Amount = 469187, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 28, Amount = 41977, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 409, Amount = 617181, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 204, Amount = 307224, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 475, Amount = 755496, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 53, Amount = 79452, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 365, Amount = 550785, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 100, Amount = 150600, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 97, Amount = 712025, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 57, Amount = 85448, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 267, Amount = 402903, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 248, Amount = 373488, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 454, Amount = 496169, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 42, Amount = 62963, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 64, Amount = 96576, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 302, Amount = 454812, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 133, Amount = 145403, Country = "Germany", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 36, Amount = 57438, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 240, Amount = 383040, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 314, Amount = 500908.5, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 442, Amount = 704990, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 14, Amount = 22337, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 204, Amount = 325584, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 179, Amount = 285549.75, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 179, Amount = 285505, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 76, Amount = 121258, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 269, Amount = 429324, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 340, Amount = 542385, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 435, Amount = 693825, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 15, Amount = 23932.5, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 98, Amount = 156408, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 355, Amount = 566313.75, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 439, Amount = 700205, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 42, Amount = 67011, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 228, Amount = 363888, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 123, Amount = 196215.75, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 75, Amount = 119625, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 11, Amount = 17550.5, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 154, Amount = 245784, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 145, Amount = 231311.25, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 461, Amount = 735295, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 35, Amount = 55842.5, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 285, Amount = 454860, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 493, Amount = 786458.25, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 444, Amount = 708180, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 10, Amount = 15955, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 376, Amount = 600096, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 278, Amount = 443479.5, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 245, Amount = 390775, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 64, Amount = 102112, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 301, Amount = 480396, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 61, Amount = 97310.25, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 294, Amount = 468930, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 69, Amount = 110089.5, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 216, Amount = 344736, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 326, Amount = 520051.5, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 368, Amount = 586960, Country = "Germany", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 42, Amount = 252.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 298, Amount = 2384, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 203, Amount = 1268.75, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 358, Amount = 2148, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 89, Amount = 534.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 110, Amount = 880, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 467, Amount = 2918.75, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 259, Amount = 1554, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 21, Amount = 126.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 368, Amount = 2944, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 56, Amount = 350, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 400, Amount = 2400, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 82, Amount = 492.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 347, Amount = 2776, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 278, Amount = 1737.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 196, Amount = 1176, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 15, Amount = 90.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 460, Amount = 3680, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 92, Amount = 575, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 261, Amount = 1566, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 25, Amount = 150.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 465, Amount = 3720, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 166, Amount = 1037.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 340, Amount = 2040, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 53, Amount = 318.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 365, Amount = 2920, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 192, Amount = 1200, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 125, Amount = 750, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 43, Amount = 258.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 196, Amount = 1568, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 221, Amount = 1381.25, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 177, Amount = 1062, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 11, Amount = 66.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 324, Amount = 2592, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 269, Amount = 1681.25, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 88, Amount = 528, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 93, Amount = 558.5, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 275, Amount = 2200, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 84, Amount = 525, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 361, Amount = 2166, Country = "Germany", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 10, Amount = 285, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 255, Amount = 7395, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 87, Amount = 2457.75, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 118, Amount = 3304, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 59, Amount = 1681.5, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 433, Amount = 12557, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 93, Amount = 2627.25, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 182, Amount = 5096, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 75, Amount = 2137.5, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 477, Amount = 13833, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 449, Amount = 12684.25, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 125, Amount = 3500, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 87, Amount = 2479.5, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 376, Amount = 10904, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 382, Amount = 10791.5, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 110, Amount = 3080, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 25, Amount = 712.5, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 50, Amount = 1450, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 277, Amount = 7825.25, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 143, Amount = 4004, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 54, Amount = 1539, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 325, Amount = 9425, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 379, Amount = 10706.75, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 222, Amount = 6216, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 33, Amount = 940.5, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 114, Amount = 3306, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 438, Amount = 12373.5, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 460, Amount = 12880, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 22, Amount = 627, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 137, Amount = 3973, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 268, Amount = 7571, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 203, Amount = 5684, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 27, Amount = 769.5, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 176, Amount = 5104, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 233, Amount = 6582.25, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 474, Amount = 13272, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 48, Amount = 1368, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 358, Amount = 10382, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 364, Amount = 10283, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 312, Amount = 8736, Country = "Germany", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 82, Amount = 1763, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 251, Amount = 4267, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 130, Amount = 2112.5, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 248, Amount = 3968, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 74, Amount = 1591, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 64, Amount = 1088, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 53, Amount = 861.25, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 81, Amount = 1296, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 20, Amount = 430, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 62, Amount = 1054, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 437, Amount = 7101.25, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 410, Amount = 6560, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 79, Amount = 1698.5, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 362, Amount = 6154, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 51, Amount = 828.75, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 527, Amount = 8432, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 50, Amount = 1075, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 121, Amount = 2057, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 308, Amount = 5005, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 225, Amount = 3600, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 79, Amount = 1698.5, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 119, Amount = 2023, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 207, Amount = 3363.75, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 321, Amount = 5136, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 16, Amount = 344, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 414, Amount = 7038, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 237, Amount = 3851.25, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 457, Amount = 7312, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 40, Amount = 860, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 75, Amount = 1275, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 423, Amount = 6873.75, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 73, Amount = 1168, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 17, Amount = 365.5, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 226, Amount = 3842, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 114, Amount = 1852.5, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 487, Amount = 7792, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 73, Amount = 1569.5, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 397, Amount = 6749, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 261, Amount = 4241.25, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 288, Amount = 4608, Country = "Germany", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 17, Amount = 1887.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 439, Amount = 49168, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 247, Amount = 27478.75, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 81, Amount = 1887, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 26, Amount = 2886.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 453, Amount = 50736, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 177, Amount = 19691.25, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 294, Amount = 1887, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 28, Amount = 3108.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 53, Amount = 5936, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 468, Amount = 52065, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 407, Amount = 2886, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 81, Amount = 8991.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 414, Amount = 46368, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 235, Amount = 26143.75, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 144, Amount = 2886, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 99, Amount = 10989.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 489, Amount = 54768, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 225, Amount = 25031.25, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 363, Amount = 8991, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 19, Amount = 2109.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 142, Amount = 15904, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 166, Amount = 18467.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 81, Amount = 1221, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 24, Amount = 2664.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 385, Amount = 43120, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 277, Amount = 30816.25, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 223, Amount = 10989, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 10, Amount = 1110.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 91, Amount = 10192, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 278, Amount = 30927.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 364, Amount = 2664, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 28, Amount = 3108.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 315, Amount = 35280, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 298, Amount = 33152.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 514, Amount = 9879, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 55, Amount = 6105.5, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 90, Amount = 10080, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 281, Amount = 31261.25, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 337, Amount = 1110, Country = "Germany", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 15, Amount = 1665.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 332, Amount = 37184, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 121, Amount = 13461.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 531, Amount = 5883, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 24, Amount = 2664.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 67, Amount = 7504, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 163, Amount = 18133.75, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 77, Amount = 9768, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 73, Amount = 8103.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 169, Amount = 18928, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 450, Amount = 50062.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 355, Amount = 1665, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 13, Amount = 1443.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 421, Amount = 47152, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 400, Amount = 44500, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 80, Amount = 2664, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 47, Amount = 5217.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 355, Amount = 39760, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 152, Amount = 16910, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 175, Amount = 8103, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 64, Amount = 7104.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 56, Amount = 6272, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 146, Amount = 16242.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 329, Amount = 1443, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 18, Amount = 1998.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 257, Amount = 28784, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 476, Amount = 52955, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 167, Amount = 5217, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 64, Amount = 7104.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 444, Amount = 49728, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 272, Amount = 30260, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 519, Amount = 7104, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 43, Amount = 4773.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 317, Amount = 35504, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 485, Amount = 53956.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 142, Amount = 1998, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 81, Amount = 8991.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 335, Amount = 37520, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 277, Amount = 30816.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 411, Amount = 7104, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 100, Amount = 11100.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 324, Amount = 36288, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 265, Amount = 29481.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 281, Amount = 4773, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 78, Amount = 8658.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 295, Amount = 33040, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 288, Amount = 32040, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 83, Amount = 8991, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 58, Amount = 6438.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 311, Amount = 34832, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 317, Amount = 35266.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 192, Amount = 11100, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 38, Amount = 817, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 488, Amount = 8296, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 199, Amount = 3233.75, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 404, Amount = 6464, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 60, Amount = 1290, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 394, Amount = 6698, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 249, Amount = 4046.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 308, Amount = 4928, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 78, Amount = 1677, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 393, Amount = 6681, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 373, Amount = 6061.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 120, Amount = 1920, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 92, Amount = 1978, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 229, Amount = 3893, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 460, Amount = 7475, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 299, Amount = 4784, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 12, Amount = 258, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 199, Amount = 3383, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 61, Amount = 991.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 271, Amount = 4336, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 55, Amount = 1182.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 270, Amount = 4590, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 62, Amount = 1007.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 529, Amount = 8464, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 23, Amount = 494.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 487, Amount = 8279, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 385, Amount = 6256.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 191, Amount = 3056, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 51, Amount = 1096.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 286, Amount = 4862, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 350, Amount = 5687.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 453, Amount = 7248, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 73, Amount = 1569.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 251, Amount = 4267, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 405, Amount = 6581.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 152, Amount = 2432, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 100, Amount = 2150, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 236, Amount = 4012, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 238, Amount = 3867.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 170, Amount = 2720, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 52, Amount = 1118, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 327, Amount = 5559, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 220, Amount = 3575, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 211, Amount = 3376, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 14, Amount = 301, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 300, Amount = 5100, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 455, Amount = 7393.75, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 167, Amount = 2672, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 36, Amount = 774, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 378, Amount = 6426, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 250, Amount = 4062.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 322, Amount = 5152, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 59, Amount = 1681.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 132, Amount = 3828, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 128, Amount = 3616, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 138, Amount = 3864, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 53, Amount = 1510.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 490, Amount = 14210, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 93, Amount = 2627.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 121, Amount = 3388, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 20, Amount = 570, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 227, Amount = 6583, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 414, Amount = 11695.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 440, Amount = 12320, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 80, Amount = 2280, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 221, Amount = 6409, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 492, Amount = 13899, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 246, Amount = 6888, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 37, Amount = 1054.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 361, Amount = 10469, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 464, Amount = 13108, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 387, Amount = 10836, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 34, Amount = 969, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 152, Amount = 4408, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 222, Amount = 6271.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 76, Amount = 2128, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 76, Amount = 2166, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 431, Amount = 12499, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 156, Amount = 4407, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 345, Amount = 9660, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 51, Amount = 1453.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 477, Amount = 13833, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 485, Amount = 13701.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 453, Amount = 12684, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 80, Amount = 2280, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 366, Amount = 10614, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 179, Amount = 5056.75, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 96, Amount = 2688, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 51, Amount = 1453.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 451, Amount = 13079, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 458, Amount = 12938.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 214, Amount = 5992, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 68, Amount = 1938, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 442, Amount = 12818, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 166, Amount = 4689.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 79, Amount = 2212, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 27, Amount = 769.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 156, Amount = 4524, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 447, Amount = 12627.75, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 226, Amount = 6328, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 61, Amount = 1738.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 158, Amount = 4582, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 60, Amount = 1695, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 166, Amount = 4648, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 74, Amount = 444.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 296, Amount = 2368, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 500, Amount = 3125, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 321, Amount = 1926, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 58, Amount = 348.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 312, Amount = 2496, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 236, Amount = 1475, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 542, Amount = 3252, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 79, Amount = 474.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 165, Amount = 1320, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 117, Amount = 731.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 195, Amount = 1170, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 55, Amount = 330.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 79, Amount = 632, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 171, Amount = 1068.75, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 237, Amount = 1422, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 17, Amount = 102.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 340, Amount = 2720, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 62, Amount = 387.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 226, Amount = 1356, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 85, Amount = 510.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 100, Amount = 800, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 385, Amount = 2406.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 287, Amount = 1722, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 91, Amount = 546.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 114, Amount = 912, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 494, Amount = 3087.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 170, Amount = 1020, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 45, Amount = 270.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 375, Amount = 3000, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 113, Amount = 706.25, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 112, Amount = 672, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 53, Amount = 318.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 336, Amount = 2688, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 399, Amount = 2493.75, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 281, Amount = 1686, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 70, Amount = 420.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 445, Amount = 3560, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 400, Amount = 2500, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 399, Amount = 2394, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 78, Amount = 468.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 362, Amount = 2896, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 228, Amount = 1425, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 353, Amount = 2118, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 52, Amount = 312.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 308, Amount = 2464, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 316, Amount = 1975, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 465, Amount = 2790, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 60, Amount = 360.5, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 371, Amount = 2968, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 263, Amount = 1643.75, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 293, Amount = 1758, Country = "United Kingdom", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 81, Amount = 138024, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 211, Amount = 360599, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 170, Amount = 290020, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 244, Amount = 414556, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 13, Amount = 22152, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 78, Amount = 133302, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 219, Amount = 373614, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 521, Amount = 885179, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 21, Amount = 35784, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 162, Amount = 276858, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 411, Amount = 701166, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 331, Amount = 562369, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 14, Amount = 23856, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 332, Amount = 567388, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 166, Amount = 283196, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 77, Amount = 130823, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 32, Amount = 54528, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 257, Amount = 439213, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 54, Amount = 92124, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 64, Amount = 108736, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 17, Amount = 28968, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 147, Amount = 251223, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 223, Amount = 380438, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 93, Amount = 158007, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 55, Amount = 93720, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 426, Amount = 728034, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 317, Amount = 540802, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 212, Amount = 360188, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 29, Amount = 49416, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 148, Amount = 252932, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 63, Amount = 107478, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 353, Amount = 599747, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 10, Amount = 17040, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 354, Amount = 604986, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 370, Amount = 631220, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 242, Amount = 411158, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 61, Amount = 103944, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 92, Amount = 157228, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 302, Amount = 515212, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 501, Amount = 851199, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 91, Amount = 155064, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 280, Amount = 478520, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 303, Amount = 516918, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 272, Amount = 462128, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 34, Amount = 57936, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 377, Amount = 644293, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 87, Amount = 148422, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 232, Amount = 394168, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 13, Amount = 22152, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 251, Amount = 428959, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 273, Amount = 465738, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 510, Amount = 866490, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 30, Amount = 44975, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 184, Amount = 277656, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 486, Amount = 731916, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 536, Amount = 416722, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 86, Amount = 128919, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 131, Amount = 197679, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 451, Amount = 679206, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 380, Amount = 337275, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 53, Amount = 79452, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 190, Amount = 286710, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 280, Amount = 421680, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 396, Amount = 803464, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 49, Amount = 73456, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 172, Amount = 259548, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 275, Amount = 414150, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 154, Amount = 569620, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 99, Amount = 148406, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 401, Amount = 605109, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 387, Amount = 582822, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 397, Amount = 593604, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 10, Amount = 14995, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 143, Amount = 215787, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 178, Amount = 268068, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 151, Amount = 230846, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 98, Amount = 146907, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 376, Amount = 567384, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 269, Amount = 405114, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 302, Amount = 595103, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 20, Amount = 29985, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 150, Amount = 226350, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 239, Amount = 359934, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 141, Amount = 226349, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 27, Amount = 40478, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 169, Amount = 255021, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 448, Amount = 674688, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 313, Amount = 452698, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 87, Amount = 130418, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 76, Amount = 114684, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 175, Amount = 263550, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 515, Amount = 211359, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 18, Amount = 26987, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 361, Amount = 544749, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 237, Amount = 356922, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 206, Amount = 469187, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 38, Amount = 56967, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 139, Amount = 209751, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 50, Amount = 75300, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 152, Amount = 771985, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 46, Amount = 68959, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 229, Amount = 345561, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 233, Amount = 350898, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 241, Amount = 308794, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 58, Amount = 86947, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 385, Amount = 580965, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 328, Amount = 493968, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 470, Amount = 227848, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 63, Amount = 94442, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 288, Amount = 434592, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 304, Amount = 457824, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 407, Amount = 361259, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 91, Amount = 136414, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 154, Amount = 232386, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 222, Amount = 334332, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 488, Amount = 704530, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 24, Amount = 35981, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 122, Amount = 184098, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 300, Amount = 451800, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 62, Amount = 610093, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 94, Amount = 140911, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 65, Amount = 98085, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 286, Amount = 430716, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 340, Amount = 731512, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 53, Amount = 79452, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 322, Amount = 485898, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 471, Amount = 709326, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 340, Amount = 92938, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 88, Amount = 131917, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 469, Amount = 707721, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 260, Amount = 391560, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 83, Amount = 509660, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 94, Amount = 140911, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 206, Amount = 310854, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 98, Amount = 147588, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 221, Amount = 509660, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 13, Amount = 19492, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 115, Amount = 173535, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 330, Amount = 496980, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 432, Amount = 124417, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 59, Amount = 88446, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 487, Amount = 734883, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 373, Amount = 561738, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 269, Amount = 331279, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 83, Amount = 124422, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 413, Amount = 623217, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 422, Amount = 635532, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 126, Amount = 647568, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 92, Amount = 137913, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 449, Amount = 677541, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 459, Amount = 691254, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 142, Amount = 403231, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 43, Amount = 64462, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 129, Amount = 194661, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 401, Amount = 603906, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 397, Amount = 188874, Country = "United States", Product_Categories = "Bikes", Products = "Road Bikes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 40, Amount = 68160, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 286, Amount = 488774, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 429, Amount = 731874, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 117, Amount = 198783, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 28, Amount = 47712, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 408, Amount = 697272, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 88, Amount = 150128, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 527, Amount = 895373, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 11, Amount = 18744, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 359, Amount = 613531, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 105, Amount = 179130, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 377, Amount = 640523, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 17, Amount = 28968, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 274, Amount = 468266, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 314, Amount = 535684, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 188, Amount = 319412, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 69, Amount = 117576, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 142, Amount = 242678, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 199, Amount = 339494, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 353, Amount = 599747, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 54, Amount = 92016, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 396, Amount = 676764, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 178, Amount = 303668, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 509, Amount = 864791, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 66, Amount = 112464, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 145, Amount = 247805, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 352, Amount = 600512, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 207, Amount = 351693, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 30, Amount = 51120, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 417, Amount = 712653, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 172, Amount = 293432, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 217, Amount = 368683, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 83, Amount = 141432, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 499, Amount = 852791, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 163, Amount = 278078, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 402, Amount = 682998, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 51, Amount = 86904, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 452, Amount = 772468, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 55, Amount = 93830, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 164, Amount = 278636, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 39, Amount = 66456, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 390, Amount = 666510, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 363, Amount = 619278, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 367, Amount = 623533, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 33, Amount = 56232, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 483, Amount = 825447, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 469, Amount = 800114, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 252, Amount = 428148, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 70, Amount = 119280, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 199, Amount = 340091, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 351, Amount = 598806, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 173, Amount = 293927, Country = "United States", Product_Categories = "Bikes", Products = "Mountain Bikes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 75, Amount = 119662.5, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 420, Amount = 670320, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 226, Amount = 360526.5, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 229, Amount = 365255, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 59, Amount = 94134.5, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 109, Amount = 173964, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 264, Amount = 421146, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 219, Amount = 349305, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 52, Amount = 82966, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 144, Amount = 229824, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 197, Amount = 314264.25, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 141, Amount = 224895, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 63, Amount = 100516.5, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 492, Amount = 785232, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 121, Amount = 193025.25, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 268, Amount = 427460, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 18, Amount = 28719, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 411, Amount = 655956, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 56, Amount = 89334, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 443, Amount = 706585, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 32, Amount = 51056, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 88, Amount = 140448, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 136, Amount = 216954, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 89, Amount = 141955, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 41, Amount = 65415.5, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 468, Amount = 746928, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 316, Amount = 504099, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 419, Amount = 668305, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 38, Amount = 60629, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 485, Amount = 774060, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 106, Amount = 169096.5, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 544, Amount = 867680, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 42, Amount = 67011, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 118, Amount = 188328, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 166, Amount = 264811.5, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 439, Amount = 700205, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 75, Amount = 119662.5, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 284, Amount = 453264, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 395, Amount = 630123.75, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 286, Amount = 456170, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 85, Amount = 135617.5, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 330, Amount = 526680, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 61, Amount = 97310.25, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 370, Amount = 590150, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 99, Amount = 157954.5, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 259, Amount = 413364, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 295, Amount = 470598.75, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 288, Amount = 459360, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 34, Amount = 54247, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 118, Amount = 188328, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 257, Amount = 409979.25, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 337, Amount = 537515, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 30, Amount = 47865, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 293, Amount = 467628, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 179, Amount = 285549.75, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 463, Amount = 738485, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 90, Amount = 143595, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 365, Amount = 582540, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 313, Amount = 499313.25, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 290, Amount = 462550, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 95, Amount = 151572.5, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 370, Amount = 590520, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 301, Amount = 480170.25, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 297, Amount = 473715, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 66, Amount = 105303, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 153, Amount = 244188, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 178, Amount = 283954.5, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 414, Amount = 660330, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 28, Amount = 44674, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 244, Amount = 389424, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 90, Amount = 143572.5, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 477, Amount = 760815, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 73, Amount = 116471.5, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 390, Amount = 622440, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 392, Amount = 625338, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 412, Amount = 657140, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 33, Amount = 52651.5, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 423, Amount = 675108, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 188, Amount = 299907, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 465, Amount = 741675, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 26, Amount = 41483, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 50, Amount = 79800, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 313, Amount = 499313.25, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 287, Amount = 457765, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 92, Amount = 146786, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 356, Amount = 568176, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 445, Amount = 709886.25, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 204, Amount = 325380, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 83, Amount = 132426.5, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 88, Amount = 140448, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 313, Amount = 499313.25, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 262, Amount = 417890, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 59, Amount = 94134.5, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 109, Amount = 173964, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 394, Amount = 628528.5, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 199, Amount = 317405, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 94, Amount = 149977, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 202, Amount = 322392, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 342, Amount = 545575.5, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 252, Amount = 401940, Country = "United Kingdom", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 79, Amount = 126044.5, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 219, Amount = 349524, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 412, Amount = 657243, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 359, Amount = 572605, Country = "United States", Product_Categories = "Bikes", Products = "Touring Bikes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 59, Amount = 354.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 24, Amount = 684, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 64, Amount = 1376, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 34, Amount = 3774.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 345, Amount = 2760, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 128, Amount = 3712, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 294, Amount = 4998, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 288, Amount = 32256, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 362, Amount = 2262.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 250, Amount = 7062.5, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 386, Amount = 6272.5, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 83, Amount = 9233.75, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 447, Amount = 2682, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 174, Amount = 4872, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 375, Amount = 6000, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 434, Amount = 38295, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 42, Amount = 252.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 72, Amount = 2052, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 84, Amount = 1806, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 64, Amount = 7104.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 181, Amount = 1448, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 364, Amount = 10556, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 72, Amount = 1224, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 407, Amount = 45584, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 342, Amount = 2137.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 291, Amount = 8220.75, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 242, Amount = 3932.5, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 398, Amount = 44277.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 321, Amount = 1926, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 356, Amount = 9968, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 61, Amount = 976, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 520, Amount = 20091, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 62, Amount = 372.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 46, Amount = 1311, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 21, Amount = 451.5, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 15, Amount = 1665.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 232, Amount = 1856, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 141, Amount = 4089, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 407, Amount = 6919, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 381, Amount = 42672, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 204, Amount = 1275, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 194, Amount = 5480.5, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 344, Amount = 5590, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 479, Amount = 53288.75, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 139, Amount = 834, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 407, Amount = 11396, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 370, Amount = 5920, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 336, Amount = 25752, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 37, Amount = 222.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 37, Amount = 1054.5, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 14, Amount = 301, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 10, Amount = 1110.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 342, Amount = 2736, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 456, Amount = 13224, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 455, Amount = 7735, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 257, Amount = 28784, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 333, Amount = 2081.25, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 261, Amount = 7373.25, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 212, Amount = 3445, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 236, Amount = 26255, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 311, Amount = 1866, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 348, Amount = 9744, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 161, Amount = 2576, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 517, Amount = 37962, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 50, Amount = 300.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 36, Amount = 1026, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 71, Amount = 1526.5, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 76, Amount = 8436.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 314, Amount = 2512, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 493, Amount = 14297, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 105, Amount = 1785, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 112, Amount = 12544, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 382, Amount = 2387.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 164, Amount = 4633, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 195, Amount = 3168.75, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 146, Amount = 16242.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 340, Amount = 2040, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 201, Amount = 5628, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 509, Amount = 8144, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 151, Amount = 34854, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 11, Amount = 66.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 18, Amount = 513, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 55, Amount = 1182.5, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 22, Amount = 2442.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 281, Amount = 2248, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 344, Amount = 9976, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 213, Amount = 3621, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 423, Amount = 47376, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 255, Amount = 1593.75, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 267, Amount = 7542.75, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 159, Amount = 2583.75, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 325, Amount = 36156.25, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 489, Amount = 2934, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 423, Amount = 11844, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 181, Amount = 2896, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 437, Amount = 31191, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 81, Amount = 486.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 86, Amount = 2451, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 90, Amount = 1935, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 66, Amount = 7326.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 253, Amount = 2024, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 471, Amount = 13659, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 441, Amount = 7497, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 255, Amount = 28560, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 66, Amount = 412.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 187, Amount = 5282.75, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 324, Amount = 5265, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 348, Amount = 38715, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 208, Amount = 1248, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 293, Amount = 8204, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 80, Amount = 1280, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 447, Amount = 28083, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 10, Amount = 60.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 45, Amount = 1282.5, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 86, Amount = 1849, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 14, Amount = 1554.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 373, Amount = 2984, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 151, Amount = 4379, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 107, Amount = 1819, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 227, Amount = 25424, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 382, Amount = 2387.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 233, Amount = 6582.25, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 139, Amount = 2258.75, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 410, Amount = 45612.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 540, Amount = 3240, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 265, Amount = 7420, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 206, Amount = 3296, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 392, Amount = 41403, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 21, Amount = 126.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 35, Amount = 997.5, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 79, Amount = 1698.5, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 31, Amount = 3441.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 106, Amount = 848, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 148, Amount = 4292, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 437, Amount = 7429, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 355, Amount = 39760, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 280, Amount = 1750, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 308, Amount = 8701, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 252, Amount = 4095, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 239, Amount = 26588.75, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 439, Amount = 2634, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 260, Amount = 7280, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 294, Amount = 4704, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 340, Amount = 11766, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 62, Amount = 372.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 30, Amount = 855, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 54, Amount = 1161, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 17, Amount = 1887.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 80, Amount = 640, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 86, Amount = 2494, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 63, Amount = 1071, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 75, Amount = 8400, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 123, Amount = 768.75, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 219, Amount = 6186.75, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 274, Amount = 4452.5, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 57, Amount = 6341.25, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 259, Amount = 1554, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 266, Amount = 7448, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 246, Amount = 3936, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 70, Amount = 8880, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 34, Amount = 204.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 40, Amount = 1140, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 47, Amount = 1010.5, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 49, Amount = 5439.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 206, Amount = 1648, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 169, Amount = 4901, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 385, Amount = 6545, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 358, Amount = 40096, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 148, Amount = 925, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 128, Amount = 3616, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 376, Amount = 6110, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 64, Amount = 7120, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 399, Amount = 2394, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 145, Amount = 4060, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 199, Amount = 3184, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 366, Amount = 22866, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 13, Amount = 78.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 82, Amount = 2337, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 15, Amount = 322.5, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 50, Amount = 5550.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 462, Amount = 3696, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 165, Amount = 4785, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 228, Amount = 3876, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 89, Amount = 9968, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 157, Amount = 981.25, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 115, Amount = 3248.75, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 420, Amount = 6825, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 490, Amount = 54512.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 459, Amount = 2754, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 332, Amount = 9296, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 93, Amount = 1488, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 61, Amount = 51282, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 81, Amount = 486.5, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 81, Amount = 2308.5, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 73, Amount = 1569.5, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 62, Amount = 6882.5, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 125, Amount = 1000, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 274, Amount = 7946, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 348, Amount = 5916, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 489, Amount = 54768, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 144, Amount = 900, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 155, Amount = 4378.75, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 134, Amount = 2177.5, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 393, Amount = 43721.25, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 423, Amount = 2538, Country = "United States", Product_Categories = "Clothing", Products = "Gloves", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 178, Amount = 4984, Country = "United States", Product_Categories = "Clothing", Products = "Jerseys", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 439, Amount = 7024, Country = "United States", Product_Categories = "Clothing", Products = "Shorts", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 220, Amount = 13875, Country = "United States", Product_Categories = "Clothing", Products = "Vests", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 53, Amount = 1033.5, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 70, Amount = 525.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 61, Amount = 1875.75, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 61, Amount = 458, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 81, Amount = 1278.18, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 94, Amount = 1081, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 395, Amount = 7900, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 400, Amount = 3400, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 306, Amount = 9562.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 200, Amount = 1000, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 477, Amount = 7765.56, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 339, Amount = 4068, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 111, Amount = 2136.75, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 384, Amount = 2976, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 384, Amount = 11712, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 228, Amount = 969, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 355, Amount = 5513.15, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 150, Amount = 1687.5, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 459, Amount = 8721, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 481, Amount = 3607.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 243, Amount = 7350.75, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 520, Amount = 2080, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 250, Amount = 3820, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 141, Amount = 1551, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 85, Amount = 1657.5, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 14, Amount = 105.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 96, Amount = 2952, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 76, Amount = 342, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 93, Amount = 1467.54, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 75, Amount = 862.5, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 181, Amount = 3620, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 63, Amount = 535.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 94, Amount = 2937.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 290, Amount = 1450, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 495, Amount = 8058.6, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 455, Amount = 5460, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 487, Amount = 9374.75, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 446, Amount = 3456.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 298, Amount = 9089, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 291, Amount = 1236.75, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 291, Amount = 4519.23, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 128, Amount = 1440, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 321, Amount = 6099, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 515, Amount = 3862.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 534, Amount = 16153.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 467, Amount = 1868, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 322, Amount = 4920.16, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 258, Amount = 2838, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 59, Amount = 1150.5, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 57, Amount = 428, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 27, Amount = 830.25, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 76, Amount = 342, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 16, Amount = 252.48, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 87, Amount = 1000.5, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 388, Amount = 7760, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 327, Amount = 2779.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 149, Amount = 4656.25, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 386, Amount = 1930, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 325, Amount = 5291, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 273, Amount = 3276, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 52, Amount = 1001, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 398, Amount = 3084.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 242, Amount = 7381, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 319, Amount = 1355.75, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 300, Amount = 4659, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 318, Amount = 3577.5, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 217, Amount = 4123, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 277, Amount = 2077.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 450, Amount = 13612.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 267, Amount = 1068, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 498, Amount = 7609.44, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 246, Amount = 2706, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 70, Amount = 1365, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 62, Amount = 465.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 75, Amount = 2306.25, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 39, Amount = 175.5, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 52, Amount = 820.56, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 96, Amount = 1104, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 351, Amount = 7020, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 437, Amount = 3714.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 260, Amount = 8125, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 321, Amount = 1605, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 66, Amount = 1074.48, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 125, Amount = 1500, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 237, Amount = 4562.25, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 208, Amount = 1612, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 471, Amount = 14365.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 453, Amount = 1925.25, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 234, Amount = 3634.02, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 199, Amount = 2238.75, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 542, Amount = 10298, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 109, Amount = 817.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 191, Amount = 5777.75, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 124, Amount = 496, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 343, Amount = 5241.04, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 199, Amount = 2189, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2018", Quarter = "Q1" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 65, Amount = 1267.5, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 75, Amount = 563, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 75, Amount = 2306.25, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 66, Amount = 297, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 29, Amount = 457.62, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 43, Amount = 494.5, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 314, Amount = 6280, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 498, Amount = 4233, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 15, Sold = 494, Amount = 15437.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 164, Amount = 820, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 447, Amount = 7277.16, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 154, Amount = 1848, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 388, Amount = 7469, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 498, Amount = 3859.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 400, Amount = 12200, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 500, Amount = 2125, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 457, Amount = 7097.21, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 216, Amount = 2430, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 90, Amount = 1710, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 344, Amount = 2580, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 188, Amount = 5687, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 488, Amount = 1952, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 468, Amount = 7151.04, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 454, Amount = 4994, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 42, Amount = 819, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 89, Amount = 668, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 84, Amount = 2583, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 41, Amount = 184.5, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 77, Amount = 1215.06, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 97, Amount = 1115.5, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 169, Amount = 3380, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 494, Amount = 4199, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 127, Amount = 3968.75, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 459, Amount = 2295, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 466, Amount = 7586.48, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 64, Amount = 768, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 417, Amount = 8027.25, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 73, Amount = 565.75, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 482, Amount = 14701, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 367, Amount = 1559.75, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 303, Amount = 4705.59, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 176, Amount = 1980, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 436, Amount = 8284, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 203, Amount = 1522.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 95, Amount = 2873.75, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 381, Amount = 1524, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 85, Amount = 1298.8, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 74, Amount = 814, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 13, Amount = 253.5, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 15, Amount = 113, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 46, Amount = 1414.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 69, Amount = 310.5, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 34, Amount = 536.52, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 38, Amount = 437, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 480, Amount = 9600, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 434, Amount = 3689, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 181, Amount = 5656.25, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 500, Amount = 2500, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 46, Sold = 63, Amount = 1025.64, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 238, Amount = 2856, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 257, Amount = 4947.25, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 178, Amount = 1379.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 264, Amount = 8052, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 441, Amount = 1874.25, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 243, Amount = 3773.79, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 131, Amount = 1473.75, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 402, Amount = 7638, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 488, Amount = 3660, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 237, Amount = 7169.25, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 251, Amount = 1004, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 151, Amount = 2307.28, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 387, Amount = 4257, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q2" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 10, Amount = 195, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 77, Amount = 578, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 70, Amount = 2152.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 90, Amount = 405, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 58, Amount = 915.24, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 91, Amount = 1046.5, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 497, Amount = 9940, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 411, Amount = 3493.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 285, Amount = 8906.25, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 62, Amount = 310, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 109, Amount = 1774.52, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 172, Amount = 2064, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 408, Amount = 7854, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 78, Amount = 604.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 149, Amount = 4544.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 387, Amount = 1644.75, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 269, Amount = 4177.57, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 291, Amount = 3273.75, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 292, Amount = 5548, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 124, Amount = 930, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 265, Amount = 8016.25, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 175, Amount = 700, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 144, Amount = 2200.32, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 411, Amount = 4521, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 75, Amount = 1462.5, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 30, Amount = 225.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 15, Amount = 461.25, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 30, Amount = 135, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 63, Amount = 994.14, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 55, Amount = 632.5, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 58, Amount = 1160, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 308, Amount = 2618, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 331, Amount = 10343.75, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 312, Amount = 1560, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 186, Amount = 3028.08, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 261, Amount = 3132, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 87, Amount = 1674.75, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 42, Sold = 197, Amount = 1526.75, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 124, Amount = 3782, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 178, Amount = 756.5, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 274, Amount = 4255.22, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 388, Amount = 4365, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 528, Amount = 10032, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 33, Sold = 285, Amount = 2137.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 306, Amount = 9256.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 43, Sold = 548, Amount = 2192, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 265, Amount = 4049.2, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 261, Amount = 2871, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 57, Amount = 1111.5, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 12, Amount = 90.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 48, Amount = 1476, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 68, Amount = 306, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 26, Sold = 42, Amount = 662.76, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 82, Amount = 943, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 312, Amount = 6240, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 206, Amount = 1751, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 393, Amount = 12281.25, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 48, Sold = 354, Amount = 1770, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 45, Sold = 160, Amount = 2604.8, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 243, Amount = 2916, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 430, Amount = 8277.5, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 56, Amount = 434, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 101, Amount = 3080.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 1, Sold = 202, Amount = 858.5, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 30, Sold = 472, Amount = 7330.16, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 385, Amount = 4331.25, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 287, Amount = 5453, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 129, Amount = 967.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 49, Sold = 547, Amount = 16546.75, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 276, Amount = 1104, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 518, Amount = 7915.04, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 158, Amount = 1738, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q3" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 46, Amount = 897, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 47, Amount = 353, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 17, Amount = 522.75, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 31, Amount = 139.5, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 77, Amount = 1215.06, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 100, Amount = 1150, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 356, Amount = 7120, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 41, Sold = 418, Amount = 3553, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 16, Sold = 261, Amount = 8156.25, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 306, Amount = 1530, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 361, Amount = 5877.08, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 29, Sold = 193, Amount = 2316, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 420, Amount = 8085, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 197, Amount = 1526.75, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 247, Amount = 7533.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 18, Sold = 175, Amount = 743.75, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 31, Sold = 436, Amount = 6771.08, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 5, Sold = 91, Amount = 1023.75, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 135, Amount = 2565, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 102, Amount = 765, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 88, Amount = 2662, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 406, Amount = 1624, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 44, Sold = 275, Amount = 4202, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 116, Amount = 1276, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2015", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 66, Amount = 1287, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 3, Sold = 86, Amount = 645.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 50, Sold = 68, Amount = 2091, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 40, Sold = 96, Amount = 432, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 79, Amount = 1246.62, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 21, Sold = 69, Amount = 793.5, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 35, Sold = 269, Amount = 5380, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 152, Amount = 1292, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 213, Amount = 6656.25, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 212, Amount = 1060, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 454, Amount = 7391.12, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 197, Amount = 2364, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 7, Sold = 76, Amount = 1463, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 242, Amount = 1875.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 37, Sold = 211, Amount = 6435.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 12, Sold = 149, Amount = 633.25, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 104, Amount = 1615.12, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 36, Sold = 371, Amount = 4173.75, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 545, Amount = 10355, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 39, Sold = 547, Amount = 4102.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 2, Sold = 386, Amount = 11676.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 34, Sold = 199, Amount = 796, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 454, Amount = 6937.12, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 138, Amount = 1518, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2016", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 6, Sold = 32, Amount = 624, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 19, Sold = 80, Amount = 600.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 25, Sold = 33, Amount = 1014.75, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 38, Sold = 48, Amount = 216, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 8, Sold = 36, Amount = 568.08, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 4, Sold = 18, Amount = 207, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Retail Outlets", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 32, Sold = 125, Amount = 2500, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 28, Sold = 481, Amount = 4088.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 287, Amount = 8968.75, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 10, Sold = 302, Amount = 1510, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 264, Amount = 4297.92, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 23, Sold = 107, Amount = 1284, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Sales Person", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 17, Sold = 219, Amount = 4215.75, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 20, Sold = 384, Amount = 2976, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 27, Sold = 231, Amount = 7045.5, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 409, Amount = 1738.25, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 24, Sold = 204, Amount = 3168.12, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 22, Sold = 301, Amount = 3386.25, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "Teleshopping", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 535, Amount = 10165, Country = "United States", Product_Categories = "Accessories", Products = "Tires and Tubes", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 47, Sold = 405, Amount = 3037.5, Country = "United States", Product_Categories = "Accessories", Products = "Bottles and Cages", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 14, Sold = 385, Amount = 11646.25, Country = "United States", Product_Categories = "Accessories", Products = "Hydration Packs", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 11, Sold = 426, Amount = 1704, Country = "United States", Product_Categories = "Accessories", Products = "Cleaners", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 13, Sold = 392, Amount = 5989.76, Country = "United States", Product_Categories = "Accessories", Products = "Helmets", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            pivot_Data.Add(new Pivot_Data { In_Stock = 9, Sold = 426, Amount = 4686, Country = "United States", Product_Categories = "Accessories", Products = "Fenders", Order_Source = "App Store", Year = "FY 2017", Quarter = "Q4" });
            return pivot_Data;
        }

        public List<DefaultData> GetDefaultData()
        {
            List<DefaultData> defaultData = new List<DefaultData>();
            defaultData.Add(new DefaultData { Sold = 31, Amount = 52824, Country = "France", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 51, Amount = 86904, Country = "France", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 90, Amount = 153360, Country = "France", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 25, Amount = 42600, Country = "France", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 27, Amount = 46008, Country = "France", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 49, Amount = 83496, Country = "France", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 95, Amount = 161880, Country = "France", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 67, Amount = 114168, Country = "France", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 75, Amount = 127800, Country = "France", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 67, Amount = 114168, Country = "France", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 69, Amount = 117576, Country = "France", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 90, Amount = 153360, Country = "France", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 16, Amount = 27264, Country = "France", Products = "Mountain Bikes", Year = "FY 2018", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 83, Amount = 124422, Country = "France", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 57, Amount = 85448, Country = "France", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 20, Amount = 29985, Country = "France", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 93, Amount = 139412, Country = "France", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 35, Amount = 52470, Country = "France", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 28, Amount = 41977, Country = "France", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 48, Amount = 71957, Country = "France", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 36, Amount = 53969, Country = "France", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 25, Amount = 37480, Country = "France", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 69, Amount = 103436, Country = "France", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 16, Amount = 23989, Country = "France", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 28, Amount = 41977, Country = "France", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 19, Amount = 28486, Country = "France", Products = "Road Bikes", Year = "FY 2018", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 89, Amount = 141999.5, Country = "France", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 91, Amount = 145190.5, Country = "France", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 24, Amount = 38292, Country = "France", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 75, Amount = 119662.5, Country = "France", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 100, Amount = 159550, Country = "France", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 30, Amount = 47865, Country = "France", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 69, Amount = 110089.5, Country = "France", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 25, Amount = 39887.5, Country = "France", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 42, Amount = 67011, Country = "France", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 94, Amount = 149977, Country = "France", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 76, Amount = 121258, Country = "France", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 52, Amount = 82966, Country = "France", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 33, Amount = 52651.5, Country = "France", Products = "Touring Bikes", Year = "FY 2018", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 16, Amount = 23989, Country = "Germany", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 21, Amount = 33505.5, Country = "Germany", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 74, Amount = 126096, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 99, Amount = 148406, Country = "Germany", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 31, Amount = 49460.5, Country = "Germany", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 57, Amount = 97128, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 41, Amount = 61464, Country = "Germany", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 64, Amount = 102112, Country = "Germany", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 85, Amount = 144840, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 76, Amount = 129504, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2018", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 33, Amount = 56232, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 71, Amount = 120984, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 81, Amount = 138024, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 65, Amount = 110760, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 39, Amount = 66456, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 91, Amount = 155064, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 16, Amount = 27264, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 59, Amount = 100536, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 36, Amount = 61344, Country = "Germany", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 39, Amount = 58466, Country = "Germany", Products = "Road Bikes", Year = "FY 2018", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 47, Amount = 70458, Country = "Germany", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 19, Amount = 28486, Country = "Germany", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 34, Amount = 50971, Country = "Germany", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 34, Amount = 50971, Country = "Germany", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 26, Amount = 38979, Country = "Germany", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 15, Amount = 22490, Country = "Germany", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 83, Amount = 124422, Country = "Germany", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 79, Amount = 118426, Country = "Germany", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 14, Amount = 20991, Country = "Germany", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 15, Amount = 23932.5, Country = "Germany", Products = "Touring Bikes", Year = "FY 2018", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 47, Amount = 74988.5, Country = "Germany", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 93, Amount = 148381.5, Country = "Germany", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 13, Amount = 20741.5, Country = "Germany", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 44, Amount = 70202, Country = "Germany", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 59, Amount = 94134.5, Country = "Germany", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 34, Amount = 54247, Country = "Germany", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 48, Amount = 76584, Country = "Germany", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 35, Amount = 55842.5, Country = "Germany", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 71, Amount = 113280.5, Country = "Germany", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 77, Amount = 131208, Country = "United Kingdom", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 92, Amount = 156768, Country = "United Kingdom", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 51, Amount = 86904, Country = "United Kingdom", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 91, Amount = 155064, Country = "United Kingdom", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 90, Amount = 153360, Country = "United Kingdom", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 56, Amount = 95424, Country = "United Kingdom", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 14, Amount = 23856, Country = "United Kingdom", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 95, Amount = 161880, Country = "United Kingdom", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 24, Amount = 40896, Country = "United Kingdom", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 39, Amount = 66456, Country = "United Kingdom", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 84, Amount = 143136, Country = "United Kingdom", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 40, Amount = 68160, Country = "United Kingdom", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 96, Amount = 163584, Country = "United Kingdom", Products = "Mountain Bikes", Year = "FY 2018", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 24, Amount = 35981, Country = "United Kingdom", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 86, Amount = 128919, Country = "United States", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 31, Amount = 46474, Country = "United Kingdom", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 36, Amount = 53969, Country = "United States", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 40, Amount = 59965, Country = "United Kingdom", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 69, Amount = 103436, Country = "United States", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 95, Amount = 142410, Country = "United Kingdom", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 95, Amount = 142410, Country = "United States", Products = "Road Bikes", Year = "FY 2015", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 30, Amount = 44975, Country = "United Kingdom", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 11, Amount = 16494, Country = "United States", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 97, Amount = 145408, Country = "United Kingdom", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 16, Amount = 23989, Country = "United States", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 40, Amount = 59965, Country = "United Kingdom", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 68, Amount = 101937, Country = "United States", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 11, Amount = 16494, Country = "United Kingdom", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 27, Amount = 40478, Country = "United States", Products = "Road Bikes", Year = "FY 2016", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 45, Amount = 67460, Country = "United Kingdom", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 100, Amount = 149905, Country = "United States", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 70, Amount = 104935, Country = "United Kingdom", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 83, Amount = 124422, Country = "United States", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 100, Amount = 149905, Country = "United Kingdom", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 18, Amount = 26987, Country = "United States", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 70, Amount = 104935, Country = "United Kingdom", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 81, Amount = 121424, Country = "United States", Products = "Road Bikes", Year = "FY 2017", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 20, Amount = 29985, Country = "United Kingdom", Products = "Road Bikes", Year = "FY 2018", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 99, Amount = 148406, Country = "United States", Products = "Road Bikes", Year = "FY 2018", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 43, Amount = 73272, Country = "United States", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 43, Amount = 73272, Country = "United States", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 52, Amount = 88608, Country = "United States", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 91, Amount = 155064, Country = "United States", Products = "Mountain Bikes", Year = "FY 2015", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 37, Amount = 63048, Country = "United States", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 41, Amount = 69864, Country = "United States", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 49, Amount = 83496, Country = "United States", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 23, Amount = 39192, Country = "United States", Products = "Mountain Bikes", Year = "FY 2016", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 67, Amount = 114168, Country = "United States", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 85, Amount = 144840, Country = "United States", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 25, Amount = 42600, Country = "United States", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 28, Amount = 47712, Country = "United States", Products = "Mountain Bikes", Year = "FY 2017", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 53, Amount = 90312, Country = "United States", Products = "Mountain Bikes", Year = "FY 2018", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 82, Amount = 130831, Country = "United Kingdom", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 41, Amount = 65415.5, Country = "United States", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 60, Amount = 95730, Country = "United Kingdom", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 71, Amount = 113280.5, Country = "United States", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 45, Amount = 71797.5, Country = "United Kingdom", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 21, Amount = 33505.5, Country = "United States", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 94, Amount = 149977, Country = "United Kingdom", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 34, Amount = 54247, Country = "United States", Products = "Touring Bikes", Year = "FY 2015", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 14, Amount = 22337, Country = "United Kingdom", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 76, Amount = 121258, Country = "United States", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 50, Amount = 79775, Country = "United Kingdom", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 75, Amount = 119662.5, Country = "United States", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 49, Amount = 78179.5, Country = "United Kingdom", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 40, Amount = 63820, Country = "United States", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 94, Amount = 149977, Country = "United Kingdom", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 17, Amount = 27123.5, Country = "United States", Products = "Touring Bikes", Year = "FY 2016", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 45, Amount = 71797.5, Country = "United Kingdom", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 56, Amount = 89348, Country = "United States", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 75, Amount = 119662.5, Country = "United Kingdom", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 11, Amount = 17550.5, Country = "United States", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q2" });
            defaultData.Add(new DefaultData { Sold = 54, Amount = 86157, Country = "United Kingdom", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 14, Amount = 22337, Country = "United States", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q3" });
            defaultData.Add(new DefaultData { Sold = 11, Amount = 17550.5, Country = "United Kingdom", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 76, Amount = 121258, Country = "United States", Products = "Touring Bikes", Year = "FY 2017", Quarter = "Q4" });
            defaultData.Add(new DefaultData { Sold = 45, Amount = 71797.5, Country = "United Kingdom", Products = "Touring Bikes", Year = "FY 2018", Quarter = "Q1" });
            defaultData.Add(new DefaultData { Sold = 80, Amount = 127640, Country = "United States", Products = "Touring Bikes", Year = "FY 2018", Quarter = "Q1" });
            return defaultData;
        }

        public List<HeatMapData> GetHeatMapData()
        {
            List<HeatMapData> heatmapData = new List<HeatMapData>();
            heatmapData.Add(new HeatMapData { Amount = 33073, Products = "Cakes", Month = "January" });
            heatmapData.Add(new HeatMapData { Amount = 32345, Products = "Cakes", Month = "February" });
            heatmapData.Add(new HeatMapData { Amount = 43312, Products = "Cakes", Month = "March" });
            heatmapData.Add(new HeatMapData { Amount = 54895, Products = "Cakes", Month = "April" });
            heatmapData.Add(new HeatMapData { Amount = 59099, Products = "Cakes", Month = "May" });
            heatmapData.Add(new HeatMapData { Amount = 62789, Products = "Cakes", Month = "June" });
            heatmapData.Add(new HeatMapData { Amount = 50988, Products = "Cakes", Month = "July" });
            heatmapData.Add(new HeatMapData { Amount = 62300, Products = "Cakes", Month = "August" });
            heatmapData.Add(new HeatMapData { Amount = 63010, Products = "Cakes", Month = "September" });
            heatmapData.Add(new HeatMapData { Amount = 45670, Products = "Cakes", Month = "October" });
            heatmapData.Add(new HeatMapData { Amount = 40500, Products = "Cakes", Month = "November" });
            heatmapData.Add(new HeatMapData { Amount = 65000, Products = "Cakes", Month = "December" });
            heatmapData.Add(new HeatMapData { Amount = 43421, Products = "Chocolates", Month = "January" });
            heatmapData.Add(new HeatMapData { Amount = 32090, Products = "Chocolates", Month = "February" });
            heatmapData.Add(new HeatMapData { Amount = 45450, Products = "Chocolates", Month = "March" });
            heatmapData.Add(new HeatMapData { Amount = 56890, Products = "Chocolates", Month = "April" });
            heatmapData.Add(new HeatMapData { Amount = 60250, Products = "Chocolates", Month = "May" });
            heatmapData.Add(new HeatMapData { Amount = 32750, Products = "Chocolates", Month = "June" });
            heatmapData.Add(new HeatMapData { Amount = 35670, Products = "Chocolates", Month = "July" });
            heatmapData.Add(new HeatMapData { Amount = 40125, Products = "Chocolates", Month = "August" });
            heatmapData.Add(new HeatMapData { Amount = 62500, Products = "Chocolates", Month = "September" });
            heatmapData.Add(new HeatMapData { Amount = 45050, Products = "Chocolates", Month = "October" });
            heatmapData.Add(new HeatMapData { Amount = 57500, Products = "Chocolates", Month = "November" });
            heatmapData.Add(new HeatMapData { Amount = 62500, Products = "Chocolates", Month = "December" });
            heatmapData.Add(new HeatMapData { Amount = 40680, Products = "Energy Drinks", Month = "January" });
            heatmapData.Add(new HeatMapData { Amount = 32560, Products = "Energy Drinks", Month = "February" });
            heatmapData.Add(new HeatMapData { Amount = 41250, Products = "Energy Drinks", Month = "March" });
            heatmapData.Add(new HeatMapData { Amount = 57400, Products = "Energy Drinks", Month = "April" });
            heatmapData.Add(new HeatMapData { Amount = 63500, Products = "Energy Drinks", Month = "May" });
            heatmapData.Add(new HeatMapData { Amount = 59000, Products = "Energy Drinks", Month = "June" });
            heatmapData.Add(new HeatMapData { Amount = 55400, Products = "Energy Drinks", Month = "July" });
            heatmapData.Add(new HeatMapData { Amount = 40025, Products = "Energy Drinks", Month = "August" });
            heatmapData.Add(new HeatMapData { Amount = 47500, Products = "Energy Drinks", Month = "September" });
            heatmapData.Add(new HeatMapData { Amount = 37400, Products = "Energy Drinks", Month = "October" });
            heatmapData.Add(new HeatMapData { Amount = 51200, Products = "Energy Drinks", Month = "November" });
            heatmapData.Add(new HeatMapData { Amount = 59750, Products = "Energy Drinks", Month = "December" });
            heatmapData.Add(new HeatMapData { Amount = 34250, Products = "Biscuits", Month = "January" });
            heatmapData.Add(new HeatMapData { Amount = 44250, Products = "Biscuits", Month = "February" });
            heatmapData.Add(new HeatMapData { Amount = 52500, Products = "Biscuits", Month = "March" });
            heatmapData.Add(new HeatMapData { Amount = 38500, Products = "Biscuits", Month = "April" });
            heatmapData.Add(new HeatMapData { Amount = 57500, Products = "Biscuits", Month = "May" });
            heatmapData.Add(new HeatMapData { Amount = 45750, Products = "Biscuits", Month = "June" });
            heatmapData.Add(new HeatMapData { Amount = 65000, Products = "Biscuits", Month = "July" });
            heatmapData.Add(new HeatMapData { Amount = 33500, Products = "Biscuits", Month = "August" });
            heatmapData.Add(new HeatMapData { Amount = 41750, Products = "Biscuits", Month = "September" });
            heatmapData.Add(new HeatMapData { Amount = 39400, Products = "Biscuits", Month = "October" });
            heatmapData.Add(new HeatMapData { Amount = 50450, Products = "Biscuits", Month = "November" });
            heatmapData.Add(new HeatMapData { Amount = 43000, Products = "Biscuits", Month = "December" });
            heatmapData.Add(new HeatMapData { Amount = 35600, Products = "Bread", Month = "January" });
            heatmapData.Add(new HeatMapData { Amount = 42300, Products = "Bread", Month = "February" });
            heatmapData.Add(new HeatMapData { Amount = 51700, Products = "Bread", Month = "March" });
            heatmapData.Add(new HeatMapData { Amount = 59800, Products = "Bread", Month = "April" });
            heatmapData.Add(new HeatMapData { Amount = 34275, Products = "Bread", Month = "May" });
            heatmapData.Add(new HeatMapData { Amount = 64500, Products = "Bread", Month = "June" });
            heatmapData.Add(new HeatMapData { Amount = 43000, Products = "Bread", Month = "July" });
            heatmapData.Add(new HeatMapData { Amount = 63000, Products = "Bread", Month = "August" });
            heatmapData.Add(new HeatMapData { Amount = 55000, Products = "Bread", Month = "September" });
            heatmapData.Add(new HeatMapData { Amount = 32500, Products = "Bread", Month = "October" });
            heatmapData.Add(new HeatMapData { Amount = 34899, Products = "Bread", Month = "November" });
            heatmapData.Add(new HeatMapData { Amount = 55030, Products = "Bread", Month = "December" });
            heatmapData.Add(new HeatMapData { Amount = 64500, Products = "Nutella", Month = "January" });
            heatmapData.Add(new HeatMapData { Amount = 33400, Products = "Nutella", Month = "February" });
            heatmapData.Add(new HeatMapData { Amount = 58700, Products = "Nutella", Month = "March" });
            heatmapData.Add(new HeatMapData { Amount = 35700, Products = "Nutella", Month = "April" });
            heatmapData.Add(new HeatMapData { Amount = 63050, Products = "Nutella", Month = "May" });
            heatmapData.Add(new HeatMapData { Amount = 52500, Products = "Nutella", Month = "June" });
            heatmapData.Add(new HeatMapData { Amount = 40500, Products = "Nutella", Month = "July" });
            heatmapData.Add(new HeatMapData { Amount = 37500, Products = "Nutella", Month = "August" });
            heatmapData.Add(new HeatMapData { Amount = 57500, Products = "Nutella", Month = "September" });
            heatmapData.Add(new HeatMapData { Amount = 42500, Products = "Nutella", Month = "October" });
            heatmapData.Add(new HeatMapData { Amount = 62050, Products = "Nutella", Month = "November" });
            heatmapData.Add(new HeatMapData { Amount = 34000, Products = "Nutella", Month = "December" });
            heatmapData.Add(new HeatMapData { Amount = 32000, Products = "Jam", Month = "January" });
            heatmapData.Add(new HeatMapData { Amount = 33400, Products = "Jam", Month = "February" });
            heatmapData.Add(new HeatMapData { Amount = 39500, Products = "Jam", Month = "March" });
            heatmapData.Add(new HeatMapData { Amount = 42500, Products = "Jam", Month = "April" });
            heatmapData.Add(new HeatMapData { Amount = 40500, Products = "Jam", Month = "May" });
            heatmapData.Add(new HeatMapData { Amount = 57500, Products = "Jam", Month = "June" });
            heatmapData.Add(new HeatMapData { Amount = 60500, Products = "Jam", Month = "July" });
            heatmapData.Add(new HeatMapData { Amount = 62500, Products = "Jam", Month = "August" });
            heatmapData.Add(new HeatMapData { Amount = 64250, Products = "Jam", Month = "September" });
            heatmapData.Add(new HeatMapData { Amount = 52500, Products = "Jam", Month = "October" });
            heatmapData.Add(new HeatMapData { Amount = 48500, Products = "Jam", Month = "November" });
            heatmapData.Add(new HeatMapData { Amount = 57500, Products = "Jam", Month = "December" });
            return heatmapData;
        }
        public class RData
        {
            public string Date { get; set; }
            public string Sector { get; set; }
            public string EnerType { get; set; }
            public string EneSource { get; set; }
            public int PowUnits { get; set; }
            public int ProCost { get; set; }
            public string Year { get; set; }
            public string Quarter { get; set; }
            public string HalfYear { get; set; }
        }

        public class RenewableData
        {
            public string Sector { get; set; }
            public string EnerType { get; set; }
            public string EneSource { get; set; }
            public int PowUnits { get; set; }
            public int ProCost { get; set; }
            public string Year { get; set; }
            public string Quarter { get; set; }
            public string HalfYear { get; set; }
        }

        public class Pivot_Data
        {
            public int In_Stock { get; set; }
            public int Sold { get; set; }
            public double Amount { get; set; }
            public string Country { get; set; }
            public string Product_Categories { get; set; }
            public string Products { get; set; }
            public string Order_Source { get; set; }
            public string Year { get; set; }
            public string Quarter { get; set; }
        }

        public class DefaultData
        {
            public int Sold { get; set; }
            public double Amount { get; set; }
            public string Country { get; set; }
            public string Products { get; set; }
            public string Year { get; set; }
            public string Quarter { get; set; }
        }
        public class HeatMapData
        {
            public double Amount { get; set; }
            public string Products { get; set; }
            public string Month { get; set; }
        }
    }
}
