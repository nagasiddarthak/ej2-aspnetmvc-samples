var dataCollection = [
    { xDate: new Date('2013-01-01'), Open: 85.79, High: 85.89, Low: 85.36, Close: 85.54 },
    { xDate: new Date('2013-01-03'), Open: 85.83, High: 85.85, Low: 85.55, Close: 85.64 },
    { xDate: new Date('2013-01-05'), Open: 86.19, High: 86.25, Low: 85.8, Close: 85.98 },
    { xDate: new Date('2013-01-07'), Open: 86.17, High: 86.28, Low: 85.96, Close: 86.07 },
    { xDate: new Date('2013-01-09'), Open: 86.19, High: 86.26, Low: 85.97, Close: 86.2 },
    { xDate: new Date('2013-01-11'), Open: 85.98, High: 86.31, Low: 85.86, Close: 86.15 },
    { xDate: new Date('2013-01-13'), Open: 85.82, High: 86.18, Low: 85.74, Close: 85.78 },
    { xDate: new Date('2013-01-15'), Open: 85.45, High: 85.66, Low: 85.41, Close: 85.55 },
    { xDate: new Date('2013-01-17'), Open: 85.53, High: 85.53, Low: 85.31, Close: 85.48 },
    { xDate: new Date('2013-01-19'), Open: 85.6, High: 85.68, Low: 85.34, Close: 85.39 },
    { xDate: new Date('2013-01-21'), Open: 85.6, High: 85.72, Low: 85.5, Close: 85.61 },
    { xDate: new Date('2013-01-23'), Open: 85.34, High: 85.52, Low: 85.3, Close: 85.49 },
    { xDate: new Date('2013-01-25'), Open: 85.66, High: 85.72, Low: 85.38, Close: 85.41 },
    { xDate: new Date('2013-01-27'), Open: 85.93, High: 85.95, Low: 85.59, Close: 85.62 },
    { xDate: new Date('2013-01-29'), Open: 85.91, High: 85.93, Low: 85.63, Close: 85.58 },
    { xDate: new Date('2013-02-01'), Open: 85.85, High: 86.25, Low: 85.79, Close: 86.06 },
    { xDate: new Date('2013-02-03'), Open: 85.6, High: 85.85, Low: 85.49, Close: 85.81 },
    { xDate: new Date('2013-02-05'), Open: 85.94, High: 86, Low: 85.48, Close: 85.66 },
    { xDate: new Date('2013-02-07'), Open: 86.55, High: 86.64, Low: 85.36, Close: 85.92 },
    { xDate: new Date('2013-02-09'), Open: 86.46, High: 86.87, Low: 86.4, Close: 86.71 },
    { xDate: new Date('2013-02-11'), Open: 86.3, High: 86.39, Low: 86.13, Close: 86.38 },
    { xDate: new Date('2013-02-13'), Open: 85.74, High: 86.44, Low: 85.67, Close: 86.19 },
    { xDate: new Date('2013-02-15'), Open: 85.56, High: 85.62, Low: 85.34, Close: 85.61 },
    { xDate: new Date('2013-02-17'), Open: 85.79, High: 85.89, Low: 85.36, Close: 85.52 },
    { xDate: new Date('2013-02-19'), Open: 85.54, High: 86, Low: 85.51, Close: 85.76 },
    { xDate: new Date('2013-02-21'), Open: 85, High: 85.17, Low: 84.87, Close: 85.15 },
    { xDate: new Date('2013-02-23'), Open: 85.1, High: 85.28, Low: 84.72, Close: 85.08 },
    { xDate: new Date('2013-02-25'), Open: 85.46, High: 85.56, Low: 85.18, Close: 85.37 },
    { xDate: new Date('2013-02-27'), Open: 85.42, High: 85.44, Low: 85.09, Close: 85.42 },
    { xDate: new Date('2013-03-01'), Open: 85.79, High: 85.89, Low: 85.36, Close: 85.54 },
    { xDate: new Date('2013-03-03'), Open: 85.83, High: 85.85, Low: 85.55, Close: 85.64 },
    { xDate: new Date('2013-03-05'), Open: 86.19, High: 86.25, Low: 85.8, Close: 85.98 },
    { xDate: new Date('2013-03-07'), Open: 86.17, High: 86.28, Low: 85.96, Close: 86.07 },
    { xDate: new Date('2013-03-09'), Open: 86.19, High: 86.26, Low: 85.97, Close: 86.2 },
    { xDate: new Date('2013-03-11'), Open: 85.98, High: 86.31, Low: 85.86, Close: 86.15 },
    { xDate: new Date('2013-03-13'), Open: 85.82, High: 86.18, Low: 85.74, Close: 85.78 },
    { xDate: new Date('2013-03-15'), Open: 85.45, High: 85.66, Low: 85.41, Close: 85.55 },
    { xDate: new Date('2013-03-17'), Open: 85.53, High: 85.53, Low: 85.31, Close: 85.48 },
    { xDate: new Date('2013-03-19'), Open: 85.6, High: 85.68, Low: 85.34, Close: 85.39 },
    { xDate: new Date('2013-03-21'), Open: 85.6, High: 85.72, Low: 85.5, Close: 85.61 },
    { xDate: new Date('2013-03-23'), Open: 85.34, High: 85.52, Low: 85.3, Close: 85.49 },
    { xDate: new Date('2013-03-25'), Open: 85.66, High: 85.72, Low: 85.38, Close: 85.41 },
    { xDate: new Date('2013-03-27'), Open: 85.93, High: 85.95, Low: 85.59, Close: 85.62 },
    { xDate: new Date('2013-03-29'), Open: 85.91, High: 85.93, Low: 85.63, Close: 85.58 },
    { xDate: new Date('2013-04-01'), Open: 86.1, High: 86.15, Low: 85.9, Close: 86.03 },
    { xDate: new Date('2013-04-03'), Open: 85.93, High: 86.17, Low: 85.84, Close: 86.02 },
    { xDate: new Date('2013-04-05'), Open: 85.74, High: 86, Low: 85.66, Close: 86 },
    { xDate: new Date('2013-04-07'), Open: 85.71, High: 85.71, Low: 85.36, Close: 85.62 },
    { xDate: new Date('2013-04-09'), Open: 85.3, High: 85.92, Low: 85.16, Close: 85.8 },
    { xDate: new Date('2013-04-11'), Open: 84.23, High: 85.46, Low: 84.23, Close: 85.2 },
    { xDate: new Date('2013-04-13'), Open: 84.51, High: 84.54, Low: 84.19, Close: 84.3 },
    { xDate: new Date('2013-04-15'), Open: 84.44, High: 84.65, Low: 84.2, Close: 84.63 },
    { xDate: new Date('2013-04-17'), Open: 84.6, High: 84.81, Low: 84.59, Close: 84.65 },
    { xDate: new Date('2013-04-19'), Open: 84.52, High: 84.86, Low: 84.4, Close: 84.76 },
    { xDate: new Date('2013-04-21'), Open: 84.17, High: 84.66, Low: 84.16, Close: 84.47 },
    { xDate: new Date('2013-04-23'), Open: 84.22, High: 84.3, Low: 83.98, Close: 84.26 },
    { xDate: new Date('2013-04-25'), Open: 83.75, High: 84.1, Low: 83.65, Close: 84 },
    { xDate: new Date('2013-04-27'), Open: 84, High: 84.01, Low: 83.67, Close: 83.74 },
    { xDate: new Date('2013-04-29'), Open: 84, High: 84.01, Low: 83.67, Close: 83.74 },
    { xDate: new Date('2013-05-01'), Open: 84.3, High: 84.45, Low: 84.19, Close: 84.22 },
    { xDate: new Date('2013-05-03'), Open: 83.79, High: 84.19, Low: 83.7, Close: 84.04 },
    { xDate: new Date('2013-05-05'), Open: 84.02, High: 84.02, Low: 83.69, Close: 83.71 },
    { xDate: new Date('2013-05-07'), Open: 84.01, High: 84.04, Low: 83.82, Close: 83.96 },
    { xDate: new Date('2013-05-09'), Open: 83.9, High: 84.02, Low: 83.86, Close: 83.94 },
    { xDate: new Date('2013-05-11'), Open: 84.09, High: 84.17, Low: 83.9, Close: 84.06 },
    { xDate: new Date('2013-05-13'), Open: 83.89, High: 84.25, Low: 83.77, Close: 84.01 },
    { xDate: new Date('2013-05-15'), Open: 84.05, High: 84.14, Low: 83.84, Close: 83.91 },
    { xDate: new Date('2013-05-17'), Open: 84.49, High: 84.65, Low: 84.18, Close: 84.22 },
    { xDate: new Date('2013-05-19'), Open: 84.99, High: 85.1, Low: 84.37, Close: 84.43 },
    { xDate: new Date('2013-05-21'), Open: 84.96, High: 85.06, Low: 84.7, Close: 85.01 },
    { xDate: new Date('2013-05-23'), Open: 84.68, High: 84.9, Low: 84.65, Close: 84.76 },
    { xDate: new Date('2013-05-25'), Open: 84.35, High: 85.03, Low: 84.32, Close: 84.67 },
    { xDate: new Date('2013-05-27'), Open: 84.19, High: 84.31, Low: 84.16, Close: 84.19 },
    { xDate: new Date('2013-05-29'), Open: 84.19, High: 84.31, Low: 84.16, Close: 84.19 },
    { xDate: new Date('2013-06-01'), Open: 84.2, High: 84.29, Low: 84.04, Close: 84.15 },
    { xDate: new Date('2013-06-03'), Open: 84.21, High: 84.25, Low: 84.03, Close: 84.17 },
    { xDate: new Date('2013-06-05'), Open: 84.72, High: 84.87, Low: 84.44, Close: 84.49 },
    { xDate: new Date('2013-06-07'), Open: 84.85, High: 84.88, Low: 84.5, Close: 84.72 },
    { xDate: new Date('2013-06-09'), Open: 84.53, High: 84.74, Low: 84.25, Close: 84.69 },
    { xDate: new Date('2013-06-11'), Open: 84.4, High: 84.7, Low: 84.27, Close: 84.52 },
    { xDate: new Date('2013-06-13'), Open: 84.96, High: 85.07, Low: 84.5, Close: 84.57 },
    { xDate: new Date('2013-06-15'), Open: 85.28, High: 85.32, Low: 84.95, Close: 85.03 },
    { xDate: new Date('2013-06-17'), Open: 85.35, High: 85.39, Low: 85.1, Close: 85.32 },
    { xDate: new Date('2013-06-19'), Open: 85.65, High: 85.66, Low: 85.21, Close: 85.36 },
    { xDate: new Date('2013-06-21'), Open: 85.38, High: 85.85, Low: 85.25, Close: 85.67 },
    { xDate: new Date('2013-06-23'), Open: 85.8, High: 85.96, Low: 85.67, Close: 85.83 },
    { xDate: new Date('2013-06-25'), Open: 86.07, High: 86.22, Low: 85.75, Close: 85.87 },
    { xDate: new Date('2013-06-27'), Open: 86.05, High: 86.08, Low: 85.68, Close: 85.79 },
    { xDate: new Date('2013-06-29'), Open: 86.05, High: 86.08, Low: 85.68, Close: 85.79 },
    { xDate: new Date('2013-07-01'), Open: 85.85, High: 86.25, Low: 85.79, Close: 86.06 },
    { xDate: new Date('2013-07-03'), Open: 85.6, High: 85.85, Low: 85.49, Close: 85.81 },
    { xDate: new Date('2013-07-05'), Open: 85.94, High: 86, Low: 85.48, Close: 85.66 },
    { xDate: new Date('2013-07-07'), Open: 86.55, High: 86.64, Low: 85.36, Close: 85.92 },
    { xDate: new Date('2013-07-09'), Open: 86.46, High: 86.87, Low: 86.4, Close: 86.71 },
    { xDate: new Date('2013-07-11'), Open: 86.3, High: 86.39, Low: 86.13, Close: 86.38 },
    { xDate: new Date('2013-07-13'), Open: 85.74, High: 86.44, Low: 85.67, Close: 86.19 },
    { xDate: new Date('2013-07-15'), Open: 85.56, High: 85.62, Low: 85.34, Close: 85.61 },
    { xDate: new Date('2013-07-17'), Open: 85.79, High: 85.89, Low: 85.36, Close: 85.52 },
    { xDate: new Date('2013-07-19'), Open: 85.54, High: 86, Low: 85.51, Close: 85.76 },
    { xDate: new Date('2013-07-21'), Open: 85, High: 85.17, Low: 84.87, Close: 85.15 },
    { xDate: new Date('2013-07-23'), Open: 85.1, High: 85.28, Low: 84.72, Close: 85.08 },
    { xDate: new Date('2013-07-25'), Open: 85.46, High: 85.56, Low: 85.18, Close: 85.37 },
    { xDate: new Date('2013-07-27'), Open: 85.42, High: 85.44, Low: 85.09, Close: 85.42 },
    { xDate: new Date('2013-07-29'), Open: 85.42, High: 85.44, Low: 85.09, Close: 85.42 },
    { xDate: new Date('2013-08-01'), Open: 85.79, High: 85.89, Low: 85.36, Close: 85.54 },
    { xDate: new Date('2013-08-03'), Open: 85.83, High: 85.85, Low: 85.55, Close: 85.64 },
    { xDate: new Date('2013-08-05'), Open: 86.19, High: 86.25, Low: 85.8, Close: 85.98 },
    { xDate: new Date('2013-08-07'), Open: 86.17, High: 86.28, Low: 85.96, Close: 86.07 },
    { xDate: new Date('2013-08-09'), Open: 86.19, High: 86.26, Low: 85.97, Close: 86.2 },
    { xDate: new Date('2013-08-11'), Open: 85.98, High: 86.31, Low: 85.86, Close: 86.15 },
    { xDate: new Date('2013-08-13'), Open: 85.82, High: 86.18, Low: 85.74, Close: 85.78 },
    { xDate: new Date('2013-08-15'), Open: 85.45, High: 85.66, Low: 85.41, Close: 85.55 },
    { xDate: new Date('2013-08-17'), Open: 85.53, High: 85.53, Low: 85.31, Close: 85.48 },
    { xDate: new Date('2013-08-19'), Open: 85.6, High: 85.68, Low: 85.34, Close: 85.39 },
    { xDate: new Date('2013-08-21'), Open: 85.6, High: 85.72, Low: 85.5, Close: 85.61 },
    { xDate: new Date('2013-08-23'), Open: 85.34, High: 85.52, Low: 85.3, Close: 85.49 },
    { xDate: new Date('2013-08-25'), Open: 85.66, High: 85.72, Low: 85.38, Close: 85.41 },
    { xDate: new Date('2013-08-27'), Open: 85.93, High: 85.95, Low: 85.59, Close: 85.62 },
    { xDate: new Date('2013-08-29'), Open: 85.91, High: 85.93, Low: 85.63, Close: 85.58 },
    { xDate: new Date('2013-09-01'), Open: 86.1, High: 86.15, Low: 85.9, Close: 86.03 },
    { xDate: new Date('2013-09-03'), Open: 85.93, High: 86.17, Low: 85.84, Close: 86.02 },
    { xDate: new Date('2013-09-05'), Open: 85.74, High: 86, Low: 85.66, Close: 86 },
    { xDate: new Date('2013-09-07'), Open: 85.71, High: 85.71, Low: 85.36, Close: 85.62 },
    { xDate: new Date('2013-09-09'), Open: 85.3, High: 85.92, Low: 85.16, Close: 85.8 },
    { xDate: new Date('2013-09-11'), Open: 84.23, High: 85.46, Low: 84.23, Close: 85.2 },
    { xDate: new Date('2013-09-13'), Open: 84.51, High: 84.54, Low: 84.19, Close: 84.3 },
    { xDate: new Date('2013-09-15'), Open: 84.44, High: 84.65, Low: 84.2, Close: 84.63 },
    { xDate: new Date('2013-09-17'), Open: 84.6, High: 84.81, Low: 84.59, Close: 84.65 },
    { xDate: new Date('2013-09-19'), Open: 84.52, High: 84.86, Low: 84.4, Close: 84.76 },
    { xDate: new Date('2013-09-21'), Open: 84.17, High: 84.66, Low: 84.16, Close: 84.47 },
    { xDate: new Date('2013-09-23'), Open: 84.22, High: 84.3, Low: 83.98, Close: 84.26 },
    { xDate: new Date('2013-09-25'), Open: 83.75, High: 84.1, Low: 83.65, Close: 84 },
    { xDate: new Date('2013-09-27'), Open: 84, High: 84.01, Low: 83.67, Close: 83.74 },
    { xDate: new Date('2013-09-29'), Open: 84, High: 84.01, Low: 83.67, Close: 83.74 },
    { xDate: new Date('2013-10-01'), Open: 84.3, High: 84.45, Low: 84.19, Close: 84.22 },
    { xDate: new Date('2013-10-03'), Open: 83.79, High: 84.19, Low: 83.7, Close: 84.04 },
    { xDate: new Date('2013-10-05'), Open: 84.02, High: 84.02, Low: 83.69, Close: 83.71 },
    { xDate: new Date('2013-10-07'), Open: 84.01, High: 84.04, Low: 83.82, Close: 83.96 },
    { xDate: new Date('2013-10-09'), Open: 83.9, High: 84.02, Low: 83.86, Close: 83.94 },
    { xDate: new Date('2013-10-11'), Open: 84.09, High: 84.17, Low: 83.9, Close: 84.06 },
    { xDate: new Date('2013-10-13'), Open: 83.89, High: 84.25, Low: 83.77, Close: 84.01 },
    { xDate: new Date('2013-10-15'), Open: 84.05, High: 84.14, Low: 83.84, Close: 83.91 },
    { xDate: new Date('2013-10-17'), Open: 84.49, High: 84.65, Low: 84.18, Close: 84.22 },
    { xDate: new Date('2013-10-19'), Open: 84.99, High: 85.1, Low: 84.37, Close: 84.43 },
    { xDate: new Date('2013-10-21'), Open: 84.96, High: 85.06, Low: 84.7, Close: 85.01 },
    { xDate: new Date('2013-10-23'), Open: 84.68, High: 84.9, Low: 84.65, Close: 84.76 },
    { xDate: new Date('2013-10-25'), Open: 84.35, High: 85.03, Low: 84.32, Close: 84.67 },
    { xDate: new Date('2013-10-27'), Open: 84.19, High: 84.31, Low: 84.16, Close: 84.19 },
    { xDate: new Date('2013-10-29'), Open: 84.19, High: 84.31, Low: 84.16, Close: 84.19 },
    { xDate: new Date('2013-11-01'), Open: 84.2, High: 84.29, Low: 84.04, Close: 84.15 },
    { xDate: new Date('2013-11-03'), Open: 84.21, High: 84.25, Low: 84.03, Close: 84.17 },
    { xDate: new Date('2013-11-05'), Open: 84.72, High: 84.87, Low: 84.44, Close: 84.49 },
    { xDate: new Date('2013-11-07'), Open: 84.85, High: 84.88, Low: 84.5, Close: 84.72 },
    { xDate: new Date('2013-11-09'), Open: 84.53, High: 84.74, Low: 84.25, Close: 84.69 },
    { xDate: new Date('2013-11-11'), Open: 84.4, High: 84.7, Low: 84.27, Close: 84.52 },
    { xDate: new Date('2013-11-13'), Open: 84.96, High: 85.07, Low: 84.5, Close: 84.57 },
    { xDate: new Date('2013-11-15'), Open: 85.28, High: 85.32, Low: 84.95, Close: 85.03 },
    { xDate: new Date('2013-11-17'), Open: 85.35, High: 85.39, Low: 85.1, Close: 85.32 },
    { xDate: new Date('2013-11-19'), Open: 85.65, High: 85.66, Low: 85.21, Close: 85.36 },
    { xDate: new Date('2013-11-21'), Open: 85.38, High: 85.85, Low: 85.25, Close: 85.67 },
    { xDate: new Date('2013-11-23'), Open: 85.8, High: 85.96, Low: 85.67, Close: 85.83 },
    { xDate: new Date('2013-11-25'), Open: 86.07, High: 86.22, Low: 85.75, Close: 85.87 },
    { xDate: new Date('2013-11-27'), Open: 86.05, High: 86.08, Low: 85.68, Close: 85.79 },
    { xDate: new Date('2013-11-29'), Open: 86.05, High: 86.08, Low: 85.68, Close: 85.79 },
    { xDate: new Date('2013-12-01'), Open: 85.85, High: 86.25, Low: 85.79, Close: 86.06 },
    { xDate: new Date('2013-12-03'), Open: 85.6, High: 85.85, Low: 85.49, Close: 85.81 },
    { xDate: new Date('2013-12-05'), Open: 85.94, High: 86, Low: 85.48, Close: 85.66 },
    { xDate: new Date('2013-12-07'), Open: 86.55, High: 86.64, Low: 85.36, Close: 85.92 },
    { xDate: new Date('2013-12-09'), Open: 86.46, High: 86.87, Low: 86.4, Close: 86.71 },
    { xDate: new Date('2013-12-11'), Open: 86.3, High: 86.39, Low: 86.13, Close: 86.38 },
    { xDate: new Date('2013-12-13'), Open: 85.74, High: 86.44, Low: 85.67, Close: 86.19 },
    { xDate: new Date('2013-12-15'), Open: 85.56, High: 85.62, Low: 85.34, Close: 85.61 },
    { xDate: new Date('2013-12-17'), Open: 85.79, High: 85.89, Low: 85.36, Close: 85.52 },
    { xDate: new Date('2013-12-19'), Open: 85.54, High: 86, Low: 85.51, Close: 85.76 },
    { xDate: new Date('2013-12-21'), Open: 85, High: 85.17, Low: 84.87, Close: 85.15 },
    { xDate: new Date('2013-12-23'), Open: 85.1, High: 85.28, Low: 84.72, Close: 85.08 },
    { xDate: new Date('2013-12-25'), Open: 85.46, High: 85.56, Low: 85.18, Close: 85.37 },
    { xDate: new Date('2013-12-27'), Open: 85.42, High: 85.44, Low: 85.09, Close: 85.42 },
    { xDate: new Date('2013-12-29'), Open: 85.42, High: 85.44, Low: 85.09, Close: 85.42 }
];
var bitCoinData = [
    { x: new Date('2017-05-01'), y: 1402.08 },
        { x: new Date('2017-05-02'), y: 1443.68 },
        { x: new Date('2017-05-03'), y: 1492 },
        { x: new Date('2017-05-04'), y: 1515.63 },
        { x: new Date('2017-05-05'), y: 1512.21 },
        { x: new Date('2017-05-06'), y: 1548.29 },
        { x: new Date('2017-05-07'), y: 1555.47 },
        { x: new Date('2017-05-08'), y: 1639.32 },
        { x: new Date('2017-05-09'), y: 1706.93 },
        { x: new Date('2017-05-10'), y: 1756.8 },
        { x: new Date('2017-05-11'), y: 1807.37 },
        { x: new Date('2017-05-12'), y: 1676.99 },
        { x: new Date('2017-05-13'), y: 1759.96 },
        { x: new Date('2017-05-14'), y: 1772.42 },
        { x: new Date('2017-05-15'), y: 1697.38 },
        { x: new Date('2017-05-16'), y: 1718.2 },
        { x: new Date('2017-05-17'), y: 1802.16 },
        { x: new Date('2017-05-18'), y: 1887.33 },
        { x: new Date('2017-05-19'), y: 1968.1 },
        { x: new Date('2017-05-20'), y: 2051.73 },
        { x: new Date('2017-05-21'), y: 2055.62 },
        { x: new Date('2017-05-22'), y: 2139.03 },
        { x: new Date('2017-05-23'), y: 2291.48 },
        { x: new Date('2017-05-24'), y: 2476.3 },
        { x: new Date('2017-05-25'), y: 2357.5 },
        { x: new Date('2017-05-26'), y: 2247.48 },
        { x: new Date('2017-05-27'), y: 2106.31 },
        { x: new Date('2017-05-28'), y: 2207.58 },
        { x: new Date('2017-05-29'), y: 2289.87 },
        { x: new Date('2017-05-30'), y: 2197.23 },
        { x: new Date('2017-05-31'), y: 2330.23 },
        { x: new Date('2017-06-01'), y: 2452.18 },
        { x: new Date('2017-06-02'), y: 2517.41 },
        { x: new Date('2017-06-03'), y: 2555.65 },
        { x: new Date('2017-06-04'), y: 2552.81 },
        { x: new Date('2017-06-05'), y: 2736.59 },
        { x: new Date('2017-06-06'), y: 2914.08 },
        { x: new Date('2017-06-07'), y: 2694.22 },
        { x: new Date('2017-06-08'), y: 2825.03 },
        { x: new Date('2017-06-09'), y: 2826.7 },
        { x: new Date('2017-06-10'), y: 2942.34 },
        { x: new Date('2017-06-11'), y: 3018.54 },
        { x: new Date('2017-06-12'), y: 2682.59 },
        { x: new Date('2017-06-13'), y: 2738.93 },
        { x: new Date('2017-06-14'), y: 2494.48 },
        { x: new Date('2017-06-15'), y: 2456.92 },
        { x: new Date('2017-06-16'), y: 2528.1 },
        { x: new Date('2017-06-17'), y: 2664 },
        { x: new Date('2017-06-18'), y: 2576.17 },
        { x: new Date('2017-06-19'), y: 2641.66 },
        { x: new Date('2017-06-20'), y: 2778.83 },
        { x: new Date('2017-06-21'), y: 2712.16 },
        { x: new Date('2017-06-22'), y: 2740.79 },
        { x: new Date('2017-06-23'), y: 2738.22 },
        { x: new Date('2017-06-24'), y: 2619.12 },
        { x: new Date('2017-06-25'), y: 2594.45 },
        { x: new Date('2017-06-26'), y: 2485.36 },
        { x: new Date('2017-06-27'), y: 2593.17 },
        { x: new Date('2017-06-28'), y: 2584.56 },
        { x: new Date('2017-06-29'), y: 2561.56 },
        { x: new Date('2017-06-30'), y: 2499.98 },
        { x: new Date('2017-07-01'), y: 2460.2 },
        { x: new Date('2017-07-02'), y: 2529.78 },
        { x: new Date('2017-07-03'), y: 2581.07 },
        { x: new Date('2017-07-04'), y: 2625.07 },
        { x: new Date('2017-07-05'), y: 2629.27 },
        { x: new Date('2017-07-06'), y: 2619.11 },
        { x: new Date('2017-07-07'), y: 2521.24 },
        { x: new Date('2017-07-08'), y: 2579.93 },
        { x: new Date('2017-07-09'), y: 2525.67 },
        { x: new Date('2017-07-10'), y: 2371.96 },
        { x: new Date('2017-07-11'), y: 2332.19 },
        { x: new Date('2017-07-12'), y: 2423.16 },
        { x: new Date('2017-07-13'), y: 2364.52 },
        { x: new Date('2017-07-14'), y: 2232.65 },
        { x: new Date('2017-07-15'), y: 1993.26 },
        { x: new Date('2017-07-16'), y: 1938.94 },
        { x: new Date('2017-07-17'), y: 2244.26 },
        { x: new Date('2017-07-18'), y: 2327.9 },
        { x: new Date('2017-07-19'), y: 2294.4 },
        { x: new Date('2017-07-20'), y: 2877.39 },
        { x: new Date('2017-07-21'), y: 2694.29 },
        { x: new Date('2017-07-22'), y: 2838.81 },
        { x: new Date('2017-07-23'), y: 2762.63 },
        { x: new Date('2017-07-24'), y: 2779.04 },
        { x: new Date('2017-07-25'), y: 2591.22 },
        { x: new Date('2017-07-26'), y: 2550.18 },
        { x: new Date('2017-07-27'), y: 2697.47 },
        { x: new Date('2017-07-28'), y: 2805.18 },
        { x: new Date('2017-07-29'), y: 2720.08 },
        { x: new Date('2017-07-30'), y: 2746.33 },
        { x: new Date('2017-07-31'), y: 2873.83 },
        { x: new Date('2017-08-01'), y: 2735.59 },
        { x: new Date('2017-08-02'), y: 2723.58 },
        { x: new Date('2017-08-03'), y: 2814.36 },
        { x: new Date('2017-08-04'), y: 2883.68 },
        { x: new Date('2017-08-05'), y: 3301.76 },
        { x: new Date('2017-08-06'), y: 3255 },
        { x: new Date('2017-08-07'), y: 3431.97 },
        { x: new Date('2017-08-08'), y: 3453.16 },
        { x: new Date('2017-08-09'), y: 3377.54 },
        { x: new Date('2017-08-10'), y: 3445.28 },
        { x: new Date('2017-08-11'), y: 3679.61 },
        { x: new Date('2017-08-12'), y: 3917.65 },
        { x: new Date('2017-08-13'), y: 4111.2 },
        { x: new Date('2017-08-14'), y: 4382.74 },
        { x: new Date('2017-08-15'), y: 4204.43 },
        { x: new Date('2017-08-16'), y: 4425.3 },
        { x: new Date('2017-08-17'), y: 4316.34 },
        { x: new Date('2017-08-18'), y: 4159.46 },
        { x: new Date('2017-08-19'), y: 4206.13 },
        { x: new Date('2017-08-20'), y: 4111.22 },
        { x: new Date('2017-08-21'), y: 4054.94 },
        { x: new Date('2017-08-22'), y: 4137.67 },
        { x: new Date('2017-08-23'), y: 4191.22 },
        { x: new Date('2017-08-24'), y: 4362.47 },
        { x: new Date('2017-08-25'), y: 4408.32 },
        { x: new Date('2017-08-26'), y: 4387.46 },
        { x: new Date('2017-08-27'), y: 4394.51 },
        { x: new Date('2017-08-28'), y: 4439.66 },
        { x: new Date('2017-08-29'), y: 4648.13 },
        { x: new Date('2017-08-30'), y: 4630.73 },
        { x: new Date('2017-08-31'), y: 4764.87 },
        { x: new Date('2017-09-01'), y: 4950.72 },
        { x: new Date('2017-09-02'), y: 4643.97 },
        { x: new Date('2017-09-03'), y: 4631.69 },
        { x: new Date('2017-09-04'), y: 4319.72 },
        { x: new Date('2017-09-05'), y: 4422.12 },
        { x: new Date('2017-09-06'), y: 4626.72 },
        { x: new Date('2017-09-07'), y: 4638.1 },
        { x: new Date('2017-09-08'), y: 4317.54 },
        { x: new Date('2017-09-09'), y: 4291.88 },
        { x: new Date('2017-09-10'), y: 4191.17 },
        { x: new Date('2017-09-11'), y: 4188.84 },
        { x: new Date('2017-09-12'), y: 4148.27 },
        { x: new Date('2017-09-13'), y: 3874.26 },
        { x: new Date('2017-09-14'), y: 3226.41 },
        { x: new Date('2017-09-15'), y: 3686.9 },
        { x: new Date('2017-09-16'), y: 3678.74 },
        { x: new Date('2017-09-17'), y: 3672.57 },
        { x: new Date('2017-09-18'), y: 4067.08 },
        { x: new Date('2017-09-19'), y: 3897 },
        { x: new Date('2017-09-20'), y: 3858.09 },
        { x: new Date('2017-09-21'), y: 3612.68 },
        { x: new Date('2017-09-22'), y: 3603.31 },
        { x: new Date('2017-09-23'), y: 3777.29 },
        { x: new Date('2017-09-24'), y: 3662.12 },
        { x: new Date('2017-09-25'), y: 3927.5 },
        { x: new Date('2017-09-26'), y: 3895.51 },
        { x: new Date('2017-09-27'), y: 4208.56 },
        { x: new Date('2017-09-28'), y: 4185.29 },
        { x: new Date('2017-09-29'), y: 4164.1 },
        { x: new Date('2017-09-30'), y: 4353.05 },
        { x: new Date('2017-10-01'), y: 4394.64 },
        { x: new Date('2017-10-02'), y: 4404.1 },
        { x: new Date('2017-10-03'), y: 4320.09 },
        { x: new Date('2017-10-04'), y: 4225.92 },
        { x: new Date('2017-10-05'), y: 4322.75 },
        { x: new Date('2017-10-06'), y: 4370.24 },
        { x: new Date('2017-10-07'), y: 4437.03 },
        { x: new Date('2017-10-08'), y: 4596.96 },
        { x: new Date('2017-10-09'), y: 4772.97 },
        { x: new Date('2017-10-10'), y: 4754.7 },
        { x: new Date('2017-10-11'), y: 4830.77 },
        { x: new Date('2017-10-12'), y: 5439.13 },
        { x: new Date('2017-10-13'), y: 5640.13 },
        { x: new Date('2017-10-14'), y: 5809.69 },
        { x: new Date('2017-10-15'), y: 5697.39 },
        { x: new Date('2017-10-16'), y: 5754.22 },
        { x: new Date('2017-10-17'), y: 5595.23 },
        { x: new Date('2017-10-18'), y: 5572.2 },
        { x: new Date('2017-10-19'), y: 5699.58 },
        { x: new Date('2017-10-20'), y: 5984.09 },
        { x: new Date('2017-10-21'), y: 6013.23 },
        { x: new Date('2017-10-22'), y: 5984.96 },
        { x: new Date('2017-10-23'), y: 5895.3 },
        { x: new Date('2017-10-24'), y: 5518.85 },
        { x: new Date('2017-10-25'), y: 5733.9 },
        { x: new Date('2017-10-26'), y: 5888.14 },
        { x: new Date('2017-10-27'), y: 5767.68 },
        { x: new Date('2017-10-28'), y: 5732.82 },
        { x: new Date('2017-10-29'), y: 6140.53 },
        { x: new Date('2017-10-30'), y: 6121.8 },
        { x: new Date('2017-10-31'), y: 6447.67 },
        { x: new Date('2017-11-01'), y: 6750.17 },
        { x: new Date('2017-11-02'), y: 7030 },
        { x: new Date('2017-11-03'), y: 7161.45 },
        { x: new Date('2017-11-04'), y: 7387 },
        { x: new Date('2017-11-05'), y: 7382.45 },
        { x: new Date('2017-11-06'), y: 6958.21 },
        { x: new Date('2017-11-07'), y: 7118.8 },
        { x: new Date('2017-11-08'), y: 7458.79 },
        { x: new Date('2017-11-09'), y: 7146.78 },
        { x: new Date('2017-11-10'), y: 6570.31 },
        { x: new Date('2017-11-11'), y: 6337 },
        { x: new Date('2017-11-12'), y: 5857.32 },
        { x: new Date('2017-11-13'), y: 6517.68 },
        { x: new Date('2017-11-14'), y: 6598.77 },
        { x: new Date('2017-11-15'), y: 7279 },
        { x: new Date('2017-11-16'), y: 7843.94 },
        { x: new Date('2017-11-17'), y: 7689.91 },
        { x: new Date('2017-11-18'), y: 7776.94 },
        { x: new Date('2017-11-19'), y: 8033.94 },
        { x: new Date('2017-11-20'), y: 8238.2 },
        { x: new Date('2017-11-21'), y: 8095.59 },
        { x: new Date('2017-11-22'), y: 8230.69 },
        { x: new Date('2017-11-23'), y: 8002.64 },
        { x: new Date('2017-11-24'), y: 8201.46 },
        { x: new Date('2017-11-25'), y: 8763.78 },
        { x: new Date('2017-11-26'), y: 9326.59 },
        { x: new Date('2017-11-27'), y: 9739.05 },
        { x: new Date('2017-11-28'), y: 9908.23 },
        { x: new Date('2017-11-29'), y: 9816.35 },
        { x: new Date('2017-11-30'), y: 9916.54 },
        { x: new Date('2017-12-01'), y: 10859.56 },
        { x: new Date('2017-12-02'), y: 10895.01 },
        { x: new Date('2017-12-03'), y: 11180.89 },
        { x: new Date('2017-12-04'), y: 11616.85 },
        { x: new Date('2017-12-05'), y: 11696.06 },
        { x: new Date('2017-12-06'), y: 13708.99 },
        { x: new Date('2017-12-07'), y: 16858.02 },
        { x: new Date('2017-12-08'), y: 16057.14 },
        { x: new Date('2017-12-09'), y: 14913.4 },
        { x: new Date('2017-12-10'), y: 15036.96 },
        { x: new Date('2017-12-11'), y: 16699.68 },
        { x: new Date('2017-12-12'), y: 17178.1 },
        { x: new Date('2017-12-13'), y: 16407.2 },
        { x: new Date('2017-12-14'), y: 16531.08 },
        { x: new Date('2017-12-15'), y: 17601.94 },
        { x: new Date('2017-12-16'), y: 19343.04 },
        { x: new Date('2017-12-17'), y: 19086.64 },
        { x: new Date('2017-12-18'), y: 18960.52 },
        { x: new Date('2017-12-19'), y: 17608.35 },
        { x: new Date('2017-12-20'), y: 16454.72 },
        { x: new Date('2017-12-21'), y: 15561.05 },
        { x: new Date('2017-12-22'), y: 13857.14 },
        { x: new Date('2017-12-23'), y: 14548.71 },
        { x: new Date('2017-12-24'), y: 13975.44 },
        { x: new Date('2017-12-25'), y: 13917.03 },
        { x: new Date('2017-12-26'), y: 15745.26 },
        { x: new Date('2017-12-27'), y: 15378.28 },
        { x: new Date('2017-12-28'), y: 14428.76 },
        { x: new Date('2017-12-29'), y: 14427.87 },
        { x: new Date('2017-12-30'), y: 12629.81 },
        { x: new Date('2017-12-31'), y: 13860.14 },
        { x: new Date('2018-01-01'), y: 13412.44 },
        { x: new Date('2018-01-02'), y: 14740.76 },
        { x: new Date('2018-01-03'), y: 15134.65 },
        { x: new Date('2018-01-04'), y: 15155.23 },
        { x: new Date('2018-01-05'), y: 16937.17 },
        { x: new Date('2018-01-06'), y: 17135.84 },
        { x: new Date('2018-01-07'), y: 16178.49 },
        { x: new Date('2018-01-08'), y: 14970.36 },
        { x: new Date('2018-01-09'), y: 14439.47 },
        { x: new Date('2018-01-10'), y: 14890.72 },
        { x: new Date('2018-01-11'), y: 13287.26 },
        { x: new Date('2018-01-12'), y: 13812.71 },
        { x: new Date('2018-01-13'), y: 14188.78 },
        { x: new Date('2018-01-14'), y: 13619.03 },
        { x: new Date('2018-01-15'), y: 13585.9 },
        { x: new Date('2018-01-16'), y: 11348.02 },
        { x: new Date('2018-01-17'), y: 11141.25 },
        { x: new Date('2018-01-18'), y: 11250.65 },
        { x: new Date('2018-01-19'), y: 11514.92 },
        { x: new Date('2018-01-20'), y: 12759.64 },
        { x: new Date('2018-01-21'), y: 11522.86 },
        { x: new Date('2018-01-22'), y: 10772.15 },
        { x: new Date('2018-01-23'), y: 10839.83 },
        { x: new Date('2018-01-24'), y: 11399.52 },
        { x: new Date('2018-01-25'), y: 11137.24 },
        { x: new Date('2018-01-26'), y: 11090.06 },
        { x: new Date('2018-01-27'), y: 11407.15 },
        { x: new Date('2018-01-28'), y: 11694.47 },
        { x: new Date('2018-01-29'), y: 11158.39 },
        { x: new Date('2018-01-30'), y: 10035 },
        { x: new Date('2018-01-31'), y: 10166.51 },
        { x: new Date('2018-02-01'), y: 9052.58 },
        { x: new Date('2018-02-02'), y: 8827.63 },
        { x: new Date('2018-02-03'), y: 9224.39 },
        { x: new Date('2018-02-04'), y: 8186.65 },
        { x: new Date('2018-02-05'), y: 6914.26 },
        { x: new Date('2018-02-06'), y: 7700.39 },
        { x: new Date('2018-02-07'), y: 7581.8 },
        { x: new Date('2018-02-08'), y: 8237.24 },
        { x: new Date('2018-02-09'), y: 8689.84 },
        { x: new Date('2018-02-10'), y: 8556.61 },
        { x: new Date('2018-02-11'), y: 8070.8 },
        { x: new Date('2018-02-12'), y: 8891.21 },
        { x: new Date('2018-02-13'), y: 8516.24 },
        { x: new Date('2018-02-14'), y: 9477.84 },
        { x: new Date('2018-02-15'), y: 10016.49 },
        { x: new Date('2018-02-16'), y: 10178.71 },
        { x: new Date('2018-02-17'), y: 11092.15 },
        { x: new Date('2018-02-18'), y: 10396.63 },
        { x: new Date('2018-02-19'), y: 11159.72 },
        { x: new Date('2018-02-20'), y: 11228.24 },
        { x: new Date('2018-02-21'), y: 10456.17 },
        { x: new Date('2018-02-22'), y: 9830.43 },
        { x: new Date('2018-02-23'), y: 10149.46 },
        { x: new Date('2018-02-24'), y: 9682.38 },
        { x: new Date('2018-02-25'), y: 9586.46 },
        { x: new Date('2018-02-26'), y: 10313.08 },
        { x: new Date('2018-02-27'), y: 10564.42 },
        { x: new Date('2018-02-28'), y: 10309.64 },
        { x: new Date('2018-03-01'), y: 10907.59 },
        { x: new Date('2018-03-02'), y: 11019.52 },
        { x: new Date('2018-03-03'), y: 11438.65 },
        { x: new Date('2018-03-04'), y: 11479.73 },
        { x: new Date('2018-03-05'), y: 11432.98 },
        { x: new Date('2018-03-06'), y: 10709.53 },
        { x: new Date('2018-03-07'), y: 9906.8 },
        { x: new Date('2018-03-08'), y: 9299.28 },
        { x: new Date('2018-03-09'), y: 9237.05 },
        { x: new Date('2018-03-10'), y: 8787.16 },
        { x: new Date('2018-03-11'), y: 9532.74 },
        { x: new Date('2018-03-12'), y: 9118.27 },
        { x: new Date('2018-03-13'), y: 9144.15 },
        { x: new Date('2018-03-14'), y: 8196.9 },
        { x: new Date('2018-03-15'), y: 8256.99 },
        { x: new Date('2018-03-16'), y: 8269.33 },
        { x: new Date('2018-03-17'), y: 7862.11 },
        { x: new Date('2018-03-18'), y: 8196.02 },
        { x: new Date('2018-03-19'), y: 8594.19 },
        { x: new Date('2018-03-20'), y: 8915.9 },
        { x: new Date('2018-03-21'), y: 8895.4 },
        { x: new Date('2018-03-22'), y: 8712.89 },
        { x: new Date('2018-03-23'), y: 8918.74 },
        { x: new Date('2018-03-24'), y: 8535.89 },
        { x: new Date('2018-03-25'), y: 8449.83 },
        { x: new Date('2018-03-26'), y: 8138.34 },
        { x: new Date('2018-03-27'), y: 7790.16 },
        { x: new Date('2018-03-28'), y: 7937.2 },
        { x: new Date('2018-03-29'), y: 7086.49 },
        { x: new Date('2018-03-30'), y: 6844.32 },
        { x: new Date('2018-03-31'), y: 6926.02 },
        { x: new Date('2018-04-01'), y: 6816.74 },
        { x: new Date('2018-04-02'), y: 7049.79 },
        { x: new Date('2018-04-03'), y: 7417.89 },
        { x: new Date('2018-04-04'), y: 6789.3 },
        { x: new Date('2018-04-05'), y: 6774.75 },
        { x: new Date('2018-04-06'), y: 6620.41 },
        { x: new Date('2018-04-07'), y: 6896.28 },
        { x: new Date('2018-04-08'), y: 7022.71 },
        { x: new Date('2018-04-09'), y: 6773.94 },
        { x: new Date('2018-04-10'), y: 6830.9 },
        { x: new Date('2018-04-11'), y: 6939.55 },
        { x: new Date('2018-04-12'), y: 7916.37 },
        { x: new Date('2018-04-13'), y: 7889.23 },
        { x: new Date('2018-04-14'), y: 8003.68 },
        { x: new Date('2018-04-15'), y: 8357.04 },
        { x: new Date('2018-04-16'), y: 8051.34 },
        { x: new Date('2018-04-17'), y: 7890.15 },
        { x: new Date('2018-04-18'), y: 8163.69 },
        { x: new Date('2018-04-19'), y: 8273.74 },
        { x: new Date('2018-04-20'), y: 8863.5 },
        { x: new Date('2018-04-21'), y: 8917.6 },
        { x: new Date('2018-04-22'), y: 8792.83 },
        { x: new Date('2018-04-23'), y: 8938.3 },
        { x: new Date('2018-04-24'), y: 9652.16 },
        { x: new Date('2018-04-25'), y: 8864.09 },
        { x: new Date('2018-04-26'), y: 9279 },
        { x: new Date('2018-04-27'), y: 8978.33 },
        { x: new Date('2018-04-28'), y: 9342.47 },
        { x: new Date('2018-04-29'), y: 9392.03 },
        { x: new Date('2018-04-30'), y: 9244.32 }
];
var employeeData = [{
    'EmployeeID': 1,
    'yValue': 2,
    'FirstName': 'Nancy',
    'Title': 'Sales Representative',
    'HireDate': new Date(1992, 0, 1),
},
{
    'EmployeeID': 2,
    'yValue': 5,
    'FirstName': 'Andrew',
    'Title': 'Vice President, Sales',
    'HireDate': new Date(1992, 1, 1),
},
{
    'EmployeeID': 3,
    'yValue': 8,
    'FirstName': 'Janet',
    'Title': 'Sales Representative',
    'HireDate': new Date(1992, 2, 1),
},
{
    'EmployeeID': 4,
    'yValue': 4,
    'FirstName': 'Margaret',
    'Title': 'Sales Representative',
    'HireDate': new Date(1992, 3, 1),
},
{
    'EmployeeID': 5,
    'yValue': 7,
    'FirstName': 'Steven',
    'Title': 'Sales Manager',
    'HireDate': new Date(1992, 4, 1),
},
{
    'EmployeeID': 6,
    'yValue': 9,
    'FirstName': 'Michael',
    'Title': 'Sales Representative',
    'HireDate': new Date(1992, 5, 1),
},
{
    'EmployeeID': 7,
    'yValue': 6,
    'FirstName': 'Robert',
    'Title': 'Sales Representative',
    'HireDate': new Date(1992, 6, 1),
},
{
    'EmployeeID': 8,
    'yValue': 4,
    'FirstName': 'Laura',
    'Title': 'Inside Sales Coordinator',
    'HireDate': new Date(1992, 7, 1),
},
{
    'EmployeeID': 9,
    'yValue': 8,
    'FirstName': 'Anne',
    'Title': 'Sales Representative',
    'HireDate': new Date(1992, 8, 1),
}, {
    'EmployeeID': 10,
    'yValue': 2,
    'FirstName': 'Fletcher',
    'Title': 'Sales Representative',
    'HireDate': new Date(1992, 9, 1),
},
{
    'EmployeeID': 11,
    'yValue': 5,
    'FirstName': 'Robin',
    'Title': 'Vice President, Sales',
    'HireDate': new Date(1992, 10, 1),
},
{
    'EmployeeID': 12,
    'yValue': 8,
    'FirstName': 'Mathew',
    'Title': 'Sales Representative',
    'HireDate': new Date(1992, 11, 1),
},
{
    'EmployeeID': 13,
    'yValue': 4,
    'FirstName': 'Henry',
    'Title': 'Sales Representative',
    'HireDate': new Date(1993, 0, 1),
},
{
    'EmployeeID': 14,
    'yValue': 7,
    'FirstName': 'Flemming',
    'Title': 'Sales Manager',
    'HireDate': new Date(1993, 1, 1),
},
{
    'EmployeeID': 15,
    'yValue': 9,
    'FirstName': 'Clarke',
    'Title': 'Sales Representative',
    'HireDate': new Date(1993, 2, 1),
},
{
    'EmployeeID': 16,
    'yValue': 6,
    'FirstName': 'Martin',
    'Title': 'Sales Representative',
    'HireDate': new Date(1993, 3, 1),
},
{
    'EmployeeID': 17,
    'yValue': 4,
    'FirstName': 'Loius',
    'Title': 'Inside Sales Coordinator',
    'HireDate': new Date(1993, 4, 1),
},
{
    'EmployeeID': 18,
    'yValue': 8,
    'FirstName': 'Arthur',
    'Title': 'Sales Representative',
    'HireDate': new Date(1993, 5, 1),
},
{
    'EmployeeID': 19,
    'yValue': 5,
    'FirstName': 'Marcus',
    'Title': 'Sales Representative',
    'HireDate': new Date(1993, 6, 1),
},
{
    'EmployeeID': 20,
    'yValue': 7,
    'FirstName': 'Albert',
    'Title': 'Inside Sales Coordinator',
    'HireDate': new Date(1993, 7, 1),
},
{
    'EmployeeID': 21,
    'yValue': 9,
    'FirstName': 'Nicolas',
    'Title': 'Inside Sales Coordinator',
    'HireDate': new Date(1993, 8, 1),
},
{
    'EmployeeID': 22,
    'yValue': 7,
    'FirstName': 'Behardien',
    'Title': 'Sales Representative',
    'HireDate': new Date(1993, 9, 1),
},
{
    'EmployeeID': 23,
    'yValue': 3,
    'FirstName': 'Bruce',
    'Title': 'Inside Sales Coordinator',
    'HireDate': new Date(1993, 10, 1),
},
{
    'EmployeeID': 24,
    'yValue': 7,
    'FirstName': 'Kimi',
    'Title': 'Inside Sales Coordinator',
    'HireDate': new Date(1993, 11, 1),
    }];

window.stockData = [
    {
        "x": new Date(1167609600000),
        "y": 0.7537
    },
    {
        "x": new Date(1167696000000),
        "y": 0.7537
    },
    {
        "x": new Date(1167782400000),
        "y": 0.7559
    },
    {
        "x": new Date(1167868800000),
        "y": 0.7631
    },
    {
        "x": new Date(1167955200000),
        "y": 0.7644
    },
    {
        "x": new Date(1168214400000),
        "y": 0.769
    },
    {
        "x": new Date(1168300800000),
        "y": 0.7683
    },
    {
        "x": new Date(1168387200000),
        "y": 0.77
    },
    {
        "x": new Date(1168473600000),
        "y": 0.7703
    },
    {
        "x": new Date(1168560000000),
        "y": 0.7757
    },
    {
        "x": new Date(1168819200000),
        "y": 0.7728
    },
    {
        "x": new Date(1168905600000),
        "y": 0.7721
    },
    {
        "x": new Date(1168992000000),
        "y": 0.7748
    },
    {
        "x": new Date(1169078400000),
        "y": 0.774
    },
    {
        "x": new Date(1169164800000),
        "y": 0.7718
    },
    {
        "x": new Date(1169424000000),
        "y": 0.7731
    },
    {
        "x": new Date(1169510400000),
        "y": 0.767
    },
    {
        "x": new Date(1169596800000),
        "y": 0.769
    },
    {
        "x": new Date(1169683200000),
        "y": 0.7706
    },
    {
        "x": new Date(1169769600000),
        "y": 0.7752
    },
    {
        "x": new Date(1170028800000),
        "y": 0.774
    },
    {
        "x": new Date(1170115200000),
        "y": 0.771
    },
    {
        "x": new Date(1170201600000),
        "y": 0.7721
    },
    {
        "x": new Date(1170288000000),
        "y": 0.7681
    },
    {
        "x": new Date(1170374400000),
        "y": 0.7681
    },
    {
        "x": new Date(1170633600000),
        "y": 0.7738
    },
    {
        "x": new Date(1170720000000),
        "y": 0.772
    },
    {
        "x": new Date(1170806400000),
        "y": 0.7701
    },
    {
        "x": new Date(1170892800000),
        "y": 0.7699
    },
    {
        "x": new Date(1170979200000),
        "y": 0.7689
    },
    {
        "x": new Date(1171238400000),
        "y": 0.7719
    },
    {
        "x": new Date(1171324800000),
        "y": 0.768
    },
    {
        "x": new Date(1171411200000),
        "y": 0.7645
    },
    {
        "x": new Date(1171497600000),
        "y": 0.7613
    },
    {
        "x": new Date(1171584000000),
        "y": 0.7624
    },
    {
        "x": new Date(1171843200000),
        "y": 0.7616
    },
    {
        "x": new Date(1171929600000),
        "y": 0.7608
    },
    {
        "x": new Date(1172016000000),
        "y": 0.7608
    },
    {
        "x": new Date(1172102400000),
        "y": 0.7631
    },
    {
        "x": new Date(1172188800000),
        "y": 0.7615
    },
    {
        "x": new Date(1172448000000),
        "y": 0.76
    },
    {
        "x": new Date(1172534400000),
        "y": 0.756
    },
    {
        "x": new Date(1172620800000),
        "y": 0.757
    },
    {
        "x": new Date(1172707200000),
        "y": 0.7562
    },
    {
        "x": new Date(1172793600000),
        "y": 0.7598
    },
    {
        "x": new Date(1173052800000),
        "y": 0.7645
    },
    {
        "x": new Date(1173139200000),
        "y": 0.7635
    },
    {
        "x": new Date(1173225600000),
        "y": 0.7614
    },
    {
        "x": new Date(1173312000000),
        "y": 0.7604
    },
    {
        "x": new Date(1173398400000),
        "y": 0.7603
    },
    {
        "x": new Date(1173657600000),
        "y": 0.7602
    },
    {
        "x": new Date(1173744000000),
        "y": 0.7566
    },
    {
        "x": new Date(1173830400000),
        "y": 0.7587
    },
    {
        "x": new Date(1173916800000),
        "y": 0.7562
    },
    {
        "x": new Date(1174003200000),
        "y": 0.7506
    },
    {
        "x": new Date(1174262400000),
        "y": 0.7518
    },
    {
        "x": new Date(1174348800000),
        "y": 0.7522
    },
    {
        "x": new Date(1174435200000),
        "y": 0.7524
    },
    {
        "x": new Date(1174521600000),
        "y": 0.7491
    },
    {
        "x": new Date(1174608000000),
        "y": 0.7505
    },
    {
        "x": new Date(1174867200000),
        "y": 0.754
    },
    {
        "x": new Date(1174953600000),
        "y": 0.7493
    },
    {
        "x": new Date(1175040000000),
        "y": 0.7493
    },
    {
        "x": new Date(1175126400000),
        "y": 0.7491
    },
    {
        "x": new Date(1175212800000),
        "y": 0.751
    },
    {
        "x": new Date(1175472000000),
        "y": 0.7483
    },
    {
        "x": new Date(1175558400000),
        "y": 0.7487
    },
    {
        "x": new Date(1175644800000),
        "y": 0.7491
    },
    {
        "x": new Date(1175731200000),
        "y": 0.7479
    },
    {
        "x": new Date(1175817600000),
        "y": 0.7479
    },
    {
        "x": new Date(1176076800000),
        "y": 0.7479
    },
    {
        "x": new Date(1176163200000),
        "y": 0.7449
    },
    {
        "x": new Date(1176249600000),
        "y": 0.7454
    },
    {
        "x": new Date(1176336000000),
        "y": 0.7427
    },
    {
        "x": new Date(1176422400000),
        "y": 0.7391
    },
    {
        "x": new Date(1176681600000),
        "y": 0.7381
    },
    {
        "x": new Date(1176768000000),
        "y": 0.7382
    },
    {
        "x": new Date(1176854400000),
        "y": 0.7366
    },
    {
        "x": new Date(1176940800000),
        "y": 0.7353
    },
    {
        "x": new Date(1177027200000),
        "y": 0.7351
    },
    {
        "x": new Date(1177286400000),
        "y": 0.7377
    },
    {
        "x": new Date(1177372800000),
        "y": 0.7364
    },
    {
        "x": new Date(1177459200000),
        "y": 0.7328
    },
    {
        "x": new Date(1177545600000),
        "y": 0.7356
    },
    {
        "x": new Date(1177632000000),
        "y": 0.7331
    },
    {
        "x": new Date(1177891200000),
        "y": 0.7351
    },
    {
        "x": new Date(1177977600000),
        "y": 0.7351
    },
    {
        "x": new Date(1178064000000),
        "y": 0.736
    },
    {
        "x": new Date(1178150400000),
        "y": 0.7347
    },
    {
        "x": new Date(1178236800000),
        "y": 0.7375
    },
    {
        "x": new Date(1178496000000),
        "y": 0.7346
    },
    {
        "x": new Date(1178582400000),
        "y": 0.7377
    },
    {
        "x": new Date(1178668800000),
        "y": 0.7389
    },
    {
        "x": new Date(1178755200000),
        "y": 0.7394
    },
    {
        "x": new Date(1178841600000),
        "y": 0.7416
    },
    {
        "x": new Date(1179100800000),
        "y": 0.7382
    },
    {
        "x": new Date(1179187200000),
        "y": 0.7388
    },
    {
        "x": new Date(1179273600000),
        "y": 0.7368
    },
    {
        "x": new Date(1179360000000),
        "y": 0.74
    },
    {
        "x": new Date(1179446400000),
        "y": 0.7421
    },
    {
        "x": new Date(1179705600000),
        "y": 0.7439
    },
    {
        "x": new Date(1179792000000),
        "y": 0.7434
    },
    {
        "x": new Date(1179878400000),
        "y": 0.7414
    },
    {
        "x": new Date(1179964800000),
        "y": 0.7437
    },
    {
        "x": new Date(1180051200000),
        "y": 0.7441
    },
    {
        "x": new Date(1180310400000),
        "y": 0.7434
    },
    {
        "x": new Date(1180396800000),
        "y": 0.7403
    },
    {
        "x": new Date(1180483200000),
        "y": 0.7453
    },
    {
        "x": new Date(1180569600000),
        "y": 0.7434
    },
    {
        "x": new Date(1180656000000),
        "y": 0.7444
    },
    {
        "x": new Date(1180915200000),
        "y": 0.7418
    },
    {
        "x": new Date(1181001600000),
        "y": 0.7391
    },
    {
        "x": new Date(1181088000000),
        "y": 0.7401
    },
    {
        "x": new Date(1181174400000),
        "y": 0.7425
    },
    {
        "x": new Date(1181260800000),
        "y": 0.7492
    },
    {
        "x": new Date(1181520000000),
        "y": 0.7489
    },
    {
        "x": new Date(1181606400000),
        "y": 0.7494
    },
    {
        "x": new Date(1181692800000),
        "y": 0.7527
    },
    {
        "x": new Date(1181779200000),
        "y": 0.7518
    },
    {
        "x": new Date(1181865600000),
        "y": 0.7512
    },
    {
        "x": new Date(1182124800000),
        "y": 0.7461
    },
    {
        "x": new Date(1182211200000),
        "y": 0.7462
    },
    {
        "x": new Date(1182297600000),
        "y": 0.7449
    },
    {
        "x": new Date(1182384000000),
        "y": 0.7465
    },
    {
        "x": new Date(1182470400000),
        "y": 0.7441
    },
    {
        "x": new Date(1182729600000),
        "y": 0.743
    },
    {
        "x": new Date(1182816000000),
        "y": 0.743
    },
    {
        "x": new Date(1182902400000),
        "y": 0.7443
    },
    {
        "x": new Date(1182988800000),
        "y": 0.7427
    },
    {
        "x": new Date(1183075200000),
        "y": 0.7406
    },
    {
        "x": new Date(1183334400000),
        "y": 0.736
    },
    {
        "x": new Date(1183420800000),
        "y": 0.7353
    },
    {
        "x": new Date(1183507200000),
        "y": 0.7344
    },
    {
        "x": new Date(1183593600000),
        "y": 0.7332
    },
    {
        "x": new Date(1183680000000),
        "y": 0.7356
    },
    {
        "x": new Date(1183939200000),
        "y": 0.7343
    },
    {
        "x": new Date(1184025600000),
        "y": 0.7318
    },
    {
        "x": new Date(1184112000000),
        "y": 0.7272
    },
    {
        "x": new Date(1184198400000),
        "y": 0.7254
    },
    {
        "x": new Date(1184284800000),
        "y": 0.7257
    },
    {
        "x": new Date(1184544000000),
        "y": 0.7257
    },
    {
        "x": new Date(1184630400000),
        "y": 0.7263
    },
    {
        "x": new Date(1184716800000),
        "y": 0.7258
    },
    {
        "x": new Date(1184803200000),
        "y": 0.7237
    },
    {
        "x": new Date(1184889600000),
        "y": 0.7246
    },
    {
        "x": new Date(1185148800000),
        "y": 0.7236
    },
    {
        "x": new Date(1185235200000),
        "y": 0.723
    },
    {
        "x": new Date(1185321600000),
        "y": 0.7277
    },
    {
        "x": new Date(1185408000000),
        "y": 0.7289
    },
    {
        "x": new Date(1185494400000),
        "y": 0.7326
    },
    {
        "x": new Date(1185753600000),
        "y": 0.7322
    },
    {
        "x": new Date(1185840000000),
        "y": 0.7297
    },
    {
        "x": new Date(1185926400000),
        "y": 0.732
    },
    {
        "x": new Date(1186012800000),
        "y": 0.732
    },
    {
        "x": new Date(1186099200000),
        "y": 0.7303
    },
    {
        "x": new Date(1186358400000),
        "y": 0.7238
    },
    {
        "x": new Date(1186444800000),
        "y": 0.7251
    },
    {
        "x": new Date(1186531200000),
        "y": 0.7251
    },
    {
        "x": new Date(1186617600000),
        "y": 0.7285
    },
    {
        "x": new Date(1186704000000),
        "y": 0.7327
    },
    {
        "x": new Date(1186963200000),
        "y": 0.7326
    },
    {
        "x": new Date(1187049600000),
        "y": 0.7359
    },
    {
        "x": new Date(1187136000000),
        "y": 0.7422
    },
    {
        "x": new Date(1187222400000),
        "y": 0.7461
    },
    {
        "x": new Date(1187308800000),
        "y": 0.7434
    },
    {
        "x": new Date(1187568000000),
        "y": 0.7422
    },
    {
        "x": new Date(1187654400000),
        "y": 0.7404
    },
    {
        "x": new Date(1187740800000),
        "y": 0.7412
    },
    {
        "x": new Date(1187827200000),
        "y": 0.7368
    },
    {
        "x": new Date(1187913600000),
        "y": 0.7346
    },
    {
        "x": new Date(1188172800000),
        "y": 0.7323
    },
    {
        "x": new Date(1188259200000),
        "y": 0.732
    },
    {
        "x": new Date(1188345600000),
        "y": 0.7337
    },
    {
        "x": new Date(1188432000000),
        "y": 0.7349
    },
    {
        "x": new Date(1188518400000),
        "y": 0.7298
    },
    {
        "x": new Date(1188777600000),
        "y": 0.7337
    },
    {
        "x": new Date(1188864000000),
        "y": 0.7365
    },
    {
        "x": new Date(1188950400000),
        "y": 0.736
    },
    {
        "x": new Date(1189036800000),
        "y": 0.7317
    },
    {
        "x": new Date(1189123200000),
        "y": 0.7302
    },
    {
        "x": new Date(1189382400000),
        "y": 0.725
    },
    {
        "x": new Date(1189468800000),
        "y": 0.7235
    },
    {
        "x": new Date(1189555200000),
        "y": 0.7203
    },
    {
        "x": new Date(1189641600000),
        "y": 0.7197
    },
    {
        "x": new Date(1189728000000),
        "y": 0.7216
    },
    {
        "x": new Date(1189987200000),
        "y": 0.7207
    },
    {
        "x": new Date(1190073600000),
        "y": 0.7212
    },
    {
        "x": new Date(1190160000000),
        "y": 0.7157
    },
    {
        "x": new Date(1190246400000),
        "y": 0.7129
    },
    {
        "x": new Date(1190332800000),
        "y": 0.7119
    },
    {
        "x": new Date(1190592000000),
        "y": 0.7087
    },
    {
        "x": new Date(1190678400000),
        "y": 0.709
    },
    {
        "x": new Date(1190764800000),
        "y": 0.708
    },
    {
        "x": new Date(1190851200000),
        "y": 0.7053
    },
    {
        "x": new Date(1190937600000),
        "y": 0.7054
    },
    {
        "x": new Date(1191196800000),
        "y": 0.7027
    },
    {
        "x": new Date(1191283200000),
        "y": 0.7061
    },
    {
        "x": new Date(1191369600000),
        "y": 0.7046
    },
    {
        "x": new Date(1191456000000),
        "y": 0.7089
    },
    {
        "x": new Date(1191542400000),
        "y": 0.7075
    },
    {
        "x": new Date(1191801600000),
        "y": 0.7099
    },
    {
        "x": new Date(1191888000000),
        "y": 0.7125
    },
    {
        "x": new Date(1191974400000),
        "y": 0.707
    },
    {
        "x": new Date(1192060800000),
        "y": 0.7044
    },
    {
        "x": new Date(1192147200000),
        "y": 0.7057
    },
    {
        "x": new Date(1192406400000),
        "y": 0.703
    },
    {
        "x": new Date(1192492800000),
        "y": 0.7068
    },
    {
        "x": new Date(1192579200000),
        "y": 0.7043
    },
    {
        "x": new Date(1192665600000),
        "y": 0.6994
    },
    {
        "x": new Date(1192752000000),
        "y": 0.7
    },
    {
        "x": new Date(1193011200000),
        "y": 0.706
    },
    {
        "x": new Date(1193097600000),
        "y": 0.7017
    },
    {
        "x": new Date(1193184000000),
        "y": 0.7028
    },
    {
        "x": new Date(1193270400000),
        "y": 0.699
    },
    {
        "x": new Date(1193356800000),
        "y": 0.6953
    },
    {
        "x": new Date(1193616000000),
        "y": 0.695
    },
    {
        "x": new Date(1193702400000),
        "y": 0.6942
    },
    {
        "x": new Date(1193788800000),
        "y": 0.6923
    },
    {
        "x": new Date(1193875200000),
        "y": 0.6934
    },
    {
        "x": new Date(1193961600000),
        "y": 0.6908
    },
    {
        "x": new Date(1194220800000),
        "y": 0.6903
    },
    {
        "x": new Date(1194307200000),
        "y": 0.6875
    },
    {
        "x": new Date(1194393600000),
        "y": 0.6794
    },
    {
        "x": new Date(1194480000000),
        "y": 0.6819
    },
    {
        "x": new Date(1194566400000),
        "y": 0.6812
    },
    {
        "x": new Date(1194825600000),
        "y": 0.686
    },
    {
        "x": new Date(1194912000000),
        "y": 0.6847
    },
    {
        "x": new Date(1194998400000),
        "y": 0.6804
    },
    {
        "x": new Date(1195084800000),
        "y": 0.6832
    },
    {
        "x": new Date(1195171200000),
        "y": 0.6826
    },
    {
        "x": new Date(1195430400000),
        "y": 0.6825
    },
    {
        "x": new Date(1195516800000),
        "y": 0.6765
    },
    {
        "x": new Date(1195603200000),
        "y": 0.6751
    },
    {
        "x": new Date(1195689600000),
        "y": 0.6745
    },
    {
        "x": new Date(1195776000000),
        "y": 0.6754
    },
    {
        "x": new Date(1196035200000),
        "y": 0.6737
    },
    {
        "x": new Date(1196121600000),
        "y": 0.6724
    },
    {
        "x": new Date(1196208000000),
        "y": 0.6782
    },
    {
        "x": new Date(1196294400000),
        "y": 0.6786
    },
    {
        "x": new Date(1196380800000),
        "y": 0.6776
    },
    {
        "x": new Date(1196640000000),
        "y": 0.6819
    },
    {
        "x": new Date(1196726400000),
        "y": 0.6785
    },
    {
        "x": new Date(1196812800000),
        "y": 0.6794
    },
    {
        "x": new Date(1196899200000),
        "y": 0.6872
    },
    {
        "x": new Date(1196985600000),
        "y": 0.6827
    },
    {
        "x": new Date(1197244800000),
        "y": 0.6795
    },
    {
        "x": new Date(1197331200000),
        "y": 0.6817
    },
    {
        "x": new Date(1197417600000),
        "y": 0.6815
    },
    {
        "x": new Date(1197504000000),
        "y": 0.6812
    },
    {
        "x": new Date(1197590400000),
        "y": 0.6893
    },
    {
        "x": new Date(1197849600000),
        "y": 0.6949
    },
    {
        "x": new Date(1197936000000),
        "y": 0.6938
    },
    {
        "x": new Date(1198022400000),
        "y": 0.6953
    },
    {
        "x": new Date(1198108800000),
        "y": 0.697
    },
    {
        "x": new Date(1198195200000),
        "y": 0.6955
    },
    {
        "x": new Date(1198454400000),
        "y": 0.6946
    },
    {
        "x": new Date(1198540800000),
        "y": 0.6946
    },
    {
        "x": new Date(1198627200000),
        "y": 0.6946
    },
    {
        "x": new Date(1198713600000),
        "y": 0.689
    },
    {
        "x": new Date(1198800000000),
        "y": 0.6807
    },
    {
        "x": new Date(1199059200000),
        "y": 0.6794
    },
    {
        "x": new Date(1199145600000),
        "y": 0.6794
    },
    {
        "x": new Date(1199232000000),
        "y": 0.6809
    },
    {
        "x": new Date(1199318400000),
        "y": 0.6779
    },
    {
        "x": new Date(1199404800000),
        "y": 0.6791
    },
    {
        "x": new Date(1199664000000),
        "y": 0.6793
    },
    {
        "x": new Date(1199750400000),
        "y": 0.6801
    },
    {
        "x": new Date(1199836800000),
        "y": 0.6813
    },
    {
        "x": new Date(1199923200000),
        "y": 0.6821
    },
    {
        "x": new Date(1200009600000),
        "y": 0.6761
    },
    {
        "x": new Date(1200268800000),
        "y": 0.6715
    },
    {
        "x": new Date(1200355200000),
        "y": 0.6719
    },
    {
        "x": new Date(1200441600000),
        "y": 0.6761
    },
    {
        "x": new Date(1200528000000),
        "y": 0.6808
    },
    {
        "x": new Date(1200614400000),
        "y": 0.6816
    },
    {
        "x": new Date(1200873600000),
        "y": 0.6906
    },
    {
        "x": new Date(1200960000000),
        "y": 0.69
    },
    {
        "x": new Date(1201046400000),
        "y": 0.6863
    },
    {
        "x": new Date(1201132800000),
        "y": 0.6821
    },
    {
        "x": new Date(1201219200000),
        "y": 0.6801
    },
    {
        "x": new Date(1201478400000),
        "y": 0.6778
    },
    {
        "x": new Date(1201564800000),
        "y": 0.677
    },
    {
        "x": new Date(1201651200000),
        "y": 0.6753
    },
    {
        "x": new Date(1201737600000),
        "y": 0.6726
    },
    {
        "x": new Date(1201824000000),
        "y": 0.6717
    },
    {
        "x": new Date(1202083200000),
        "y": 0.6745
    },
    {
        "x": new Date(1202169600000),
        "y": 0.6809
    },
    {
        "x": new Date(1202256000000),
        "y": 0.684
    },
    {
        "x": new Date(1202342400000),
        "y": 0.6865
    },
    {
        "x": new Date(1202428800000),
        "y": 0.6891
    },
    {
        "x": new Date(1202688000000),
        "y": 0.6878
    },
    {
        "x": new Date(1202774400000),
        "y": 0.688
    },
    {
        "x": new Date(1202860800000),
        "y": 0.6857
    },
    {
        "x": new Date(1202947200000),
        "y": 0.6838
    },
    {
        "x": new Date(1203033600000),
        "y": 0.6816
    },
    {
        "x": new Date(1203292800000),
        "y": 0.6833
    },
    {
        "x": new Date(1203379200000),
        "y": 0.6784
    },
    {
        "x": new Date(1203465600000),
        "y": 0.6824
    },
    {
        "x": new Date(1203552000000),
        "y": 0.6787
    },
    {
        "x": new Date(1203638400000),
        "y": 0.6736
    },
    {
        "x": new Date(1203897600000),
        "y": 0.675
    },
    {
        "x": new Date(1203984000000),
        "y": 0.6724
    },
    {
        "x": new Date(1204070400000),
        "y": 0.6648
    },
    {
        "x": new Date(1204156800000),
        "y": 0.6614
    },
    {
        "x": new Date(1204243200000),
        "y": 0.6594
    },
    {
        "x": new Date(1204502400000),
        "y": 0.6579
    },
    {
        "x": new Date(1204588800000),
        "y": 0.6577
    },
    {
        "x": new Date(1204675200000),
        "y": 0.6582
    },
    {
        "x": new Date(1204761600000),
        "y": 0.6529
    },
    {
        "x": new Date(1204848000000),
        "y": 0.6487
    },
    {
        "x": new Date(1205107200000),
        "y": 0.652
    },
    {
        "x": new Date(1205193600000),
        "y": 0.6503
    },
    {
        "x": new Date(1205280000000),
        "y": 0.6462
    },
    {
        "x": new Date(1205366400000),
        "y": 0.6421
    },
    {
        "x": new Date(1205452800000),
        "y": 0.6427
    },
    {
        "x": new Date(1205712000000),
        "y": 0.6342
    },
    {
        "x": new Date(1205798400000),
        "y": 0.6342
    },
    {
        "x": new Date(1205884800000),
        "y": 0.6374
    },
    {
        "x": new Date(1205971200000),
        "y": 0.6485
    },
    {
        "x": new Date(1206057600000),
        "y": 0.6485
    },
    {
        "x": new Date(1206316800000),
        "y": 0.6485
    },
    {
        "x": new Date(1206403200000),
        "y": 0.6424
    },
    {
        "x": new Date(1206489600000),
        "y": 0.6366
    },
    {
        "x": new Date(1206576000000),
        "y": 0.6336
    },
    {
        "x": new Date(1206662400000),
        "y": 0.6332
    },
    {
        "x": new Date(1206921600000),
        "y": 0.6325
    },
    {
        "x": new Date(1207008000000),
        "y": 0.6387
    },
    {
        "x": new Date(1207094400000),
        "y": 0.6398
    },
    {
        "x": new Date(1207180800000),
        "y": 0.6442
    },
    {
        "x": new Date(1207267200000),
        "y": 0.6362
    },
    {
        "x": new Date(1207526400000),
        "y": 0.6373
    },
    {
        "x": new Date(1207612800000),
        "y": 0.6373
    },
    {
        "x": new Date(1207699200000),
        "y": 0.636
    },
    {
        "x": new Date(1207785600000),
        "y": 0.63
    },
    {
        "x": new Date(1207872000000),
        "y": 0.6317
    },
    {
        "x": new Date(1208131200000),
        "y": 0.6303
    },
    {
        "x": new Date(1208217600000),
        "y": 0.6319
    },
    {
        "x": new Date(1208304000000),
        "y": 0.6279
    },
    {
        "x": new Date(1208390400000),
        "y": 0.6301
    },
    {
        "x": new Date(1208476800000),
        "y": 0.6338
    },
    {
        "x": new Date(1208736000000),
        "y": 0.6291
    },
    {
        "x": new Date(1208822400000),
        "y": 0.6278
    },
    {
        "x": new Date(1208908800000),
        "y": 0.6275
    },
    {
        "x": new Date(1208995200000),
        "y": 0.6343
    },
    {
        "x": new Date(1209081600000),
        "y": 0.6413
    },
    {
        "x": new Date(1209340800000),
        "y": 0.64
    },
    {
        "x": new Date(1209427200000),
        "y": 0.6423
    },
    {
        "x": new Date(1209513600000),
        "y": 0.6436
    },
    {
        "x": new Date(1209600000000),
        "y": 0.6436
    },
    {
        "x": new Date(1209686400000),
        "y": 0.647
    },
    {
        "x": new Date(1209945600000),
        "y": 0.6469
    },
    {
        "x": new Date(1210032000000),
        "y": 0.6441
    },
    {
        "x": new Date(1210118400000),
        "y": 0.6482
    },
    {
        "x": new Date(1210204800000),
        "y": 0.6517
    },
    {
        "x": new Date(1210291200000),
        "y": 0.647
    },
    {
        "x": new Date(1210550400000),
        "y": 0.6482
    },
    {
        "x": new Date(1210636800000),
        "y": 0.6464
    },
    {
        "x": new Date(1210723200000),
        "y": 0.6478
    },
    {
        "x": new Date(1210809600000),
        "y": 0.6463
    },
    {
        "x": new Date(1210896000000),
        "y": 0.6453
    },
    {
        "x": new Date(1211155200000),
        "y": 0.6421
    },
    {
        "x": new Date(1211241600000),
        "y": 0.6395
    },
    {
        "x": new Date(1211328000000),
        "y": 0.6349
    },
    {
        "x": new Date(1211414400000),
        "y": 0.6348
    },
    {
        "x": new Date(1211500800000),
        "y": 0.6353
    },
    {
        "x": new Date(1211760000000),
        "y": 0.6346
    },
    {
        "x": new Date(1211846400000),
        "y": 0.6346
    },
    {
        "x": new Date(1211932800000),
        "y": 0.6388
    },
    {
        "x": new Date(1212019200000),
        "y": 0.6431
    },
    {
        "x": new Date(1212105600000),
        "y": 0.6449
    },
    {
        "x": new Date(1212364800000),
        "y": 0.6444
    },
    {
        "x": new Date(1212451200000),
        "y": 0.6414
    },
    {
        "x": new Date(1212537600000),
        "y": 0.6467
    },
    {
        "x": new Date(1212624000000),
        "y": 0.6494
    },
    {
        "x": new Date(1212710400000),
        "y": 0.6412
    },
    {
        "x": new Date(1212969600000),
        "y": 0.6337
    },
    {
        "x": new Date(1213056000000),
        "y": 0.6442
    },
    {
        "x": new Date(1213142400000),
        "y": 0.6446
    },
    {
        "x": new Date(1213228800000),
        "y": 0.6487
    },
    {
        "x": new Date(1213315200000),
        "y": 0.6522
    },
    {
        "x": new Date(1213574400000),
        "y": 0.647
    },
    {
        "x": new Date(1213660800000),
        "y": 0.6462
    },
    {
        "x": new Date(1213747200000),
        "y": 0.6456
    },
    {
        "x": new Date(1213833600000),
        "y": 0.6461
    },
    {
        "x": new Date(1213920000000),
        "y": 0.6407
    },
    {
        "x": new Date(1214179200000),
        "y": 0.6444
    },
    {
        "x": new Date(1214265600000),
        "y": 0.6424
    },
    {
        "x": new Date(1214352000000),
        "y": 0.6412
    },
    {
        "x": new Date(1214438400000),
        "y": 0.6358
    },
    {
        "x": new Date(1214524800000),
        "y": 0.6351
    },
    {
        "x": new Date(1214784000000),
        "y": 0.6345
    },
    {
        "x": new Date(1214870400000),
        "y": 0.634
    },
    {
        "x": new Date(1214956800000),
        "y": 0.6328
    },
    {
        "x": new Date(1215043200000),
        "y": 0.6296
    },
    {
        "x": new Date(1215129600000),
        "y": 0.6382
    },
    {
        "x": new Date(1215388800000),
        "y": 0.639
    },
    {
        "x": new Date(1215475200000),
        "y": 0.6376
    },
    {
        "x": new Date(1215561600000),
        "y": 0.6364
    },
    {
        "x": new Date(1215648000000),
        "y": 0.6367
    },
    {
        "x": new Date(1215734400000),
        "y": 0.6316
    },
    {
        "x": new Date(1215993600000),
        "y": 0.6311
    },
    {
        "x": new Date(1216080000000),
        "y": 0.6255
    },
    {
        "x": new Date(1216166400000),
        "y": 0.6295
    },
    {
        "x": new Date(1216252800000),
        "y": 0.6311
    },
    {
        "x": new Date(1216339200000),
        "y": 0.6324
    },
    {
        "x": new Date(1216598400000),
        "y": 0.6307
    },
    {
        "x": new Date(1216684800000),
        "y": 0.6283
    },
    {
        "x": new Date(1216771200000),
        "y": 0.6354
    },
    {
        "x": new Date(1216857600000),
        "y": 0.638
    },
    {
        "x": new Date(1216944000000),
        "y": 0.6357
    },
    {
        "x": new Date(1217203200000),
        "y": 0.6352
    },
    {
        "x": new Date(1217289600000),
        "y": 0.6368
    },
    {
        "x": new Date(1217376000000),
        "y": 0.6416
    },
    {
        "x": new Date(1217462400000),
        "y": 0.6407
    },
    {
        "x": new Date(1217548800000),
        "y": 0.6422
    },
    {
        "x": new Date(1217808000000),
        "y": 0.6425
    },
    {
        "x": new Date(1217894400000),
        "y": 0.6458
    },
    {
        "x": new Date(1217980800000),
        "y": 0.6462
    },
    {
        "x": new Date(1218067200000),
        "y": 0.6465
    },
    {
        "x": new Date(1218153600000),
        "y": 0.6635
    },
    {
        "x": new Date(1218412800000),
        "y": 0.6662
    },
    {
        "x": new Date(1218499200000),
        "y": 0.6709
    },
    {
        "x": new Date(1218585600000),
        "y": 0.6711
    },
    {
        "x": new Date(1218672000000),
        "y": 0.6709
    },
    {
        "x": new Date(1218758400000),
        "y": 0.679
    },
    {
        "x": new Date(1219017600000),
        "y": 0.6802
    },
    {
        "x": new Date(1219104000000),
        "y": 0.6814
    },
    {
        "x": new Date(1219190400000),
        "y": 0.6788
    },
    {
        "x": new Date(1219276800000),
        "y": 0.6751
    },
    {
        "x": new Date(1219363200000),
        "y": 0.6754
    },
    {
        "x": new Date(1219622400000),
        "y": 0.6773
    },
    {
        "x": new Date(1219708800000),
        "y": 0.6851
    },
    {
        "x": new Date(1219795200000),
        "y": 0.6773
    },
    {
        "x": new Date(1219881600000),
        "y": 0.6771
    },
    {
        "x": new Date(1219968000000),
        "y": 0.6788
    },
    {
        "x": new Date(1220227200000),
        "y": 0.684
    },
    {
        "x": new Date(1220313600000),
        "y": 0.689
    },
    {
        "x": new Date(1220400000000),
        "y": 0.6926
    },
    {
        "x": new Date(1220486400000),
        "y": 0.6903
    },
    {
        "x": new Date(1220572800000),
        "y": 0.702
    },
    {
        "x": new Date(1220832000000),
        "y": 0.7036
    },
    {
        "x": new Date(1220918400000),
        "y": 0.7071
    },
    {
        "x": new Date(1221004800000),
        "y": 0.7096
    },
    {
        "x": new Date(1221091200000),
        "y": 0.7178
    },
    {
        "x": new Date(1221177600000),
        "y": 0.711
    },
    {
        "x": new Date(1221436800000),
        "y": 0.7068
    },
    {
        "x": new Date(1221523200000),
        "y": 0.701
    },
    {
        "x": new Date(1221609600000),
        "y": 0.7031
    },
    {
        "x": new Date(1221696000000),
        "y": 0.6897
    },
    {
        "x": new Date(1221782400000),
        "y": 0.7025
    },
    {
        "x": new Date(1222041600000),
        "y": 0.6864
    },
    {
        "x": new Date(1222128000000),
        "y": 0.6789
    },
    {
        "x": new Date(1222214400000),
        "y": 0.6808
    },
    {
        "x": new Date(1222300800000),
        "y": 0.6804
    },
    {
        "x": new Date(1222387200000),
        "y": 0.6832
    },
    {
        "x": new Date(1222646400000),
        "y": 0.697
    },
    {
        "x": new Date(1222732800000),
        "y": 0.6993
    },
    {
        "x": new Date(1222819200000),
        "y": 0.7103
    },
    {
        "x": new Date(1222905600000),
        "y": 0.7194
    },
    {
        "x": new Date(1222992000000),
        "y": 0.723
    },
    {
        "x": new Date(1223251200000),
        "y": 0.7336
    },
    {
        "x": new Date(1223337600000),
        "y": 0.7337
    },
    {
        "x": new Date(1223424000000),
        "y": 0.7284
    },
    {
        "x": new Date(1223510400000),
        "y": 0.731
    },
    {
        "x": new Date(1223596800000),
        "y": 0.7365
    },
    {
        "x": new Date(1223856000000),
        "y": 0.7333
    },
    {
        "x": new Date(1223942400000),
        "y": 0.7273
    },
    {
        "x": new Date(1224028800000),
        "y": 0.734
    },
    {
        "x": new Date(1224115200000),
        "y": 0.7405
    },
    {
        "x": new Date(1224201600000),
        "y": 0.7461
    },
    {
        "x": new Date(1224460800000),
        "y": 0.745
    },
    {
        "x": new Date(1224547200000),
        "y": 0.7586
    },
    {
        "x": new Date(1224633600000),
        "y": 0.7787
    },
    {
        "x": new Date(1224720000000),
        "y": 0.7807
    },
    {
        "x": new Date(1224806400000),
        "y": 0.794
    },
    {
        "x": new Date(1225065600000),
        "y": 0.8027
    },
    {
        "x": new Date(1225152000000),
        "y": 0.7984
    },
    {
        "x": new Date(1225238400000),
        "y": 0.7832
    },
    {
        "x": new Date(1225324800000),
        "y": 0.7673
    },
    {
        "x": new Date(1225411200000),
        "y": 0.784
    },
    {
        "x": new Date(1225670400000),
        "y": 0.78
    },
    {
        "x": new Date(1225756800000),
        "y": 0.7801
    },
    {
        "x": new Date(1225843200000),
        "y": 0.7771
    },
    {
        "x": new Date(1225929600000),
        "y": 0.7832
    },
    {
        "x": new Date(1226016000000),
        "y": 0.784
    },
    {
        "x": new Date(1226275200000),
        "y": 0.7758
    },
    {
        "x": new Date(1226361600000),
        "y": 0.7846
    },
    {
        "x": new Date(1226448000000),
        "y": 0.7982
    },
    {
        "x": new Date(1226534400000),
        "y": 0.7985
    },
    {
        "x": new Date(1226620800000),
        "y": 0.7891
    },
    {
        "x": new Date(1226880000000),
        "y": 0.79
    },
    {
        "x": new Date(1226966400000),
        "y": 0.7904
    },
    {
        "x": new Date(1227052800000),
        "y": 0.7916
    },
    {
        "x": new Date(1227139200000),
        "y": 0.7974
    },
    {
        "x": new Date(1227225600000),
        "y": 0.7936
    },
    {
        "x": new Date(1227484800000),
        "y": 0.783
    },
    {
        "x": new Date(1227571200000),
        "y": 0.7807
    },
    {
        "x": new Date(1227657600000),
        "y": 0.7732
    },
    {
        "x": new Date(1227744000000),
        "y": 0.7753
    },
    {
        "x": new Date(1227830400000),
        "y": 0.7858
    },
    {
        "x": new Date(1228089600000),
        "y": 0.7932
    },
    {
        "x": new Date(1228176000000),
        "y": 0.7877
    },
    {
        "x": new Date(1228262400000),
        "y": 0.7923
    },
    {
        "x": new Date(1228348800000),
        "y": 0.7925
    },
    {
        "x": new Date(1228435200000),
        "y": 0.7897
    },
    {
        "x": new Date(1228694400000),
        "y": 0.7781
    },
    {
        "x": new Date(1228780800000),
        "y": 0.779
    },
    {
        "x": new Date(1228867200000),
        "y": 0.7738
    },
    {
        "x": new Date(1228953600000),
        "y": 0.7568
    },
    {
        "x": new Date(1229040000000),
        "y": 0.7497
    },
    {
        "x": new Date(1229299200000),
        "y": 0.7403
    },
    {
        "x": new Date(1229385600000),
        "y": 0.7306
    },
    {
        "x": new Date(1229472000000),
        "y": 0.7114
    },
    {
        "x": new Date(1229558400000),
        "y": 0.6843
    },
    {
        "x": new Date(1229644800000),
        "y": 0.7175
    },
    {
        "x": new Date(1229904000000),
        "y": 0.7159
    },
    {
        "x": new Date(1229990400000),
        "y": 0.7155
    },
    {
        "x": new Date(1230076800000),
        "y": 0.7141
    },
    {
        "x": new Date(1230163200000),
        "y": 0.7141
    },
    {
        "x": new Date(1230249600000),
        "y": 0.7141
    },
    {
        "x": new Date(1230508800000),
        "y": 0.7009
    },
    {
        "x": new Date(1230595200000),
        "y": 0.7094
    },
    {
        "x": new Date(1230681600000),
        "y": 0.7186
    },
    {
        "x": new Date(1230768000000),
        "y": 0.7186
    },
    {
        "x": new Date(1230854400000),
        "y": 0.7213
    },
    {
        "x": new Date(1231113600000),
        "y": 0.7364
    },
    {
        "x": new Date(1231200000000),
        "y": 0.7502
    },
    {
        "x": new Date(1231286400000),
        "y": 0.7357
    },
    {
        "x": new Date(1231372800000),
        "y": 0.7345
    },
    {
        "x": new Date(1231459200000),
        "y": 0.7309
    },
    {
        "x": new Date(1231718400000),
        "y": 0.7467
    },
    {
        "x": new Date(1231804800000),
        "y": 0.7541
    },
    {
        "x": new Date(1231891200000),
        "y": 0.7592
    },
    {
        "x": new Date(1231977600000),
        "y": 0.7643
    },
    {
        "x": new Date(1232064000000),
        "y": 0.7537
    },
    {
        "x": new Date(1232323200000),
        "y": 0.7587
    },
    {
        "x": new Date(1232409600000),
        "y": 0.7735
    },
    {
        "x": new Date(1232496000000),
        "y": 0.7747
    },
    {
        "x": new Date(1232582400000),
        "y": 0.7703
    },
    {
        "x": new Date(1232668800000),
        "y": 0.7817
    },
    {
        "x": new Date(1232928000000),
        "y": 0.7699
    },
    {
        "x": new Date(1233014400000),
        "y": 0.7592
    },
    {
        "x": new Date(1233100800000),
        "y": 0.7542
    },
    {
        "x": new Date(1233187200000),
        "y": 0.7628
    },
    {
        "x": new Date(1233273600000),
        "y": 0.7804
    },
    {
        "x": new Date(1233532800000),
        "y": 0.7838
    },
    {
        "x": new Date(1233619200000),
        "y": 0.7784
    },
    {
        "x": new Date(1233705600000),
        "y": 0.7803
    },
    {
        "x": new Date(1233792000000),
        "y": 0.7796
    },
    {
        "x": new Date(1233878400000),
        "y": 0.7816
    },
    {
        "x": new Date(1234137600000),
        "y": 0.7689
    },
    {
        "x": new Date(1234224000000),
        "y": 0.7713
    },
    {
        "x": new Date(1234310400000),
        "y": 0.773
    },
    {
        "x": new Date(1234396800000),
        "y": 0.7793
    },
    {
        "x": new Date(1234483200000),
        "y": 0.7799
    },
    {
        "x": new Date(1234742400000),
        "y": 0.7835
    },
    {
        "x": new Date(1234828800000),
        "y": 0.7916
    },
    {
        "x": new Date(1234915200000),
        "y": 0.794
    },
    {
        "x": new Date(1235001600000),
        "y": 0.7872
    },
    {
        "x": new Date(1235088000000),
        "y": 0.7943
    },
    {
        "x": new Date(1235347200000),
        "y": 0.7815
    },
    {
        "x": new Date(1235433600000),
        "y": 0.7836
    },
    {
        "x": new Date(1235520000000),
        "y": 0.7817
    },
    {
        "x": new Date(1235606400000),
        "y": 0.7825
    },
    {
        "x": new Date(1235692800000),
        "y": 0.791
    },
    {
        "x": new Date(1235952000000),
        "y": 0.794
    },
    {
        "x": new Date(1236038400000),
        "y": 0.7928
    },
    {
        "x": new Date(1236124800000),
        "y": 0.7966
    },
    {
        "x": new Date(1236211200000),
        "y": 0.7966
    },
    {
        "x": new Date(1236297600000),
        "y": 0.7901
    },
    {
        "x": new Date(1236556800000),
        "y": 0.796
    },
    {
        "x": new Date(1236643200000),
        "y": 0.7824
    },
    {
        "x": new Date(1236729600000),
        "y": 0.7822
    },
    {
        "x": new Date(1236816000000),
        "y": 0.7825
    },
    {
        "x": new Date(1236902400000),
        "y": 0.775
    },
    {
        "x": new Date(1237161600000),
        "y": 0.7669
    },
    {
        "x": new Date(1237248000000),
        "y": 0.7728
    },
    {
        "x": new Date(1237334400000),
        "y": 0.7617
    },
    {
        "x": new Date(1237420800000),
        "y": 0.7316
    },
    {
        "x": new Date(1237507200000),
        "y": 0.7382
    },
    {
        "x": new Date(1237766400000),
        "y": 0.7377
    },
    {
        "x": new Date(1237852800000),
        "y": 0.7405
    },
    {
        "x": new Date(1237939200000),
        "y": 0.7412
    },
    {
        "x": new Date(1238025600000),
        "y": 0.735
    },
    {
        "x": new Date(1238112000000),
        "y": 0.7523
    },
    {
        "x": new Date(1238371200000),
        "y": 0.7581
    },
    {
        "x": new Date(1238457600000),
        "y": 0.7515
    },
    {
        "x": new Date(1238544000000),
        "y": 0.755
    },
    {
        "x": new Date(1238630400000),
        "y": 0.7468
    },
    {
        "x": new Date(1238716800000),
        "y": 0.745
    },
    {
        "x": new Date(1238976000000),
        "y": 0.7411
    },
    {
        "x": new Date(1239062400000),
        "y": 0.7545
    },
    {
        "x": new Date(1239148800000),
        "y": 0.7559
    },
    {
        "x": new Date(1239235200000),
        "y": 0.7535
    },
    {
        "x": new Date(1239321600000),
        "y": 0.7535
    },
    {
        "x": new Date(1239580800000),
        "y": 0.7535
    },
    {
        "x": new Date(1239667200000),
        "y": 0.7533
    },
    {
        "x": new Date(1239753600000),
        "y": 0.7592
    },
    {
        "x": new Date(1239840000000),
        "y": 0.7579
    },
    {
        "x": new Date(1239926400000),
        "y": 0.7659
    },
    {
        "x": new Date(1240185600000),
        "y": 0.7713
    },
    {
        "x": new Date(1240272000000),
        "y": 0.7734
    },
    {
        "x": new Date(1240358400000),
        "y": 0.7725
    },
    {
        "x": new Date(1240444800000),
        "y": 0.7664
    },
    {
        "x": new Date(1240531200000),
        "y": 0.7558
    },
    {
        "x": new Date(1240790400000),
        "y": 0.762
    },
    {
        "x": new Date(1240876800000),
        "y": 0.7698
    },
    {
        "x": new Date(1240963200000),
        "y": 0.7539
    },
    {
        "x": new Date(1241049600000),
        "y": 0.7534
    },
    {
        "x": new Date(1241136000000),
        "y": 0.7534
    },
    {
        "x": new Date(1241395200000),
        "y": 0.7564
    },
    {
        "x": new Date(1241481600000),
        "y": 0.7462
    },
    {
        "x": new Date(1241568000000),
        "y": 0.7507
    },
    {
        "x": new Date(1241654400000),
        "y": 0.7484
    },
    {
        "x": new Date(1241740800000),
        "y": 0.745
    },
    {
        "x": new Date(1242000000000),
        "y": 0.7368
    },
    {
        "x": new Date(1242086400000),
        "y": 0.7309
    },
    {
        "x": new Date(1242172800000),
        "y": 0.7342
    },
    {
        "x": new Date(1242259200000),
        "y": 0.7374
    },
    {
        "x": new Date(1242345600000),
        "y": 0.7399
    },
    {
        "x": new Date(1242604800000),
        "y": 0.7412
    },
    {
        "x": new Date(1242691200000),
        "y": 0.7347
    },
    {
        "x": new Date(1242777600000),
        "y": 0.7306
    },
    {
        "x": new Date(1242864000000),
        "y": 0.7263
    },
    {
        "x": new Date(1242950400000),
        "y": 0.7158
    },
    {
        "x": new Date(1243209600000),
        "y": 0.7139
    },
    {
        "x": new Date(1243296000000),
        "y": 0.7191
    },
    {
        "x": new Date(1243382400000),
        "y": 0.7195
    },
    {
        "x": new Date(1243468800000),
        "y": 0.7218
    },
    {
        "x": new Date(1243555200000),
        "y": 0.7094
    },
    {
        "x": new Date(1243814400000),
        "y": 0.7033
    },
    {
        "x": new Date(1243900800000),
        "y": 0.7024
    },
    {
        "x": new Date(1243987200000),
        "y": 0.704
    },
    {
        "x": new Date(1244073600000),
        "y": 0.7096
    },
    {
        "x": new Date(1244160000000),
        "y": 0.7055
    },
    {
        "x": new Date(1244419200000),
        "y": 0.7213
    },
    {
        "x": new Date(1244505600000),
        "y": 0.7165
    },
    {
        "x": new Date(1244592000000),
        "y": 0.7092
    },
    {
        "x": new Date(1244678400000),
        "y": 0.716
    },
    {
        "x": new Date(1244764800000),
        "y": 0.7142
    },
    {
        "x": new Date(1245024000000),
        "y": 0.7221
    },
    {
        "x": new Date(1245110400000),
        "y": 0.72
    },
    {
        "x": new Date(1245196800000),
        "y": 0.7226
    },
    {
        "x": new Date(1245283200000),
        "y": 0.7185
    },
    {
        "x": new Date(1245369600000),
        "y": 0.7179
    },
    {
        "x": new Date(1245628800000),
        "y": 0.7217
    },
    {
        "x": new Date(1245715200000),
        "y": 0.7155
    },
    {
        "x": new Date(1245801600000),
        "y": 0.7129
    },
    {
        "x": new Date(1245888000000),
        "y": 0.7175
    },
    {
        "x": new Date(1245974400000),
        "y": 0.7095
    },
    {
        "x": new Date(1246233600000),
        "y": 0.7114
    },
    {
        "x": new Date(1246320000000),
        "y": 0.7076
    },
    {
        "x": new Date(1246406400000),
        "y": 0.7095
    },
    {
        "x": new Date(1246492800000),
        "y": 0.7119
    },
    {
        "x": new Date(1246579200000),
        "y": 0.7139
    },
    {
        "x": new Date(1246838400000),
        "y": 0.7197
    },
    {
        "x": new Date(1246924800000),
        "y": 0.7134
    },
    {
        "x": new Date(1247011200000),
        "y": 0.7195
    },
    {
        "x": new Date(1247097600000),
        "y": 0.7149
    },
    {
        "x": new Date(1247184000000),
        "y": 0.7195
    },
    {
        "x": new Date(1247443200000),
        "y": 0.7157
    },
    {
        "x": new Date(1247529600000),
        "y": 0.7148
    },
    {
        "x": new Date(1247616000000),
        "y": 0.7099
    },
    {
        "x": new Date(1247702400000),
        "y": 0.7078
    },
    {
        "x": new Date(1247788800000),
        "y": 0.7098
    },
    {
        "x": new Date(1248048000000),
        "y": 0.7035
    },
    {
        "x": new Date(1248134400000),
        "y": 0.7032
    },
    {
        "x": new Date(1248220800000),
        "y": 0.7048
    },
    {
        "x": new Date(1248307200000),
        "y": 0.7029
    },
    {
        "x": new Date(1248393600000),
        "y": 0.703
    },
    {
        "x": new Date(1248652800000),
        "y": 0.7009
    },
    {
        "x": new Date(1248739200000),
        "y": 0.7029
    },
    {
        "x": new Date(1248825600000),
        "y": 0.7091
    },
    {
        "x": new Date(1248912000000),
        "y": 0.7117
    },
    {
        "x": new Date(1248998400000),
        "y": 0.7074
    },
    {
        "x": new Date(1249257600000),
        "y": 0.6993
    },
    {
        "x": new Date(1249344000000),
        "y": 0.6953
    },
    {
        "x": new Date(1249430400000),
        "y": 0.6941
    },
    {
        "x": new Date(1249516800000),
        "y": 0.696
    },
    {
        "x": new Date(1249603200000),
        "y": 0.6966
    },
    {
        "x": new Date(1249862400000),
        "y": 0.7042
    },
    {
        "x": new Date(1249948800000),
        "y": 0.706
    },
    {
        "x": new Date(1250035200000),
        "y": 0.7058
    },
    {
        "x": new Date(1250121600000),
        "y": 0.6997
    },
    {
        "x": new Date(1250208000000),
        "y": 0.6997
    },
    {
        "x": new Date(1250467200000),
        "y": 0.7107
    },
    {
        "x": new Date(1250553600000),
        "y": 0.7093
    },
    {
        "x": new Date(1250640000000),
        "y": 0.7087
    },
    {
        "x": new Date(1250726400000),
        "y": 0.7022
    },
    {
        "x": new Date(1250812800000),
        "y": 0.6979
    },
    {
        "x": new Date(1251072000000),
        "y": 0.6983
    },
    {
        "x": new Date(1251158400000),
        "y": 0.6982
    },
    {
        "x": new Date(1251244800000),
        "y": 0.7009
    },
    {
        "x": new Date(1251331200000),
        "y": 0.701
    },
    {
        "x": new Date(1251417600000),
        "y": 0.6963
    },
    {
        "x": new Date(1251676800000),
        "y": 0.7008
    },
    {
        "x": new Date(1251763200000),
        "y": 0.6987
    },
    {
        "x": new Date(1251849600000),
        "y": 0.7033
    },
    {
        "x": new Date(1251936000000),
        "y": 0.6977
    },
    {
        "x": new Date(1252022400000),
        "y": 0.7013
    },
    {
        "x": new Date(1252281600000),
        "y": 0.6979
    },
    {
        "x": new Date(1252368000000),
        "y": 0.691
    },
    {
        "x": new Date(1252454400000),
        "y": 0.6887
    },
    {
        "x": new Date(1252540800000),
        "y": 0.6876
    },
    {
        "x": new Date(1252627200000),
        "y": 0.6853
    },
    {
        "x": new Date(1252886400000),
        "y": 0.6869
    },
    {
        "x": new Date(1252972800000),
        "y": 0.6845
    },
    {
        "x": new Date(1253059200000),
        "y": 0.6817
    },
    {
        "x": new Date(1253145600000),
        "y": 0.6798
    },
    {
        "x": new Date(1253232000000),
        "y": 0.6801
    },
    {
        "x": new Date(1253491200000),
        "y": 0.6823
    },
    {
        "x": new Date(1253577600000),
        "y": 0.6767
    },
    {
        "x": new Date(1253664000000),
        "y": 0.6766
    },
    {
        "x": new Date(1253750400000),
        "y": 0.6772
    },
    {
        "x": new Date(1253836800000),
        "y": 0.6818
    },
    {
        "x": new Date(1254096000000),
        "y": 0.6827
    },
    {
        "x": new Date(1254182400000),
        "y": 0.6874
    },
    {
        "x": new Date(1254268800000),
        "y": 0.683
    },
    {
        "x": new Date(1254355200000),
        "y": 0.6879
    },
    {
        "x": new Date(1254441600000),
        "y": 0.688
    },
    {
        "x": new Date(1254700800000),
        "y": 0.6843
    },
    {
        "x": new Date(1254787200000),
        "y": 0.6794
    },
    {
        "x": new Date(1254873600000),
        "y": 0.6806
    },
    {
        "x": new Date(1254960000000),
        "y": 0.6775
    },
    {
        "x": new Date(1255046400000),
        "y": 0.6781
    },
    {
        "x": new Date(1255305600000),
        "y": 0.6774
    },
    {
        "x": new Date(1255392000000),
        "y": 0.6729
    },
    {
        "x": new Date(1255478400000),
        "y": 0.6721
    },
    {
        "x": new Date(1255564800000),
        "y": 0.6729
    },
    {
        "x": new Date(1255651200000),
        "y": 0.6726
    },
    {
        "x": new Date(1255910400000),
        "y": 0.6704
    },
    {
        "x": new Date(1255996800000),
        "y": 0.6681
    },
    {
        "x": new Date(1256083200000),
        "y": 0.6703
    },
    {
        "x": new Date(1256169600000),
        "y": 0.6668
    },
    {
        "x": new Date(1256256000000),
        "y": 0.6659
    },
    {
        "x": new Date(1256515200000),
        "y": 0.6659
    },
    {
        "x": new Date(1256601600000),
        "y": 0.6724
    },
    {
        "x": new Date(1256688000000),
        "y": 0.6765
    },
    {
        "x": new Date(1256774400000),
        "y": 0.6763
    },
    {
        "x": new Date(1256860800000),
        "y": 0.6758
    },
    {
        "x": new Date(1257120000000),
        "y": 0.6771
    },
    {
        "x": new Date(1257206400000),
        "y": 0.6823
    },
    {
        "x": new Date(1257292800000),
        "y": 0.6776
    },
    {
        "x": new Date(1257379200000),
        "y": 0.6727
    },
    {
        "x": new Date(1257465600000),
        "y": 0.673
    },
    {
        "x": new Date(1257724800000),
        "y": 0.6675
    },
    {
        "x": new Date(1257811200000),
        "y": 0.6683
    },
    {
        "x": new Date(1257897600000),
        "y": 0.6651
    },
    {
        "x": new Date(1257984000000),
        "y": 0.6703
    },
    {
        "x": new Date(1258070400000),
        "y": 0.6727
    },
    {
        "x": new Date(1258329600000),
        "y": 0.6683
    },
    {
        "x": new Date(1258416000000),
        "y": 0.6724
    },
    {
        "x": new Date(1258502400000),
        "y": 0.6687
    },
    {
        "x": new Date(1258588800000),
        "y": 0.6729
    },
    {
        "x": new Date(1258675200000),
        "y": 0.6751
    },
    {
        "x": new Date(1258934400000),
        "y": 0.6682
    },
    {
        "x": new Date(1259020800000),
        "y": 0.6681
    },
    {
        "x": new Date(1259107200000),
        "y": 0.6631
    },
    {
        "x": new Date(1259193600000),
        "y": 0.6636
    },
    {
        "x": new Date(1259280000000),
        "y": 0.6704
    },
    {
        "x": new Date(1259539200000),
        "y": 0.6657
    },
    {
        "x": new Date(1259625600000),
        "y": 0.6635
    },
    {
        "x": new Date(1259712000000),
        "y": 0.6628
    },
    {
        "x": new Date(1259798400000),
        "y": 0.6615
    },
    {
        "x": new Date(1259884800000),
        "y": 0.6638
    },
    {
        "x": new Date(1260144000000),
        "y": 0.6764
    },
    {
        "x": new Date(1260230400000),
        "y": 0.677
    },
    {
        "x": new Date(1260316800000),
        "y": 0.6772
    },
    {
        "x": new Date(1260403200000),
        "y": 0.679
    },
    {
        "x": new Date(1260489600000),
        "y": 0.6777
    },
    {
        "x": new Date(1260748800000),
        "y": 0.6828
    },
    {
        "x": new Date(1260835200000),
        "y": 0.6878
    },
    {
        "x": new Date(1260921600000),
        "y": 0.6869
    },
    {
        "x": new Date(1261008000000),
        "y": 0.6973
    },
    {
        "x": new Date(1261094400000),
        "y": 0.6976
    },
    {
        "x": new Date(1261353600000),
        "y": 0.6961
    },
    {
        "x": new Date(1261440000000),
        "y": 0.7004
    },
    {
        "x": new Date(1261526400000),
        "y": 0.7006
    },
    {
        "x": new Date(1261612800000),
        "y": 0.6946
    },
    {
        "x": new Date(1261699200000),
        "y": 0.6946
    },
    {
        "x": new Date(1261958400000),
        "y": 0.6943
    },
    {
        "x": new Date(1262044800000),
        "y": 0.693
    },
    {
        "x": new Date(1262131200000),
        "y": 0.6975
    },
    {
        "x": new Date(1262217600000),
        "y": 0.6943
    },
    {
        "x": new Date(1262304000000),
        "y": 0.6943
    },
    {
        "x": new Date(1262563200000),
        "y": 0.6951
    },
    {
        "x": new Date(1262649600000),
        "y": 0.6925
    },
    {
        "x": new Date(1262736000000),
        "y": 0.697
    },
    {
        "x": new Date(1262822400000),
        "y": 0.6992
    },
    {
        "x": new Date(1262908800000),
        "y": 0.7007
    },
    {
        "x": new Date(1263168000000),
        "y": 0.6884
    },
    {
        "x": new Date(1263254400000),
        "y": 0.6907
    },
    {
        "x": new Date(1263340800000),
        "y": 0.6868
    },
    {
        "x": new Date(1263427200000),
        "y": 0.6904
    },
    {
        "x": new Date(1263513600000),
        "y": 0.6958
    },
    {
        "x": new Date(1263772800000),
        "y": 0.696
    },
    {
        "x": new Date(1263859200000),
        "y": 0.7004
    },
    {
        "x": new Date(1263945600000),
        "y": 0.7077
    },
    {
        "x": new Date(1264032000000),
        "y": 0.7111
    },
    {
        "x": new Date(1264118400000),
        "y": 0.7076
    },
    {
        "x": new Date(1264377600000),
        "y": 0.7068
    },
    {
        "x": new Date(1264464000000),
        "y": 0.7101
    },
    {
        "x": new Date(1264550400000),
        "y": 0.7107
    },
    {
        "x": new Date(1264636800000),
        "y": 0.7144
    },
    {
        "x": new Date(1264723200000),
        "y": 0.7161
    },
    {
        "x": new Date(1264982400000),
        "y": 0.7189
    },
    {
        "x": new Date(1265068800000),
        "y": 0.7176
    },
    {
        "x": new Date(1265155200000),
        "y": 0.7152
    },
    {
        "x": new Date(1265241600000),
        "y": 0.7223
    },
    {
        "x": new Date(1265328000000),
        "y": 0.7305
    },
    {
        "x": new Date(1265587200000),
        "y": 0.7314
    },
    {
        "x": new Date(1265673600000),
        "y": 0.7268
    },
    {
        "x": new Date(1265760000000),
        "y": 0.7279
    },
    {
        "x": new Date(1265846400000),
        "y": 0.7291
    },
    {
        "x": new Date(1265932800000),
        "y": 0.7369
    },
    {
        "x": new Date(1266192000000),
        "y": 0.735
    },
    {
        "x": new Date(1266278400000),
        "y": 0.7328
    },
    {
        "x": new Date(1266364800000),
        "y": 0.7286
    },
    {
        "x": new Date(1266451200000),
        "y": 0.7372
    },
    {
        "x": new Date(1266537600000),
        "y": 0.7398
    },
    {
        "x": new Date(1266796800000),
        "y": 0.734
    },
    {
        "x": new Date(1266883200000),
        "y": 0.7366
    },
    {
        "x": new Date(1266969600000),
        "y": 0.7383
    },
    {
        "x": new Date(1267056000000),
        "y": 0.7414
    },
    {
        "x": new Date(1267142400000),
        "y": 0.737
    },
    {
        "x": new Date(1267401600000),
        "y": 0.7395
    },
    {
        "x": new Date(1267488000000),
        "y": 0.7382
    },
    {
        "x": new Date(1267574400000),
        "y": 0.7332
    },
    {
        "x": new Date(1267660800000),
        "y": 0.7317
    },
    {
        "x": new Date(1267747200000),
        "y": 0.7364
    },
    {
        "x": new Date(1268006400000),
        "y": 0.7321
    },
    {
        "x": new Date(1268092800000),
        "y": 0.7377
    },
    {
        "x": new Date(1268179200000),
        "y": 0.7349
    },
    {
        "x": new Date(1268265600000),
        "y": 0.7323
    },
    {
        "x": new Date(1268352000000),
        "y": 0.7266
    },
    {
        "x": new Date(1268611200000),
        "y": 0.7298
    },
    {
        "x": new Date(1268697600000),
        "y": 0.7288
    },
    {
        "x": new Date(1268784000000),
        "y": 0.7271
    },
    {
        "x": new Date(1268870400000),
        "y": 0.7322
    },
    {
        "x": new Date(1268956800000),
        "y": 0.7382
    },
    {
        "x": new Date(1269216000000),
        "y": 0.7424
    },
    {
        "x": new Date(1269302400000),
        "y": 0.7398
    },
    {
        "x": new Date(1269388800000),
        "y": 0.7498
    },
    {
        "x": new Date(1269475200000),
        "y": 0.7488
    },
    {
        "x": new Date(1269561600000),
        "y": 0.749
    },
    {
        "x": new Date(1269820800000),
        "y": 0.7424
    },
    {
        "x": new Date(1269907200000),
        "y": 0.7418
    },
    {
        "x": new Date(1269993600000),
        "y": 0.742
    },
    {
        "x": new Date(1270080000000),
        "y": 0.7426
    },
    {
        "x": new Date(1270166400000),
        "y": 0.7426
    },
    {
        "x": new Date(1270425600000),
        "y": 0.7426
    },
    {
        "x": new Date(1270512000000),
        "y": 0.7466
    },
    {
        "x": new Date(1270598400000),
        "y": 0.7497
    },
    {
        "x": new Date(1270684800000),
        "y": 0.7522
    },
    {
        "x": new Date(1270771200000),
        "y": 0.7473
    },
    {
        "x": new Date(1271030400000),
        "y": 0.7362
    },
    {
        "x": new Date(1271116800000),
        "y": 0.7363
    },
    {
        "x": new Date(1271203200000),
        "y": 0.7346
    },
    {
        "x": new Date(1271289600000),
        "y": 0.7384
    },
    {
        "x": new Date(1271376000000),
        "y": 0.7389
    },
    {
        "x": new Date(1271635200000),
        "y": 0.7446
    },
    {
        "x": new Date(1271721600000),
        "y": 0.7416
    },
    {
        "x": new Date(1271808000000),
        "y": 0.7479
    },
    {
        "x": new Date(1271894400000),
        "y": 0.7498
    },
    {
        "x": new Date(1271980800000),
        "y": 0.7514
    },
    {
        "x": new Date(1272240000000),
        "y": 0.7508
    },
    {
        "x": new Date(1272326400000),
        "y": 0.7525
    },
    {
        "x": new Date(1272412800000),
        "y": 0.7551
    },
    {
        "x": new Date(1272499200000),
        "y": 0.7545
    },
    {
        "x": new Date(1272585600000),
        "y": 0.7511
    },
    {
        "x": new Date(1272844800000),
        "y": 0.7555
    },
    {
        "x": new Date(1272931200000),
        "y": 0.7641
    },
    {
        "x": new Date(1273017600000),
        "y": 0.7739
    },
    {
        "x": new Date(1273104000000),
        "y": 0.7858
    },
    {
        "x": new Date(1273190400000),
        "y": 0.7847
    },
    {
        "x": new Date(1273449600000),
        "y": 0.7712
    },
    {
        "x": new Date(1273536000000),
        "y": 0.7876
    },
    {
        "x": new Date(1273622400000),
        "y": 0.7884
    },
    {
        "x": new Date(1273708800000),
        "y": 0.7946
    },
    {
        "x": new Date(1273795200000),
        "y": 0.8006
    },
    {
        "x": new Date(1274054400000),
        "y": 0.8099
    },
    {
        "x": new Date(1274140800000),
        "y": 0.8047
    },
    {
        "x": new Date(1274227200000),
        "y": 0.8151
    },
    {
        "x": new Date(1274313600000),
        "y": 0.8109
    },
    {
        "x": new Date(1274400000000),
        "y": 0.8003
    },
    {
        "x": new Date(1274659200000),
        "y": 0.8092
    },
    {
        "x": new Date(1274745600000),
        "y": 0.8182
    },
    {
        "x": new Date(1274832000000),
        "y": 0.8125
    },
    {
        "x": new Date(1274918400000),
        "y": 0.8161
    },
    {
        "x": new Date(1275004800000),
        "y": 0.8076
    },
    {
        "x": new Date(1275264000000),
        "y": 0.8126
    },
    {
        "x": new Date(1275350400000),
        "y": 0.8228
    },
    {
        "x": new Date(1275436800000),
        "y": 0.8186
    },
    {
        "x": new Date(1275523200000),
        "y": 0.8152
    },
    {
        "x": new Date(1275609600000),
        "y": 0.8293
    },
    {
        "x": new Date(1275868800000),
        "y": 0.8363
    },
    {
        "x": new Date(1275955200000),
        "y": 0.8375
    },
    {
        "x": new Date(1276041600000),
        "y": 0.8327
    },
    {
        "x": new Date(1276128000000),
        "y": 0.8303
    },
    {
        "x": new Date(1276214400000),
        "y": 0.8247
    },
    {
        "x": new Date(1276473600000),
        "y": 0.8165
    },
    {
        "x": new Date(1276560000000),
        "y": 0.8159
    },
    {
        "x": new Date(1276646400000),
        "y": 0.8146
    },
    {
        "x": new Date(1276732800000),
        "y": 0.809
    },
    {
        "x": new Date(1276819200000),
        "y": 0.8084
    },
    {
        "x": new Date(1277078400000),
        "y": 0.8071
    },
    {
        "x": new Date(1277164800000),
        "y": 0.8159
    },
    {
        "x": new Date(1277251200000),
        "y": 0.815
    },
    {
        "x": new Date(1277337600000),
        "y": 0.8156
    },
    {
        "x": new Date(1277424000000),
        "y": 0.8135
    },
    {
        "x": new Date(1277683200000),
        "y": 0.8105
    },
    {
        "x": new Date(1277769600000),
        "y": 0.8199
    },
    {
        "x": new Date(1277856000000),
        "y": 0.815
    },
    {
        "x": new Date(1277942400000),
        "y": 0.8113
    },
    {
        "x": new Date(1278028800000),
        "y": 0.797
    },
    {
        "x": new Date(1278288000000),
        "y": 0.7981
    },
    {
        "x": new Date(1278374400000),
        "y": 0.7951
    },
    {
        "x": new Date(1278460800000),
        "y": 0.7958
    },
    {
        "x": new Date(1278547200000),
        "y": 0.79
    },
    {
        "x": new Date(1278633600000),
        "y": 0.7914
    },
    {
        "x": new Date(1278892800000),
        "y": 0.7955
    },
    {
        "x": new Date(1278979200000),
        "y": 0.7957
    },
    {
        "x": new Date(1279065600000),
        "y": 0.7873
    },
    {
        "x": new Date(1279152000000),
        "y": 0.7796
    },
    {
        "x": new Date(1279238400000),
        "y": 0.7693
    },
    {
        "x": new Date(1279497600000),
        "y": 0.7719
    },
    {
        "x": new Date(1279584000000),
        "y": 0.7787
    },
    {
        "x": new Date(1279670400000),
        "y": 0.7803
    },
    {
        "x": new Date(1279756800000),
        "y": 0.7783
    },
    {
        "x": new Date(1279843200000),
        "y": 0.7755
    },
    {
        "x": new Date(1280102400000),
        "y": 0.7734
    },
    {
        "x": new Date(1280188800000),
        "y": 0.7674
    },
    {
        "x": new Date(1280275200000),
        "y": 0.7698
    },
    {
        "x": new Date(1280361600000),
        "y": 0.7653
    },
    {
        "x": new Date(1280448000000),
        "y": 0.7677
    },
    {
        "x": new Date(1280707200000),
        "y": 0.765
    },
    {
        "x": new Date(1280793600000),
        "y": 0.7565
    },
    {
        "x": new Date(1280880000000),
        "y": 0.7573
    },
    {
        "x": new Date(1280966400000),
        "y": 0.7586
    },
    {
        "x": new Date(1281052800000),
        "y": 0.7591
    },
    {
        "x": new Date(1281312000000),
        "y": 0.7546
    },
    {
        "x": new Date(1281398400000),
        "y": 0.7615
    },
    {
        "x": new Date(1281484800000),
        "y": 0.7684
    },
    {
        "x": new Date(1281571200000),
        "y": 0.782
    },
    {
        "x": new Date(1281657600000),
        "y": 0.7814
    },
    {
        "x": new Date(1281916800000),
        "y": 0.7801
    },
    {
        "x": new Date(1282003200000),
        "y": 0.7777
    },
    {
        "x": new Date(1282089600000),
        "y": 0.7765
    },
    {
        "x": new Date(1282176000000),
        "y": 0.7792
    },
    {
        "x": new Date(1282262400000),
        "y": 0.7868
    },
    {
        "x": new Date(1282521600000),
        "y": 0.7873
    },
    {
        "x": new Date(1282608000000),
        "y": 0.7931
    },
    {
        "x": new Date(1282694400000),
        "y": 0.7929
    },
    {
        "x": new Date(1282780800000),
        "y": 0.7879
    },
    {
        "x": new Date(1282867200000),
        "y": 0.7867
    },
    {
        "x": new Date(1283126400000),
        "y": 0.7875
    },
    {
        "x": new Date(1283212800000),
        "y": 0.7887
    },
    {
        "x": new Date(1283299200000),
        "y": 0.7814
    },
    {
        "x": new Date(1283385600000),
        "y": 0.7803
    },
    {
        "x": new Date(1283472000000),
        "y": 0.7793
    },
    {
        "x": new Date(1283731200000),
        "y": 0.7769
    },
    {
        "x": new Date(1283817600000),
        "y": 0.7848
    },
    {
        "x": new Date(1283904000000),
        "y": 0.7877
    },
    {
        "x": new Date(1283990400000),
        "y": 0.7866
    },
    {
        "x": new Date(1284076800000),
        "y": 0.786
    },
    {
        "x": new Date(1284336000000),
        "y": 0.7813
    },
    {
        "x": new Date(1284422400000),
        "y": 0.7783
    },
    {
        "x": new Date(1284508800000),
        "y": 0.77
    },
    {
        "x": new Date(1284595200000),
        "y": 0.7647
    },
    {
        "x": new Date(1284681600000),
        "y": 0.7658
    },
    {
        "x": new Date(1284940800000),
        "y": 0.765
    },
    {
        "x": new Date(1285027200000),
        "y": 0.7623
    },
    {
        "x": new Date(1285113600000),
        "y": 0.7484
    },
    {
        "x": new Date(1285200000000),
        "y": 0.7507
    },
    {
        "x": new Date(1285286400000),
        "y": 0.7457
    },
    {
        "x": new Date(1285545600000),
        "y": 0.7421
    },
    {
        "x": new Date(1285632000000),
        "y": 0.743
    },
    {
        "x": new Date(1285718400000),
        "y": 0.7348
    },
    {
        "x": new Date(1285804800000),
        "y": 0.7328
    },
    {
        "x": new Date(1285891200000),
        "y": 0.7286
    },
    {
        "x": new Date(1286150400000),
        "y": 0.7298
    },
    {
        "x": new Date(1286236800000),
        "y": 0.7258
    },
    {
        "x": new Date(1286323200000),
        "y": 0.7218
    },
    {
        "x": new Date(1286409600000),
        "y": 0.7159
    },
    {
        "x": new Date(1286496000000),
        "y": 0.7209
    },
    {
        "x": new Date(1286755200000),
        "y": 0.7177
    },
    {
        "x": new Date(1286841600000),
        "y": 0.723
    },
    {
        "x": new Date(1286928000000),
        "y": 0.7165
    },
    {
        "x": new Date(1287014400000),
        "y": 0.7093
    },
    {
        "x": new Date(1287100800000),
        "y": 0.7099
    },
    {
        "x": new Date(1287360000000),
        "y": 0.7197
    },
    {
        "x": new Date(1287446400000),
        "y": 0.7217
    },
    {
        "x": new Date(1287532800000),
        "y": 0.7215
    },
    {
        "x": new Date(1287619200000),
        "y": 0.7136
    },
    {
        "x": new Date(1287705600000),
        "y": 0.7178
    },
    {
        "x": new Date(1287964800000),
        "y": 0.7128
    },
    {
        "x": new Date(1288051200000),
        "y": 0.7189
    },
    {
        "x": new Date(1288137600000),
        "y": 0.7246
    },
    {
        "x": new Date(1288224000000),
        "y": 0.7218
    },
    {
        "x": new Date(1288310400000),
        "y": 0.7218
    },
    {
        "x": new Date(1288569600000),
        "y": 0.7182
    },
    {
        "x": new Date(1288656000000),
        "y": 0.7135
    },
    {
        "x": new Date(1288742400000),
        "y": 0.7137
    },
    {
        "x": new Date(1288828800000),
        "y": 0.7021
    },
    {
        "x": new Date(1288915200000),
        "y": 0.7101
    },
    {
        "x": new Date(1289174400000),
        "y": 0.7186
    },
    {
        "x": new Date(1289260800000),
        "y": 0.7172
    },
    {
        "x": new Date(1289347200000),
        "y": 0.7263
    },
    {
        "x": new Date(1289433600000),
        "y": 0.73
    },
    {
        "x": new Date(1289520000000),
        "y": 0.7294
    },
    {
        "x": new Date(1289779200000),
        "y": 0.734
    },
    {
        "x": new Date(1289865600000),
        "y": 0.7347
    },
    {
        "x": new Date(1289952000000),
        "y": 0.7419
    },
    {
        "x": new Date(1290038400000),
        "y": 0.7329
    },
    {
        "x": new Date(1290124800000),
        "y": 0.7314
    },
    {
        "x": new Date(1290384000000),
        "y": 0.7329
    },
    {
        "x": new Date(1290470400000),
        "y": 0.7411
    },
    {
        "x": new Date(1290556800000),
        "y": 0.7498
    },
    {
        "x": new Date(1290643200000),
        "y": 0.7508
    },
    {
        "x": new Date(1290729600000),
        "y": 0.7562
    },
    {
        "x": new Date(1290988800000),
        "y": 0.7608
    },
    {
        "x": new Date(1291075200000),
        "y": 0.7694
    },
    {
        "x": new Date(1291161600000),
        "y": 0.7626
    },
    {
        "x": new Date(1291248000000),
        "y": 0.7603
    },
    {
        "x": new Date(1291334400000),
        "y": 0.755
    },
    {
        "x": new Date(1291593600000),
        "y": 0.7531
    },
    {
        "x": new Date(1291680000000),
        "y": 0.7484
    },
    {
        "x": new Date(1291766400000),
        "y": 0.7577
    },
    {
        "x": new Date(1291852800000),
        "y": 0.7569
    },
    {
        "x": new Date(1291939200000),
        "y": 0.7552
    },
    {
        "x": new Date(1292198400000),
        "y": 0.7538
    },
    {
        "x": new Date(1292284800000),
        "y": 0.7444
    },
    {
        "x": new Date(1292371200000),
        "y": 0.7486
    },
    {
        "x": new Date(1292457600000),
        "y": 0.7555
    },
    {
        "x": new Date(1292544000000),
        "y": 0.7542
    },
    {
        "x": new Date(1292803200000),
        "y": 0.7607
    },
    {
        "x": new Date(1292889600000),
        "y": 0.7603
    },
    {
        "x": new Date(1292976000000),
        "y": 0.7628
    },
    {
        "x": new Date(1293062400000),
        "y": 0.7656
    },
    {
        "x": new Date(1293148800000),
        "y": 0.7635
    },
    {
        "x": new Date(1293408000000),
        "y": 0.7614
    },
    {
        "x": new Date(1293494400000),
        "y": 0.758
    },
    {
        "x": new Date(1293580800000),
        "y": 0.7614
    },
    {
        "x": new Date(1293667200000),
        "y": 0.7531
    },
    {
        "x": new Date(1293753600000),
        "y": 0.7485
    },
    {
        "x": new Date(1294012800000),
        "y": 0.7493
    },
    {
        "x": new Date(1294099200000),
        "y": 0.7452
    },
    {
        "x": new Date(1294185600000),
        "y": 0.7569
    },
    {
        "x": new Date(1294272000000),
        "y": 0.764
    },
    {
        "x": new Date(1294358400000),
        "y": 0.7716
    },
    {
        "x": new Date(1294617600000),
        "y": 0.7751
    },
    {
        "x": new Date(1294704000000),
        "y": 0.7724
    },
    {
        "x": new Date(1294790400000),
        "y": 0.7709
    },
    {
        "x": new Date(1294876800000),
        "y": 0.7577
    },
    {
        "x": new Date(1294963200000),
        "y": 0.7492
    },
    {
        "x": new Date(1295222400000),
        "y": 0.7514
    },
    {
        "x": new Date(1295308800000),
        "y": 0.748
    },
    {
        "x": new Date(1295395200000),
        "y": 0.7405
    },
    {
        "x": new Date(1295481600000),
        "y": 0.7424
    },
    {
        "x": new Date(1295568000000),
        "y": 0.7397
    },
    {
        "x": new Date(1295827200000),
        "y": 0.737
    },
    {
        "x": new Date(1295913600000),
        "y": 0.7356
    },
    {
        "x": new Date(1296000000000),
        "y": 0.731
    },
    {
        "x": new Date(1296086400000),
        "y": 0.7292
    },
    {
        "x": new Date(1296172800000),
        "y": 0.7295
    },
    {
        "x": new Date(1296432000000),
        "y": 0.7305
    },
    {
        "x": new Date(1296518400000),
        "y": 0.7271
    },
    {
        "x": new Date(1296604800000),
        "y": 0.7246
    },
    {
        "x": new Date(1296691200000),
        "y": 0.7276
    },
    {
        "x": new Date(1296777600000),
        "y": 0.7337
    },
    {
        "x": new Date(1297036800000),
        "y": 0.7379
    },
    {
        "x": new Date(1297123200000),
        "y": 0.7335
    },
    {
        "x": new Date(1297209600000),
        "y": 0.7329
    },
    {
        "x": new Date(1297296000000),
        "y": 0.7352
    },
    {
        "x": new Date(1297382400000),
        "y": 0.7395
    },
    {
        "x": new Date(1297641600000),
        "y": 0.7441
    },
    {
        "x": new Date(1297728000000),
        "y": 0.7403
    },
    {
        "x": new Date(1297814400000),
        "y": 0.7403
    },
    {
        "x": new Date(1297900800000),
        "y": 0.7376
    },
    {
        "x": new Date(1297987200000),
        "y": 0.7339
    },
    {
        "x": new Date(1298246400000),
        "y": 0.7317
    },
    {
        "x": new Date(1298332800000),
        "y": 0.7318
    },
    {
        "x": new Date(1298419200000),
        "y": 0.7284
    },
    {
        "x": new Date(1298505600000),
        "y": 0.7262
    },
    {
        "x": new Date(1298592000000),
        "y": 0.7267
    },
    {
        "x": new Date(1298851200000),
        "y": 0.723
    },
    {
        "x": new Date(1298937600000),
        "y": 0.7234
    },
    {
        "x": new Date(1299024000000),
        "y": 0.7243
    },
    {
        "x": new Date(1299110400000),
        "y": 0.7221
    },
    {
        "x": new Date(1299196800000),
        "y": 0.7166
    },
    {
        "x": new Date(1299456000000),
        "y": 0.713
    },
    {
        "x": new Date(1299542400000),
        "y": 0.7196
    },
    {
        "x": new Date(1299628800000),
        "y": 0.7181
    },
    {
        "x": new Date(1299715200000),
        "y": 0.7238
    },
    {
        "x": new Date(1299801600000),
        "y": 0.7262
    },
    {
        "x": new Date(1300060800000),
        "y": 0.717
    },
    {
        "x": new Date(1300147200000),
        "y": 0.7204
    },
    {
        "x": new Date(1300233600000),
        "y": 0.7169
    },
    {
        "x": new Date(1300320000000),
        "y": 0.7142
    },
    {
        "x": new Date(1300406400000),
        "y": 0.7078
    },
    {
        "x": new Date(1300665600000),
        "y": 0.7046
    },
    {
        "x": new Date(1300752000000),
        "y": 0.7038
    },
    {
        "x": new Date(1300838400000),
        "y": 0.7075
    },
    {
        "x": new Date(1300924800000),
        "y": 0.7079
    },
    {
        "x": new Date(1301011200000),
        "y": 0.7086
    },
    {
        "x": new Date(1301270400000),
        "y": 0.7128
    },
    {
        "x": new Date(1301356800000),
        "y": 0.711
    },
    {
        "x": new Date(1301443200000),
        "y": 0.7098
    },
    {
        "x": new Date(1301529600000),
        "y": 0.704
    },
    {
        "x": new Date(1301616000000),
        "y": 0.7073
    },
    {
        "x": new Date(1301875200000),
        "y": 0.7023
    },
    {
        "x": new Date(1301961600000),
        "y": 0.706
    },
    {
        "x": new Date(1302048000000),
        "y": 0.6994
    },
    {
        "x": new Date(1302134400000),
        "y": 0.7002
    },
    {
        "x": new Date(1302220800000),
        "y": 0.6945
    },
    {
        "x": new Date(1302480000000),
        "y": 0.6929
    },
    {
        "x": new Date(1302566400000),
        "y": 0.6912
    },
    {
        "x": new Date(1302652800000),
        "y": 0.6901
    },
    {
        "x": new Date(1302739200000),
        "y": 0.6945
    },
    {
        "x": new Date(1302825600000),
        "y": 0.6921
    },
    {
        "x": new Date(1303084800000),
        "y": 0.7006
    },
    {
        "x": new Date(1303171200000),
        "y": 0.6993
    },
    {
        "x": new Date(1303257600000),
        "y": 0.689
    },
    {
        "x": new Date(1303344000000),
        "y": 0.6858
    },
    {
        "x": new Date(1303430400000),
        "y": 0.6858
    },
    {
        "x": new Date(1303689600000),
        "y": 0.6858
    },
    {
        "x": new Date(1303776000000),
        "y": 0.6842
    },
    {
        "x": new Date(1303862400000),
        "y": 0.6819
    },
    {
        "x": new Date(1303948800000),
        "y": 0.676
    },
    {
        "x": new Date(1304035200000),
        "y": 0.673
    },
    {
        "x": new Date(1304294400000),
        "y": 0.6741
    },
    {
        "x": new Date(1304380800000),
        "y": 0.6767
    },
    {
        "x": new Date(1304467200000),
        "y": 0.6721
    },
    {
        "x": new Date(1304553600000),
        "y": 0.6751
    },
    {
        "x": new Date(1304640000000),
        "y": 0.6897
    },
    {
        "x": new Date(1304899200000),
        "y": 0.6947
    },
    {
        "x": new Date(1304985600000),
        "y": 0.6966
    },
    {
        "x": new Date(1305072000000),
        "y": 0.6966
    },
    {
        "x": new Date(1305158400000),
        "y": 0.7067
    },
    {
        "x": new Date(1305244800000),
        "y": 0.7004
    },
    {
        "x": new Date(1305504000000),
        "y": 0.7072
    },
    {
        "x": new Date(1305590400000),
        "y": 0.7058
    },
    {
        "x": new Date(1305676800000),
        "y": 0.703
    },
    {
        "x": new Date(1305763200000),
        "y": 0.7011
    },
    {
        "x": new Date(1305849600000),
        "y": 0.7025
    },
    {
        "x": new Date(1306108800000),
        "y": 0.7134
    },
    {
        "x": new Date(1306195200000),
        "y": 0.7099
    },
    {
        "x": new Date(1306281600000),
        "y": 0.7109
    },
    {
        "x": new Date(1306368000000),
        "y": 0.7059
    },
    {
        "x": new Date(1306454400000),
        "y": 0.7011
    },
    {
        "x": new Date(1306713600000),
        "y": 0.7008
    },
    {
        "x": new Date(1306800000000),
        "y": 0.6953
    },
    {
        "x": new Date(1306886400000),
        "y": 0.6942
    },
    {
        "x": new Date(1306972800000),
        "y": 0.6917
    },
    {
        "x": new Date(1307059200000),
        "y": 0.6903
    },
    {
        "x": new Date(1307318400000),
        "y": 0.6852
    },
    {
        "x": new Date(1307404800000),
        "y": 0.6826
    },
    {
        "x": new Date(1307491200000),
        "y": 0.6847
    },
    {
        "x": new Date(1307577600000),
        "y": 0.6844
    },
    {
        "x": new Date(1307664000000),
        "y": 0.6904
    },
    {
        "x": new Date(1307923200000),
        "y": 0.6968
    },
    {
        "x": new Date(1308009600000),
        "y": 0.6922
    },
    {
        "x": new Date(1308096000000),
        "y": 0.6998
    },
    {
        "x": new Date(1308182400000),
        "y": 0.7099
    },
    {
        "x": new Date(1308268800000),
        "y": 0.7009
    },
    {
        "x": new Date(1308528000000),
        "y": 0.7026
    },
    {
        "x": new Date(1308614400000),
        "y": 0.6958
    },
    {
        "x": new Date(1308700800000),
        "y": 0.6947
    },
    {
        "x": new Date(1308787200000),
        "y": 0.7037
    },
    {
        "x": new Date(1308873600000),
        "y": 0.7033
    },
    {
        "x": new Date(1309132800000),
        "y": 0.7041
    },
    {
        "x": new Date(1309219200000),
        "y": 0.7013
    },
    {
        "x": new Date(1309305600000),
        "y": 0.6933
    },
    {
        "x": new Date(1309392000000),
        "y": 0.692
    },
    {
        "x": new Date(1309478400000),
        "y": 0.6903
    },
    {
        "x": new Date(1309737600000),
        "y": 0.6898
    },
    {
        "x": new Date(1309824000000),
        "y": 0.6916
    },
    {
        "x": new Date(1309910400000),
        "y": 0.6985
    },
    {
        "x": new Date(1309996800000),
        "y": 0.702
    },
    {
        "x": new Date(1310083200000),
        "y": 0.7022
    },
    {
        "x": new Date(1310342400000),
        "y": 0.7115
    },
    {
        "x": new Date(1310428800000),
        "y": 0.7157
    },
    {
        "x": new Date(1310515200000),
        "y": 0.7107
    },
    {
        "x": new Date(1310601600000),
        "y": 0.7042
    },
    {
        "x": new Date(1310688000000),
        "y": 0.707
    },
    {
        "x": new Date(1310947200000),
        "y": 0.7121
    },
    {
        "x": new Date(1311033600000),
        "y": 0.7063
    },
    {
        "x": new Date(1311120000000),
        "y": 0.704
    },
    {
        "x": new Date(1311206400000),
        "y": 0.7032
    },
    {
        "x": new Date(1311292800000),
        "y": 0.695
    },
    {
        "x": new Date(1311552000000),
        "y": 0.6955
    },
    {
        "x": new Date(1311638400000),
        "y": 0.6911
    },
    {
        "x": new Date(1311724800000),
        "y": 0.6923
    },
    {
        "x": new Date(1311811200000),
        "y": 0.7014
    },
    {
        "x": new Date(1311897600000),
        "y": 0.7014
    },
    {
        "x": new Date(1312156800000),
        "y": 0.6938
    },
    {
        "x": new Date(1312243200000),
        "y": 0.7058
    },
    {
        "x": new Date(1312329600000),
        "y": 0.6994
    },
    {
        "x": new Date(1312416000000),
        "y": 0.7029
    },
    {
        "x": new Date(1312502400000),
        "y": 0.7066
    },
    {
        "x": new Date(1312761600000),
        "y": 0.7031
    },
    {
        "x": new Date(1312848000000),
        "y": 0.701
    },
    {
        "x": new Date(1312934400000),
        "y": 0.6961
    },
    {
        "x": new Date(1313020800000),
        "y": 0.7072
    },
    {
        "x": new Date(1313107200000),
        "y": 0.7019
    },
    {
        "x": new Date(1313366400000),
        "y": 0.699
    },
    {
        "x": new Date(1313452800000),
        "y": 0.6965
    },
    {
        "x": new Date(1313539200000),
        "y": 0.6909
    },
    {
        "x": new Date(1313625600000),
        "y": 0.696
    },
    {
        "x": new Date(1313712000000),
        "y": 0.6953
    },
    {
        "x": new Date(1313971200000),
        "y": 0.6939
    },
    {
        "x": new Date(1314057600000),
        "y": 0.6916
    },
    {
        "x": new Date(1314144000000),
        "y": 0.693
    },
    {
        "x": new Date(1314230400000),
        "y": 0.6934
    },
    {
        "x": new Date(1314316800000),
        "y": 0.6944
    },
    {
        "x": new Date(1314576000000),
        "y": 0.6904
    },
    {
        "x": new Date(1314662400000),
        "y": 0.6944
    },
    {
        "x": new Date(1314748800000),
        "y": 0.6921
    },
    {
        "x": new Date(1314835200000),
        "y": 0.7001
    },
    {
        "x": new Date(1314921600000),
        "y": 0.7016
    },
    {
        "x": new Date(1315180800000),
        "y": 0.708
    },
    {
        "x": new Date(1315267200000),
        "y": 0.7094
    },
    {
        "x": new Date(1315353600000),
        "y": 0.7126
    },
    {
        "x": new Date(1315440000000),
        "y": 0.7121
    },
    {
        "x": new Date(1315526400000),
        "y": 0.7238
    },
    {
        "x": new Date(1315785600000),
        "y": 0.7324
    },
    {
        "x": new Date(1315872000000),
        "y": 0.733
    },
    {
        "x": new Date(1315958400000),
        "y": 0.7285
    },
    {
        "x": new Date(1316044800000),
        "y": 0.725
    },
    {
        "x": new Date(1316131200000),
        "y": 0.7268
    },
    {
        "x": new Date(1316390400000),
        "y": 0.7332
    },
    {
        "x": new Date(1316476800000),
        "y": 0.7295
    },
    {
        "x": new Date(1316563200000),
        "y": 0.7335
    },
    {
        "x": new Date(1316649600000),
        "y": 0.7437
    },
    {
        "x": new Date(1316736000000),
        "y": 0.7447
    },
    {
        "x": new Date(1316995200000),
        "y": 0.7408
    },
    {
        "x": new Date(1317081600000),
        "y": 0.7365
    },
    {
        "x": new Date(1317168000000),
        "y": 0.7337
    },
    {
        "x": new Date(1317254400000),
        "y": 0.7346
    },
    {
        "x": new Date(1317340800000),
        "y": 0.7407
    },
    {
        "x": new Date(1317600000000),
        "y": 0.7505
    },
    {
        "x": new Date(1317686400000),
        "y": 0.7588
    },
    {
        "x": new Date(1317772800000),
        "y": 0.7499
    },
    {
        "x": new Date(1317859200000),
        "y": 0.7537
    },
    {
        "x": new Date(1317945600000),
        "y": 0.7445
    },
    {
        "x": new Date(1318204800000),
        "y": 0.7358
    },
    {
        "x": new Date(1318291200000),
        "y": 0.735
    },
    {
        "x": new Date(1318377600000),
        "y": 0.7265
    },
    {
        "x": new Date(1318464000000),
        "y": 0.7286
    },
    {
        "x": new Date(1318550400000),
        "y": 0.7244
    },
    {
        "x": new Date(1318809600000),
        "y": 0.726
    },
    {
        "x": new Date(1318896000000),
        "y": 0.7313
    },
    {
        "x": new Date(1318982400000),
        "y": 0.7233
    },
    {
        "x": new Date(1319068800000),
        "y": 0.7244
    },
    {
        "x": new Date(1319155200000),
        "y": 0.7248
    },
    {
        "x": new Date(1319414400000),
        "y": 0.7218
    },
    {
        "x": new Date(1319500800000),
        "y": 0.7186
    },
    {
        "x": new Date(1319587200000),
        "y": 0.7181
    },
    {
        "x": new Date(1319673600000),
        "y": 0.7125
    },
    {
        "x": new Date(1319760000000),
        "y": 0.7063
    },
    {
        "x": new Date(1320019200000),
        "y": 0.7143
    },
    {
        "x": new Date(1320105600000),
        "y": 0.7339
    },
    {
        "x": new Date(1320192000000),
        "y": 0.7243
    },
    {
        "x": new Date(1320278400000),
        "y": 0.7262
    },
    {
        "x": new Date(1320364800000),
        "y": 0.7262
    },
    {
        "x": new Date(1320624000000),
        "y": 0.7278
    },
    {
        "x": new Date(1320710400000),
        "y": 0.7254
    },
    {
        "x": new Date(1320796800000),
        "y": 0.7336
    },
    {
        "x": new Date(1320883200000),
        "y": 0.7345
    },
    {
        "x": new Date(1320969600000),
        "y": 0.7327
    },
    {
        "x": new Date(1321228800000),
        "y": 0.7322
    },
    {
        "x": new Date(1321315200000),
        "y": 0.7391
    },
    {
        "x": new Date(1321401600000),
        "y": 0.7417
    },
    {
        "x": new Date(1321488000000),
        "y": 0.7419
    },
    {
        "x": new Date(1321574400000),
        "y": 0.7367
    },
    {
        "x": new Date(1321833600000),
        "y": 0.7432
    },
    {
        "x": new Date(1321920000000),
        "y": 0.7389
    },
    {
        "x": new Date(1322006400000),
        "y": 0.7471
    },
    {
        "x": new Date(1322092800000),
        "y": 0.7479
    },
    {
        "x": new Date(1322179200000),
        "y": 0.756
    },
    {
        "x": new Date(1322438400000),
        "y": 0.7493
    },
    {
        "x": new Date(1322524800000),
        "y": 0.75
    },
    {
        "x": new Date(1322611200000),
        "y": 0.7454
    },
    {
        "x": new Date(1322697600000),
        "y": 0.7413
    },
    {
        "x": new Date(1322784000000),
        "y": 0.7402
    },
    {
        "x": new Date(1323043200000),
        "y": 0.744
    },
    {
        "x": new Date(1323129600000),
        "y": 0.7467
    },
    {
        "x": new Date(1323216000000),
        "y": 0.7477
    },
    {
        "x": new Date(1323302400000),
        "y": 0.7458
    },
    {
        "x": new Date(1323388800000),
        "y": 0.7473
    },
    {
        "x": new Date(1323648000000),
        "y": 0.7548
    },
    {
        "x": new Date(1323734400000),
        "y": 0.7588
    },
    {
        "x": new Date(1323820800000),
        "y": 0.7697
    },
    {
        "x": new Date(1323907200000),
        "y": 0.7682
    },
    {
        "x": new Date(1323993600000),
        "y": 0.7656
    },
    {
        "x": new Date(1324252800000),
        "y": 0.767
    },
    {
        "x": new Date(1324339200000),
        "y": 0.765
    },
    {
        "x": new Date(1324425600000),
        "y": 0.7661
    },
    {
        "x": new Date(1324512000000),
        "y": 0.7666
    },
    {
        "x": new Date(1324598400000),
        "y": 0.766
    },
    {
        "x": new Date(1324857600000),
        "y": 0.766
    },
    {
        "x": new Date(1324944000000),
        "y": 0.7653
    },
    {
        "x": new Date(1325030400000),
        "y": 0.765
    },
    {
        "x": new Date(1325116800000),
        "y": 0.776
    },
    {
        "x": new Date(1325203200000),
        "y": 0.773
    },
    {
        "x": new Date(1325462400000),
        "y": 0.7732
    },
    {
        "x": new Date(1325548800000),
        "y": 0.7685
    },
    {
        "x": new Date(1325635200000),
        "y": 0.7724
    },
    {
        "x": new Date(1325721600000),
        "y": 0.7794
    },
    {
        "x": new Date(1325808000000),
        "y": 0.7828
    },
    {
        "x": new Date(1326067200000),
        "y": 0.7858
    },
    {
        "x": new Date(1326153600000),
        "y": 0.7809
    },
    {
        "x": new Date(1326240000000),
        "y": 0.7864
    },
    {
        "x": new Date(1326326400000),
        "y": 0.7853
    },
    {
        "x": new Date(1326412800000),
        "y": 0.7831
    },
    {
        "x": new Date(1326672000000),
        "y": 0.7894
    },
    {
        "x": new Date(1326758400000),
        "y": 0.782
    },
    {
        "x": new Date(1326844800000),
        "y": 0.7795
    },
    {
        "x": new Date(1326931200000),
        "y": 0.7746
    },
    {
        "x": new Date(1327017600000),
        "y": 0.7752
    },
    {
        "x": new Date(1327276800000),
        "y": 0.7683
    },
    {
        "x": new Date(1327363200000),
        "y": 0.7692
    },
    {
        "x": new Date(1327449600000),
        "y": 0.7728
    },
    {
        "x": new Date(1327536000000),
        "y": 0.7608
    },
    {
        "x": new Date(1327622400000),
        "y": 0.7608
    },
    {
        "x": new Date(1327881600000),
        "y": 0.7629
    },
    {
        "x": new Date(1327968000000),
        "y": 0.7591
    },
    {
        "x": new Date(1328054400000),
        "y": 0.7591
    },
    {
        "x": new Date(1328140800000),
        "y": 0.7638
    },
    {
        "x": new Date(1328227200000),
        "y": 0.76
    },
    {
        "x": new Date(1328486400000),
        "y": 0.7669
    },
    {
        "x": new Date(1328572800000),
        "y": 0.7627
    },
    {
        "x": new Date(1328659200000),
        "y": 0.7535
    },
    {
        "x": new Date(1328745600000),
        "y": 0.7527
    },
    {
        "x": new Date(1328832000000),
        "y": 0.7583
    },
    {
        "x": new Date(1329091200000),
        "y": 0.7546
    },
    {
        "x": new Date(1329177600000),
        "y": 0.7595
    },
    {
        "x": new Date(1329264000000),
        "y": 0.7639
    },
    {
        "x": new Date(1329350400000),
        "y": 0.7704
    },
    {
        "x": new Date(1329436800000),
        "y": 0.76
    },
    {
        "x": new Date(1329696000000),
        "y": 0.7539
    },
    {
        "x": new Date(1329782400000),
        "y": 0.7564
    },
    {
        "x": new Date(1329868800000),
        "y": 0.756
    },
    {
        "x": new Date(1329955200000),
        "y": 0.752
    },
    {
        "x": new Date(1330041600000),
        "y": 0.7457
    },
    {
        "x": new Date(1330300800000),
        "y": 0.747
    },
    {
        "x": new Date(1330387200000),
        "y": 0.7434
    },
    {
        "x": new Date(1330473600000),
        "y": 0.744
    },
    {
        "x": new Date(1330560000000),
        "y": 0.7513
    },
    {
        "x": new Date(1330646400000),
        "y": 0.7567
    },
    {
        "x": new Date(1330905600000),
        "y": 0.7565
    },
    {
        "x": new Date(1330992000000),
        "y": 0.7604
    },
    {
        "x": new Date(1331078400000),
        "y": 0.7623
    },
    {
        "x": new Date(1331164800000),
        "y": 0.7553
    },
    {
        "x": new Date(1331251200000),
        "y": 0.7582
    },
    {
        "x": new Date(1331510400000),
        "y": 0.7624
    },
    {
        "x": new Date(1331596800000),
        "y": 0.766
    },
    {
        "x": new Date(1331683200000),
        "y": 0.7657
    },
    {
        "x": new Date(1331769600000),
        "y": 0.766
    },
    {
        "x": new Date(1331856000000),
        "y": 0.7625
    },
    {
        "x": new Date(1332115200000),
        "y": 0.7606
    },
    {
        "x": new Date(1332201600000),
        "y": 0.7578
    },
    {
        "x": new Date(1332288000000),
        "y": 0.7562
    },
    {
        "x": new Date(1332374400000),
        "y": 0.7596
    },
    {
        "x": new Date(1332460800000),
        "y": 0.7553
    },
    {
        "x": new Date(1332720000000),
        "y": 0.7533
    },
    {
        "x": new Date(1332806400000),
        "y": 0.7501
    },
    {
        "x": new Date(1332892800000),
        "y": 0.7499
    },
    {
        "x": new Date(1332979200000),
        "y": 0.7536
    },
    {
        "x": new Date(1333065600000),
        "y": 0.7488
    },
    {
        "x": new Date(1333324800000),
        "y": 0.7509
    },
    {
        "x": new Date(1333411200000),
        "y": 0.7511
    },
    {
        "x": new Date(1333497600000),
        "y": 0.761
    },
    {
        "x": new Date(1333584000000),
        "y": 0.7653
    },
    {
        "x": new Date(1333670400000),
        "y": 0.7653
    },
    {
        "x": new Date(1333929600000),
        "y": 0.7653
    },
    {
        "x": new Date(1334016000000),
        "y": 0.7626
    },
    {
        "x": new Date(1334102400000),
        "y": 0.7617
    },
    {
        "x": new Date(1334188800000),
        "y": 0.7604
    },
    {
        "x": new Date(1334275200000),
        "y": 0.7607
    },
    {
        "x": new Date(1334534400000),
        "y": 0.7679
    },
    {
        "x": new Date(1334620800000),
        "y": 0.7616
    },
    {
        "x": new Date(1334707200000),
        "y": 0.7639
    },
    {
        "x": new Date(1334793600000),
        "y": 0.7643
    },
    {
        "x": new Date(1334880000000),
        "y": 0.7581
    },
    {
        "x": new Date(1335139200000),
        "y": 0.7617
    },
    {
        "x": new Date(1335225600000),
        "y": 0.7599
    },
    {
        "x": new Date(1335312000000),
        "y": 0.7573
    },
    {
        "x": new Date(1335398400000),
        "y": 0.7568
    },
    {
        "x": new Date(1335484800000),
        "y": 0.756
    },
    {
        "x": new Date(1335744000000),
        "y": 0.7569
    },
    {
        "x": new Date(1335830400000),
        "y": 0.7569
    },
    {
        "x": new Date(1335916800000),
        "y": 0.7617
    },
    {
        "x": new Date(1336003200000),
        "y": 0.7621
    },
    {
        "x": new Date(1336089600000),
        "y": 0.7616
    },
    {
        "x": new Date(1336348800000),
        "y": 0.7674
    },
    {
        "x": new Date(1336435200000),
        "y": 0.7679
    },
    {
        "x": new Date(1336521600000),
        "y": 0.7723
    },
    {
        "x": new Date(1336608000000),
        "y": 0.7716
    },
    {
        "x": new Date(1336694400000),
        "y": 0.7727
    },
    {
        "x": new Date(1336953600000),
        "y": 0.7775
    },
    {
        "x": new Date(1337040000000),
        "y": 0.7787
    },
    {
        "x": new Date(1337126400000),
        "y": 0.7852
    },
    {
        "x": new Date(1337212800000),
        "y": 0.7886
    },
    {
        "x": new Date(1337299200000),
        "y": 0.7862
    },
    {
        "x": new Date(1337558400000),
        "y": 0.7844
    },
    {
        "x": new Date(1337644800000),
        "y": 0.7833
    },
    {
        "x": new Date(1337731200000),
        "y": 0.7901
    },
    {
        "x": new Date(1337817600000),
        "y": 0.7965
    },
    {
        "x": new Date(1337904000000),
        "y": 0.7972
    },
    {
        "x": new Date(1338163200000),
        "y": 0.7959
    },
    {
        "x": new Date(1338249600000),
        "y": 0.7986
    },
    {
        "x": new Date(1338336000000),
        "y": 0.8041
    },
    {
        "x": new Date(1338422400000),
        "y": 0.8064
    },
    {
        "x": new Date(1338508800000),
        "y": 0.8117
    },
    {
        "x": new Date(1338768000000),
        "y": 0.8042
    },
    {
        "x": new Date(1338854400000),
        "y": 0.8047
    },
    {
        "x": new Date(1338940800000),
        "y": 0.8011
    },
    {
        "x": new Date(1339027200000),
        "y": 0.7941
    },
    {
        "x": new Date(1339113600000),
        "y": 0.8022
    },
    {
        "x": new Date(1339372800000),
        "y": 0.7973
    },
    {
        "x": new Date(1339459200000),
        "y": 0.8006
    },
    {
        "x": new Date(1339545600000),
        "y": 0.7979
    },
    {
        "x": new Date(1339632000000),
        "y": 0.7968
    },
    {
        "x": new Date(1339718400000),
        "y": 0.794
    },
    {
        "x": new Date(1339977600000),
        "y": 0.7926
    },
    {
        "x": new Date(1340064000000),
        "y": 0.7926
    },
    {
        "x": new Date(1340150400000),
        "y": 0.7873
    },
    {
        "x": new Date(1340236800000),
        "y": 0.7894
    },
    {
        "x": new Date(1340323200000),
        "y": 0.7976
    },
    {
        "x": new Date(1340582400000),
        "y": 0.8009
    },
    {
        "x": new Date(1340668800000),
        "y": 0.8017
    },
    {
        "x": new Date(1340755200000),
        "y": 0.8015
    },
    {
        "x": new Date(1340841600000),
        "y": 0.8054
    },
    {
        "x": new Date(1340928000000),
        "y": 0.7944
    },
    {
        "x": new Date(1341187200000),
        "y": 0.7942
    },
    {
        "x": new Date(1341273600000),
        "y": 0.7953
    },
    {
        "x": new Date(1341360000000),
        "y": 0.7963
    },
    {
        "x": new Date(1341446400000),
        "y": 0.8049
    },
    {
        "x": new Date(1341532800000),
        "y": 0.8081
    },
    {
        "x": new Date(1341792000000),
        "y": 0.8136
    },
    {
        "x": new Date(1341878400000),
        "y": 0.8141
    },
    {
        "x": new Date(1341964800000),
        "y": 0.8158
    },
    {
        "x": new Date(1342051200000),
        "y": 0.8213
    },
    {
        "x": new Date(1342137600000),
        "y": 0.8208
    },
    {
        "x": new Date(1342396800000),
        "y": 0.8213
    },
    {
        "x": new Date(1342483200000),
        "y": 0.8144
    },
    {
        "x": new Date(1342569600000),
        "y": 0.8175
    },
    {
        "x": new Date(1342656000000),
        "y": 0.814
    },
    {
        "x": new Date(1342742400000),
        "y": 0.8198
    },
    {
        "x": new Date(1343001600000),
        "y": 0.8262
    },
    {
        "x": new Date(1343088000000),
        "y": 0.8273
    },
    {
        "x": new Date(1343174400000),
        "y": 0.8242
    },
    {
        "x": new Date(1343260800000),
        "y": 0.8158
    },
    {
        "x": new Date(1343347200000),
        "y": 0.812
    },
    {
        "x": new Date(1343606400000),
        "y": 0.8167
    },
    {
        "x": new Date(1343692800000),
        "y": 0.8142
    },
    {
        "x": new Date(1343779200000),
        "y": 0.8132
    },
    {
        "x": new Date(1343865600000),
        "y": 0.8101
    },
    {
        "x": new Date(1343952000000),
        "y": 0.8168
    },
    {
        "x": new Date(1344211200000),
        "y": 0.8079
    },
    {
        "x": new Date(1344297600000),
        "y": 0.8042
    },
    {
        "x": new Date(1344384000000),
        "y": 0.8107
    },
    {
        "x": new Date(1344470400000),
        "y": 0.813
    },
    {
        "x": new Date(1344556800000),
        "y": 0.8156
    },
    {
        "x": new Date(1344816000000),
        "y": 0.8105
    },
    {
        "x": new Date(1344902400000),
        "y": 0.8097
    },
    {
        "x": new Date(1344988800000),
        "y": 0.8147
    },
    {
        "x": new Date(1345075200000),
        "y": 0.8145
    },
    {
        "x": new Date(1345161600000),
        "y": 0.8107
    },
    {
        "x": new Date(1345420800000),
        "y": 0.8131
    },
    {
        "x": new Date(1345507200000),
        "y": 0.8047
    },
    {
        "x": new Date(1345593600000),
        "y": 0.8034
    },
    {
        "x": new Date(1345680000000),
        "y": 0.7968
    },
    {
        "x": new Date(1345766400000),
        "y": 0.7997
    },
    {
        "x": new Date(1346025600000),
        "y": 0.7982
    },
    {
        "x": new Date(1346112000000),
        "y": 0.797
    },
    {
        "x": new Date(1346198400000),
        "y": 0.7972
    },
    {
        "x": new Date(1346284800000),
        "y": 0.7973
    },
    {
        "x": new Date(1346371200000),
        "y": 0.7931
    },
    {
        "x": new Date(1346630400000),
        "y": 0.7958
    },
    {
        "x": new Date(1346716800000),
        "y": 0.7951
    },
    {
        "x": new Date(1346803200000),
        "y": 0.7951
    },
    {
        "x": new Date(1346889600000),
        "y": 0.7914
    },
    {
        "x": new Date(1346976000000),
        "y": 0.7871
    },
    {
        "x": new Date(1347235200000),
        "y": 0.7828
    },
    {
        "x": new Date(1347321600000),
        "y": 0.7821
    },
    {
        "x": new Date(1347408000000),
        "y": 0.7755
    },
    {
        "x": new Date(1347494400000),
        "y": 0.7747
    },
    {
        "x": new Date(1347580800000),
        "y": 0.7638
    },
    {
        "x": new Date(1347840000000),
        "y": 0.7643
    },
    {
        "x": new Date(1347926400000),
        "y": 0.7661
    },
    {
        "x": new Date(1348012800000),
        "y": 0.7692
    },
    {
        "x": new Date(1348099200000),
        "y": 0.7721
    },
    {
        "x": new Date(1348185600000),
        "y": 0.77
    },
    {
        "x": new Date(1348444800000),
        "y": 0.7743
    },
    {
        "x": new Date(1348531200000),
        "y": 0.7734
    },
    {
        "x": new Date(1348617600000),
        "y": 0.7786
    },
    {
        "x": new Date(1348704000000),
        "y": 0.7769
    },
    {
        "x": new Date(1348790400000),
        "y": 0.7735
    },
    {
        "x": new Date(1349049600000),
        "y": 0.7767
    },
    {
        "x": new Date(1349136000000),
        "y": 0.7735
    },
    {
        "x": new Date(1349222400000),
        "y": 0.7751
    },
    {
        "x": new Date(1349308800000),
        "y": 0.7722
    },
    {
        "x": new Date(1349395200000),
        "y": 0.7692
    },
    {
        "x": new Date(1349654400000),
        "y": 0.7718
    },
    {
        "x": new Date(1349740800000),
        "y": 0.7721
    },
    {
        "x": new Date(1349827200000),
        "y": 0.776
    },
    {
        "x": new Date(1349913600000),
        "y": 0.7742
    },
    {
        "x": new Date(1350000000000),
        "y": 0.7711
    },
    {
        "x": new Date(1350259200000),
        "y": 0.7711
    },
    {
        "x": new Date(1350345600000),
        "y": 0.7666
    },
    {
        "x": new Date(1350432000000),
        "y": 0.7623
    },
    {
        "x": new Date(1350518400000),
        "y": 0.7624
    },
    {
        "x": new Date(1350604800000),
        "y": 0.7673
    },
    {
        "x": new Date(1350864000000),
        "y": 0.7656
    },
    {
        "x": new Date(1350950400000),
        "y": 0.769
    },
    {
        "x": new Date(1351036800000),
        "y": 0.7728
    },
    {
        "x": new Date(1351123200000),
        "y": 0.7697
    },
    {
        "x": new Date(1351209600000),
        "y": 0.7748
    },
    {
        "x": new Date(1351468800000),
        "y": 0.7754
    },
    {
        "x": new Date(1351555200000),
        "y": 0.7716
    },
    {
        "x": new Date(1351641600000),
        "y": 0.7697
    },
    {
        "x": new Date(1351728000000),
        "y": 0.7708
    },
    {
        "x": new Date(1351814400000),
        "y": 0.7783
    },
    {
        "x": new Date(1352073600000),
        "y": 0.7828
    },
    {
        "x": new Date(1352160000000),
        "y": 0.7814
    },
    {
        "x": new Date(1352246400000),
        "y": 0.7847
    },
    {
        "x": new Date(1352332800000),
        "y": 0.7853
    },
    {
        "x": new Date(1352419200000),
        "y": 0.7879
    },
    {
        "x": new Date(1352678400000),
        "y": 0.7853
    },
    {
        "x": new Date(1352764800000),
        "y": 0.7877
    },
    {
        "x": new Date(1352851200000),
        "y": 0.7859
    },
    {
        "x": new Date(1352937600000),
        "y": 0.784
    },
    {
        "x": new Date(1353024000000),
        "y": 0.7847
    },
    {
        "x": new Date(1353283200000),
        "y": 0.7837
    },
    {
        "x": new Date(1353369600000),
        "y": 0.7808
    },
    {
        "x": new Date(1353456000000),
        "y": 0.781
    },
    {
        "x": new Date(1353542400000),
        "y": 0.7757
    },
    {
        "x": new Date(1353628800000),
        "y": 0.7748
    },
    {
        "x": new Date(1353888000000),
        "y": 0.7715
    },
    {
        "x": new Date(1353974400000),
        "y": 0.7716
    },
    {
        "x": new Date(1354060800000),
        "y": 0.7758
    },
    {
        "x": new Date(1354147200000),
        "y": 0.7697
    },
    {
        "x": new Date(1354233600000),
        "y": 0.7702
    },
    {
        "x": new Date(1354492800000),
        "y": 0.766
    },
    {
        "x": new Date(1354579200000),
        "y": 0.7639
    },
    {
        "x": new Date(1354665600000),
        "y": 0.7655
    },
    {
        "x": new Date(1354752000000),
        "y": 0.7651
    },
    {
        "x": new Date(1354838400000),
        "y": 0.775
    },
    {
        "x": new Date(1355097600000),
        "y": 0.7735
    },
    {
        "x": new Date(1355184000000),
        "y": 0.7697
    },
    {
        "x": new Date(1355270400000),
        "y": 0.767
    },
    {
        "x": new Date(1355356800000),
        "y": 0.7648
    },
    {
        "x": new Date(1355443200000),
        "y": 0.7646
    },
    {
        "x": new Date(1355702400000),
        "y": 0.76
    },
    {
        "x": new Date(1355788800000),
        "y": 0.7589
    },
    {
        "x": new Date(1355875200000),
        "y": 0.7519
    },
    {
        "x": new Date(1355961600000),
        "y": 0.755
    },
    {
        "x": new Date(1356048000000),
        "y": 0.7572
    },
    {
        "x": new Date(1356307200000),
        "y": 0.7566
    },
    {
        "x": new Date(1356566400000),
        "y": 0.7539
    },
    {
        "x": new Date(1356652800000),
        "y": 0.7587
    },
    {
        "x": new Date(1356912000000),
        "y": 0.758
    },
    {
        "x": new Date(1357084800000),
        "y": 0.7541
    },
    {
        "x": new Date(1357171200000),
        "y": 0.7633
    },
    {
        "x": new Date(1357257600000),
        "y": 0.7686
    },
    {
        "x": new Date(1357516800000),
        "y": 0.767
    },
    {
        "x": new Date(1357603200000),
        "y": 0.7643
    },
    {
        "x": new Date(1357689600000),
        "y": 0.766
    },
    {
        "x": new Date(1357776000000),
        "y": 0.7627
    },
    {
        "x": new Date(1357862400000),
        "y": 0.7535
    },
    {
        "x": new Date(1358121600000),
        "y": 0.7497
    },
    {
        "x": new Date(1358208000000),
        "y": 0.7505
    },
    {
        "x": new Date(1358294400000),
        "y": 0.7533
    },
    {
        "x": new Date(1358380800000),
        "y": 0.7482
    },
    {
        "x": new Date(1358467200000),
        "y": 0.7506
    },
    {
        "x": new Date(1358726400000),
        "y": 0.7507
    },
    {
        "x": new Date(1358812800000),
        "y": 0.751
    },
    {
        "x": new Date(1358899200000),
        "y": 0.7503
    },
    {
        "x": new Date(1358985600000),
        "y": 0.7492
    },
    {
        "x": new Date(1359072000000),
        "y": 0.7425
    },
    {
        "x": new Date(1359331200000),
        "y": 0.7439
    },
    {
        "x": new Date(1359417600000),
        "y": 0.7445
    },
    {
        "x": new Date(1359504000000),
        "y": 0.7386
    },
    {
        "x": new Date(1359590400000),
        "y": 0.7381
    },
    {
        "x": new Date(1359676800000),
        "y": 0.733
    },
    {
        "x": new Date(1359936000000),
        "y": 0.738
    },
    {
        "x": new Date(1360022400000),
        "y": 0.7388
    },
    {
        "x": new Date(1360108800000),
        "y": 0.7399
    },
    {
        "x": new Date(1360195200000),
        "y": 0.7383
    },
    {
        "x": new Date(1360281600000),
        "y": 0.7478
    },
    {
        "x": new Date(1360540800000),
        "y": 0.7469
    },
    {
        "x": new Date(1360627200000),
        "y": 0.7443
    },
    {
        "x": new Date(1360713600000),
        "y": 0.7419
    },
    {
        "x": new Date(1360800000000),
        "y": 0.7505
    },
    {
        "x": new Date(1360886400000),
        "y": 0.7506
    },
    {
        "x": new Date(1361145600000),
        "y": 0.7491
    },
    {
        "x": new Date(1361232000000),
        "y": 0.7492
    },
    {
        "x": new Date(1361318400000),
        "y": 0.748
    },
    {
        "x": new Date(1361404800000),
        "y": 0.7585
    },
    {
        "x": new Date(1361491200000),
        "y": 0.7585
    },
    {
        "x": new Date(1361750400000),
        "y": 0.7518
    },
    {
        "x": new Date(1361836800000),
        "y": 0.7648
    },
    {
        "x": new Date(1361923200000),
        "y": 0.7636
    },
    {
        "x": new Date(1362009600000),
        "y": 0.7618
    },
    {
        "x": new Date(1362096000000),
        "y": 0.7693
    },
    {
        "x": new Date(1362355200000),
        "y": 0.7689
    },
    {
        "x": new Date(1362441600000),
        "y": 0.7673
    },
    {
        "x": new Date(1362528000000),
        "y": 0.7673
    },
    {
        "x": new Date(1362614400000),
        "y": 0.7687
    },
    {
        "x": new Date(1362700800000),
        "y": 0.764
    },
    {
        "x": new Date(1362960000000),
        "y": 0.7697
    },
    {
        "x": new Date(1363046400000),
        "y": 0.7662
    },
    {
        "x": new Date(1363132800000),
        "y": 0.7705
    },
    {
        "x": new Date(1363219200000),
        "y": 0.7731
    },
    {
        "x": new Date(1363305600000),
        "y": 0.7643
    },
    {
        "x": new Date(1363564800000),
        "y": 0.7736
    },
    {
        "x": new Date(1363651200000),
        "y": 0.7727
    },
    {
        "x": new Date(1363737600000),
        "y": 0.7726
    },
    {
        "x": new Date(1363824000000),
        "y": 0.7747
    },
    {
        "x": new Date(1363910400000),
        "y": 0.7724
    },
    {
        "x": new Date(1364169600000),
        "y": 0.7732
    },
    {
        "x": new Date(1364256000000),
        "y": 0.7776
    },
    {
        "x": new Date(1364342400000),
        "y": 0.7833
    },
    {
        "x": new Date(1364428800000),
        "y": 0.781
    },
    {
        "x": new Date(1364860800000),
        "y": 0.7789
    },
    {
        "x": new Date(1364947200000),
        "y": 0.7796
    },
    {
        "x": new Date(1365033600000),
        "y": 0.7803
    },
    {
        "x": new Date(1365120000000),
        "y": 0.7727
    },
    {
        "x": new Date(1365379200000),
        "y": 0.768
    },
    {
        "x": new Date(1365465600000),
        "y": 0.767
    },
    {
        "x": new Date(1365552000000),
        "y": 0.7643
    },
    {
        "x": new Date(1365638400000),
        "y": 0.7624
    },
    {
        "x": new Date(1365724800000),
        "y": 0.7663
    },
    {
        "x": new Date(1365984000000),
        "y": 0.7646
    },
    {
        "x": new Date(1366070400000),
        "y": 0.7618
    },
    {
        "x": new Date(1366156800000),
        "y": 0.7618
    },
    {
        "x": new Date(1366243200000),
        "y": 0.7667
    },
    {
        "x": new Date(1366329600000),
        "y": 0.7626
    },
    {
        "x": new Date(1366588800000),
        "y": 0.7671
    },
    {
        "x": new Date(1366675200000),
        "y": 0.7699
    },
    {
        "x": new Date(1366761600000),
        "y": 0.769
    },
    {
        "x": new Date(1366848000000),
        "y": 0.7646
    },
    {
        "x": new Date(1366934400000),
        "y": 0.7694
    },
    {
        "x": new Date(1367193600000),
        "y": 0.7627
    },
    {
        "x": new Date(1367280000000),
        "y": 0.7651
    },
    {
        "x": new Date(1367452800000),
        "y": 0.7582
    },
    {
        "x": new Date(1367539200000),
        "y": 0.7626
    },
    {
        "x": new Date(1367798400000),
        "y": 0.7631
    },
    {
        "x": new Date(1367884800000),
        "y": 0.7631
    },
    {
        "x": new Date(1367971200000),
        "y": 0.7614
    },
    {
        "x": new Date(1368057600000),
        "y": 0.761
    },
    {
        "x": new Date(1368144000000),
        "y": 0.77
    },
    {
        "x": new Date(1368403200000),
        "y": 0.7709
    },
    {
        "x": new Date(1368489600000),
        "y": 0.7707
    },
    {
        "x": new Date(1368576000000),
        "y": 0.7775
    },
    {
        "x": new Date(1368662400000),
        "y": 0.7759
    },
    {
        "x": new Date(1368748800000),
        "y": 0.7772
    },
    {
        "x": new Date(1369008000000),
        "y": 0.7781
    },
    {
        "x": new Date(1369094400000),
        "y": 0.7773
    },
    {
        "x": new Date(1369180800000),
        "y": 0.7739
    },
    {
        "x": new Date(1369267200000),
        "y": 0.776
    },
    {
        "x": new Date(1369353600000),
        "y": 0.773
    },
    {
        "x": new Date(1369612800000),
        "y": 0.773
    },
    {
        "x": new Date(1369699200000),
        "y": 0.773
    },
    {
        "x": new Date(1369785600000),
        "y": 0.7722
    },
    {
        "x": new Date(1369872000000),
        "y": 0.7727
    },
    {
        "x": new Date(1369958400000),
        "y": 0.769
    },
    {
        "x": new Date(1370217600000),
        "y": 0.7689
    },
    {
        "x": new Date(1370304000000),
        "y": 0.7639
    },
    {
        "x": new Date(1370390400000),
        "y": 0.7654
    },
    {
        "x": new Date(1370476800000),
        "y": 0.7624
    },
    {
        "x": new Date(1370563200000),
        "y": 0.7542
    },
    {
        "x": new Date(1370822400000),
        "y": 0.7572
    },
    {
        "x": new Date(1370908800000),
        "y": 0.7535
    },
    {
        "x": new Date(1370995200000),
        "y": 0.7533
    },
    {
        "x": new Date(1371081600000),
        "y": 0.7511
    },
    {
        "x": new Date(1371168000000),
        "y": 0.7518
    },
    {
        "x": new Date(1371427200000),
        "y": 0.7499
    },
    {
        "x": new Date(1371513600000),
        "y": 0.7478
    },
    {
        "x": new Date(1371600000000),
        "y": 0.746
    },
    {
        "x": new Date(1371686400000),
        "y": 0.7577
    },
    {
        "x": new Date(1371772800000),
        "y": 0.7588
    },
    {
        "x": new Date(1372032000000),
        "y": 0.7643
    },
    {
        "x": new Date(1372118400000),
        "y": 0.7615
    },
    {
        "x": new Date(1372204800000),
        "y": 0.7679
    },
    {
        "x": new Date(1372291200000),
        "y": 0.7674
    },
    {
        "x": new Date(1372377600000),
        "y": 0.7646
    },
    {
        "x": new Date(1372636800000),
        "y": 0.7671
    },
    {
        "x": new Date(1372723200000),
        "y": 0.7683
    },
    {
        "x": new Date(1372809600000),
        "y": 0.7718
    },
    {
        "x": new Date(1372896000000),
        "y": 0.7703
    },
    {
        "x": new Date(1372982400000),
        "y": 0.7763
    },
    {
        "x": new Date(1373241600000),
        "y": 0.7783
    },
    {
        "x": new Date(1373328000000),
        "y": 0.7779
    },
    {
        "x": new Date(1373414400000),
        "y": 0.7806
    },
    {
        "x": new Date(1373500800000),
        "y": 0.7667
    },
    {
        "x": new Date(1373587200000),
        "y": 0.7673
    },
    {
        "x": new Date(1373846400000),
        "y": 0.7686
    },
    {
        "x": new Date(1373932800000),
        "y": 0.7624
    },
    {
        "x": new Date(1374019200000),
        "y": 0.7614
    },
    {
        "x": new Date(1374105600000),
        "y": 0.7639
    },
    {
        "x": new Date(1374192000000),
        "y": 0.7621
    },
    {
        "x": new Date(1374451200000),
        "y": 0.7596
    },
    {
        "x": new Date(1374537600000),
        "y": 0.7588
    },
    {
        "x": new Date(1374624000000),
        "y": 0.755
    },
    {
        "x": new Date(1374710400000),
        "y": 0.7576
    },
    {
        "x": new Date(1374796800000),
        "y": 0.7542
    },
    {
        "x": new Date(1375056000000),
        "y": 0.7537
    },
    {
        "x": new Date(1375142400000),
        "y": 0.7529
    },
    {
        "x": new Date(1375228800000),
        "y": 0.7534
    },
    {
        "x": new Date(1375315200000),
        "y": 0.7556
    },
    {
        "x": new Date(1375401600000),
        "y": 0.7575
    },
    {
        "x": new Date(1375660800000),
        "y": 0.7544
    },
    {
        "x": new Date(1375747200000),
        "y": 0.7531
    },
    {
        "x": new Date(1375833600000),
        "y": 0.7517
    },
    {
        "x": new Date(1375920000000),
        "y": 0.7486
    },
    {
        "x": new Date(1376006400000),
        "y": 0.7479
    },
    {
        "x": new Date(1376265600000),
        "y": 0.7531
    },
    {
        "x": new Date(1376352000000),
        "y": 0.7525
    },
    {
        "x": new Date(1376438400000),
        "y": 0.7552
    },
    {
        "x": new Date(1376524800000),
        "y": 0.7521
    },
    {
        "x": new Date(1376611200000),
        "y": 0.7497
    },
    {
        "x": new Date(1376870400000),
        "y": 0.7495
    },
    {
        "x": new Date(1376956800000),
        "y": 0.7468
    },
    {
        "x": new Date(1377043200000),
        "y": 0.7473
    },
    {
        "x": new Date(1377129600000),
        "y": 0.7507
    },
    {
        "x": new Date(1377216000000),
        "y": 0.7489
    },
    {
        "x": new Date(1377475200000),
        "y": 0.7485
    },
    {
        "x": new Date(1377561600000),
        "y": 0.7498
    },
    {
        "x": new Date(1377648000000),
        "y": 0.7493
    },
    {
        "x": new Date(1377734400000),
        "y": 0.7539
    },
    {
        "x": new Date(1377820800000),
        "y": 0.7557
    },
    {
        "x": new Date(1378080000000),
        "y": 0.7573
    },
    {
        "x": new Date(1378166400000),
        "y": 0.7593
    },
    {
        "x": new Date(1378252800000),
        "y": 0.7593
    },
    {
        "x": new Date(1378339200000),
        "y": 0.7576
    },
    {
        "x": new Date(1378425600000),
        "y": 0.7625
    },
    {
        "x": new Date(1378684800000),
        "y": 0.758
    },
    {
        "x": new Date(1378771200000),
        "y": 0.7554
    },
    {
        "x": new Date(1378857600000),
        "y": 0.7538
    },
    {
        "x": new Date(1378944000000),
        "y": 0.7525
    },
    {
        "x": new Date(1379030400000),
        "y": 0.7523
    },
    {
        "x": new Date(1379289600000),
        "y": 0.7488
    },
    {
        "x": new Date(1379376000000),
        "y": 0.7488
    },
    {
        "x": new Date(1379462400000),
        "y": 0.7491
    },
    {
        "x": new Date(1379548800000),
        "y": 0.7384
    },
    {
        "x": new Date(1379635200000),
        "y": 0.7401
    },
    {
        "x": new Date(1379894400000),
        "y": 0.7404
    },
    {
        "x": new Date(1379980800000),
        "y": 0.7423
    },
    {
        "x": new Date(1380067200000),
        "y": 0.7406
    },
    {
        "x": new Date(1380153600000),
        "y": 0.7409
    },
    {
        "x": new Date(1380240000000),
        "y": 0.7388
    },
    {
        "x": new Date(1380499200000),
        "y": 0.7406
    },
    {
        "x": new Date(1380585600000),
        "y": 0.7379
    },
    {
        "x": new Date(1380672000000),
        "y": 0.74
    },
    {
        "x": new Date(1380758400000),
        "y": 0.7357
    },
    {
        "x": new Date(1380844800000),
        "y": 0.7358
    },
    {
        "x": new Date(1381104000000),
        "y": 0.7369
    },
    {
        "x": new Date(1381190400000),
        "y": 0.7367
    },
    {
        "x": new Date(1381276800000),
        "y": 0.74
    },
    {
        "x": new Date(1381363200000),
        "y": 0.7391
    },
    {
        "x": new Date(1381449600000),
        "y": 0.7372
    },
    {
        "x": new Date(1381708800000),
        "y": 0.7373
    },
    {
        "x": new Date(1381795200000),
        "y": 0.7412
    },
    {
        "x": new Date(1381881600000),
        "y": 0.7375
    },
    {
        "x": new Date(1381968000000),
        "y": 0.7321
    },
    {
        "x": new Date(1382054400000),
        "y": 0.7309
    },
    {
        "x": new Date(1382313600000),
        "y": 0.7318
    },
    {
        "x": new Date(1382400000000),
        "y": 0.7314
    },
    {
        "x": new Date(1382486400000),
        "y": 0.7273
    },
    {
        "x": new Date(1382572800000),
        "y": 0.7245
    },
    {
        "x": new Date(1382659200000),
        "y": 0.7259
    },
    {
        "x": new Date(1382918400000),
        "y": 0.7256
    },
    {
        "x": new Date(1383004800000),
        "y": 0.7264
    },
    {
        "x": new Date(1383091200000),
        "y": 0.7271
    },
    {
        "x": new Date(1383177600000),
        "y": 0.7332
    },
    {
        "x": new Date(1383264000000),
        "y": 0.7406
    },
    {
        "x": new Date(1383523200000),
        "y": 0.7405
    },
    {
        "x": new Date(1383609600000),
        "y": 0.7412
    },
    {
        "x": new Date(1383696000000),
        "y": 0.7399
    },
    {
        "x": new Date(1383782400000),
        "y": 0.7483
    },
    {
        "x": new Date(1383868800000),
        "y": 0.7446
    },
    {
        "x": new Date(1384128000000),
        "y": 0.7467
    },
    {
        "x": new Date(1384214400000),
        "y": 0.7446
    },
    {
        "x": new Date(1384300800000),
        "y": 0.7455
    },
    {
        "x": new Date(1384387200000),
        "y": 0.7444
    },
    {
        "x": new Date(1384473600000),
        "y": 0.743
    },
    {
        "x": new Date(1384732800000),
        "y": 0.7399
    },
    {
        "x": new Date(1384819200000),
        "y": 0.7407
    },
    {
        "x": new Date(1384905600000),
        "y": 0.7394
    },
    {
        "x": new Date(1384992000000),
        "y": 0.7424
    },
    {
        "x": new Date(1385078400000),
        "y": 0.7399
    },
    {
        "x": new Date(1385337600000),
        "y": 0.7401
    },
    {
        "x": new Date(1385424000000),
        "y": 0.7383
    },
    {
        "x": new Date(1385510400000),
        "y": 0.7356
    },
    {
        "x": new Date(1385596800000),
        "y": 0.7358
    },
    {
        "x": new Date(1385683200000),
        "y": 0.7348
    },
    {
        "x": new Date(1385942400000),
        "y": 0.7389
    },
    {
        "x": new Date(1386028800000),
        "y": 0.7366
    },
    {
        "x": new Date(1386115200000),
        "y": 0.7358
    },
    {
        "x": new Date(1386201600000),
        "y": 0.7357
    },
    {
        "x": new Date(1386288000000),
        "y": 0.7321
    },
    {
        "x": new Date(1386547200000),
        "y": 0.7289
    },
    {
        "x": new Date(1386633600000),
        "y": 0.7274
    },
    {
        "x": new Date(1386720000000),
        "y": 0.7265
    },
    {
        "x": new Date(1386806400000),
        "y": 0.7261
    },
    {
        "x": new Date(1386892800000),
        "y": 0.7286
    },
    {
        "x": new Date(1387152000000),
        "y": 0.726
    },
    {
        "x": new Date(1387238400000),
        "y": 0.7274
    },
    {
        "x": new Date(1387324800000),
        "y": 0.7274
    },
    {
        "x": new Date(1387411200000),
        "y": 0.7318
    },
    {
        "x": new Date(1387497600000),
        "y": 0.7324
    },
    {
        "x": new Date(1387756800000),
        "y": 0.7299
    },
    {
        "x": new Date(1387843200000),
        "y": 0.7309
    },
    {
        "x": new Date(1388102400000),
        "y": 0.724
    },
    {
        "x": new Date(1388361600000),
        "y": 0.7256
    },
    {
        "x": new Date(1388448000000),
        "y": 0.7252
    },
    {
        "x": new Date(1388620800000),
        "y": 0.7323
    },
    {
        "x": new Date(1388707200000),
        "y": 0.7336
    },
    {
        "x": new Date(1388966400000),
        "y": 0.7353
    },
    {
        "x": new Date(1389052800000),
        "y": 0.7332
    },
    {
        "x": new Date(1389139200000),
        "y": 0.7357
    },
    {
        "x": new Date(1389225600000),
        "y": 0.7347
    },
    {
        "x": new Date(1389312000000),
        "y": 0.7361
    },
    {
        "x": new Date(1389571200000),
        "y": 0.7325
    },
    {
        "x": new Date(1389657600000),
        "y": 0.7318
    },
    {
        "x": new Date(1389744000000),
        "y": 0.7351
    },
    {
        "x": new Date(1389830400000),
        "y": 0.7356
    },
    {
        "x": new Date(1389916800000),
        "y": 0.7363
    },
    {
        "x": new Date(1390176000000),
        "y": 0.7372
    },
    {
        "x": new Date(1390262400000),
        "y": 0.7394
    },
    {
        "x": new Date(1390348800000),
        "y": 0.7372
    },
    {
        "x": new Date(1390435200000),
        "y": 0.7333
    },
    {
        "x": new Date(1390521600000),
        "y": 0.7307
    },
    {
        "x": new Date(1390780800000),
        "y": 0.7323
    },
    {
        "x": new Date(1390867200000),
        "y": 0.7328
    },
    {
        "x": new Date(1390953600000),
        "y": 0.735
    },
    {
        "x": new Date(1391040000000),
        "y": 0.7368
    },
    {
        "x": new Date(1391126400000),
        "y": 0.74
    },
    {
        "x": new Date(1391385600000),
        "y": 0.741
    },
    {
        "x": new Date(1391472000000),
        "y": 0.7398
    },
    {
        "x": new Date(1391558400000),
        "y": 0.7385
    },
    {
        "x": new Date(1391644800000),
        "y": 0.7411
    },
    {
        "x": new Date(1391731200000),
        "y": 0.7368
    },
    {
        "x": new Date(1391990400000),
        "y": 0.7333
    },
    {
        "x": new Date(1392076800000),
        "y": 0.7313
    },
    {
        "x": new Date(1392163200000),
        "y": 0.7369
    },
    {
        "x": new Date(1392249600000),
        "y": 0.7314
    },
    {
        "x": new Date(1392336000000),
        "y": 0.7297
    },
    {
        "x": new Date(1392595200000),
        "y": 0.7301
    },
    {
        "x": new Date(1392681600000),
        "y": 0.7284
    },
    {
        "x": new Date(1392768000000),
        "y": 0.7276
    },
    {
        "x": new Date(1392854400000),
        "y": 0.7297
    },
    {
        "x": new Date(1392940800000),
        "y": 0.7297
    },
    {
        "x": new Date(1393200000000),
        "y": 0.7282
    },
    {
        "x": new Date(1393286400000),
        "y": 0.7272
    },
    {
        "x": new Date(1393372800000),
        "y": 0.7286
    },
    {
        "x": new Date(1393459200000),
        "y": 0.7324
    },
    {
        "x": new Date(1393545600000),
        "y": 0.7241
    },
    {
        "x": new Date(1393804800000),
        "y": 0.7264
    },
    {
        "x": new Date(1393891200000),
        "y": 0.7264
    },
    {
        "x": new Date(1393977600000),
        "y": 0.7283
    },
    {
        "x": new Date(1394064000000),
        "y": 0.7276
    },
    {
        "x": new Date(1394150400000),
        "y": 0.7198
    },
    {
        "x": new Date(1394409600000),
        "y": 0.7205
    },
    {
        "x": new Date(1394496000000),
        "y": 0.7221
    },
    {
        "x": new Date(1394582400000),
        "y": 0.7202
    },
    {
        "x": new Date(1394668800000),
        "y": 0.7174
    },
    {
        "x": new Date(1394755200000),
        "y": 0.7204
    },
    {
        "x": new Date(1395014400000),
        "y": 0.7192
    },
    {
        "x": new Date(1395100800000),
        "y": 0.7194
    },
    {
        "x": new Date(1395187200000),
        "y": 0.7189
    },
    {
        "x": new Date(1395273600000),
        "y": 0.7267
    },
    {
        "x": new Date(1395360000000),
        "y": 0.7258
    },
    {
        "x": new Date(1395619200000),
        "y": 0.7261
    },
    {
        "x": new Date(1395705600000),
        "y": 0.7253
    },
    {
        "x": new Date(1395792000000),
        "y": 0.7252
    },
    {
        "x": new Date(1395878400000),
        "y": 0.7269
    },
    {
        "x": new Date(1395964800000),
        "y": 0.7269
    },
    {
        "x": new Date(1396224000000),
        "y": 0.7254
    },
    {
        "x": new Date(1396310400000),
        "y": 0.7253
    },
    {
        "x": new Date(1396396800000),
        "y": 0.725
    },
    {
        "x": new Date(1396483200000),
        "y": 0.7263
    },
    {
        "x": new Date(1396569600000),
        "y": 0.73
    },
    {
        "x": new Date(1396828800000),
        "y": 0.7288
    },
    {
        "x": new Date(1396915200000),
        "y": 0.7261
    },
    {
        "x": new Date(1397001600000),
        "y": 0.7251
    },
    {
        "x": new Date(1397088000000),
        "y": 0.7212
    },
    {
        "x": new Date(1397174400000),
        "y": 0.721
    },
    {
        "x": new Date(1397433600000),
        "y": 0.7233
    },
    {
        "x": new Date(1397520000000),
        "y": 0.7246
    },
    {
        "x": new Date(1397606400000),
        "y": 0.7226
    },
    {
        "x": new Date(1397692800000),
        "y": 0.7219
    },
    {
        "x": new Date(1398124800000),
        "y": 0.7238
    },
    {
        "x": new Date(1398211200000),
        "y": 0.723
    },
    {
        "x": new Date(1398297600000),
        "y": 0.7237
    },
    {
        "x": new Date(1398384000000),
        "y": 0.7231
    },
    {
        "x": new Date(1398643200000),
        "y": 0.7215
    },
    {
        "x": new Date(1398729600000),
        "y": 0.7234
    },
    {
        "x": new Date(1398816000000),
        "y": 0.7221
    },
    {
        "x": new Date(1398988800000),
        "y": 0.7215
    },
    {
        "x": new Date(1399248000000),
        "y": 0.7209
    },
    {
        "x": new Date(1399334400000),
        "y": 0.7172
    },
    {
        "x": new Date(1399420800000),
        "y": 0.7181
    },
    {
        "x": new Date(1399507200000),
        "y": 0.7168
    },
    {
        "x": new Date(1399593600000),
        "y": 0.7257
    },
    {
        "x": new Date(1399852800000),
        "y": 0.7266
    },
    {
        "x": new Date(1399939200000),
        "y": 0.7299
    },
    {
        "x": new Date(1400025600000),
        "y": 0.729
    },
    {
        "x": new Date(1400112000000),
        "y": 0.7322
    },
    {
        "x": new Date(1400198400000),
        "y": 0.7302
    },
    {
        "x": new Date(1400457600000),
        "y": 0.7292
    },
    {
        "x": new Date(1400544000000),
        "y": 0.7299
    },
    {
        "x": new Date(1400630400000),
        "y": 0.7313
    },
    {
        "x": new Date(1400716800000),
        "y": 0.7317
    },
    {
        "x": new Date(1400803200000),
        "y": 0.7338
    },
    {
        "x": new Date(1401062400000),
        "y": 0.7335
    },
    {
        "x": new Date(1401148800000),
        "y": 0.7333
    },
    {
        "x": new Date(1401235200000),
        "y": 0.735
    },
    {
        "x": new Date(1401321600000),
        "y": 0.7347
    },
    {
        "x": new Date(1401408000000),
        "y": 0.735
    },
    {
        "x": new Date(1401667200000),
        "y": 0.7348
    },
    {
        "x": new Date(1401753600000),
        "y": 0.733
    },
    {
        "x": new Date(1401840000000),
        "y": 0.7339
    },
    {
        "x": new Date(1401926400000),
        "y": 0.7372
    },
    {
        "x": new Date(1402012800000),
        "y": 0.7331
    },
    {
        "x": new Date(1402272000000),
        "y": 0.735
    },
    {
        "x": new Date(1402358400000),
        "y": 0.7383
    },
    {
        "x": new Date(1402444800000),
        "y": 0.7383
    },
    {
        "x": new Date(1402531200000),
        "y": 0.7393
    },
    {
        "x": new Date(1402617600000),
        "y": 0.739
    },
    {
        "x": new Date(1402876800000),
        "y": 0.7391
    },
    {
        "x": new Date(1402963200000),
        "y": 0.7371
    },
    {
        "x": new Date(1403049600000),
        "y": 0.7374
    },
    {
        "x": new Date(1403136000000),
        "y": 0.7343
    },
    {
        "x": new Date(1403222400000),
        "y": 0.736
    },
    {
        "x": new Date(1403481600000),
        "y": 0.7356
    },
    {
        "x": new Date(1403568000000),
        "y": 0.7344
    },
    {
        "x": new Date(1403654400000),
        "y": 0.7346
    },
    {
        "x": new Date(1403740800000),
        "y": 0.7351
    },
    {
        "x": new Date(1403827200000),
        "y": 0.7343
    },
    {
        "x": new Date(1404086400000),
        "y": 0.7323
    },
    {
        "x": new Date(1404172800000),
        "y": 0.7307
    },
    {
        "x": new Date(1404259200000),
        "y": 0.7324
    },
    {
        "x": new Date(1404345600000),
        "y": 0.7329
    },
    {
        "x": new Date(1404432000000),
        "y": 0.736
    },
    {
        "x": new Date(1404691200000),
        "y": 0.7358
    },
    {
        "x": new Date(1404777600000),
        "y": 0.736
    },
    {
        "x": new Date(1404864000000),
        "y": 0.7352
    },
    {
        "x": new Date(1404950400000),
        "y": 0.7352
    },
    {
        "x": new Date(1405036800000),
        "y": 0.7357
    },
    {
        "x": new Date(1405296000000),
        "y": 0.7339
    },
    {
        "x": new Date(1405382400000),
        "y": 0.7347
    },
    {
        "x": new Date(1405468800000),
        "y": 0.7391
    },
    {
        "x": new Date(1405555200000),
        "y": 0.7395
    },
    {
        "x": new Date(1405641600000),
        "y": 0.7395
    },
    {
        "x": new Date(1405900800000),
        "y": 0.7399
    },
    {
        "x": new Date(1405987200000),
        "y": 0.7419
    },
    {
        "x": new Date(1406073600000),
        "y": 0.7428
    },
    {
        "x": new Date(1406160000000),
        "y": 0.7424
    },
    {
        "x": new Date(1406246400000),
        "y": 0.7441
    },
    {
        "x": new Date(1406505600000),
        "y": 0.7445
    },
    {
        "x": new Date(1406592000000),
        "y": 0.7448
    },
    {
        "x": new Date(1406678400000),
        "y": 0.7463
    },
    {
        "x": new Date(1406764800000),
        "y": 0.7475
    },
    {
        "x": new Date(1406851200000),
        "y": 0.7466
    },
    {
        "x": new Date(1407110400000),
        "y": 0.7451
    },
    {
        "x": new Date(1407196800000),
        "y": 0.7474
    },
    {
        "x": new Date(1407283200000),
        "y": 0.7494
    },
    {
        "x": new Date(1407369600000),
        "y": 0.7482
    },
    {
        "x": new Date(1407456000000),
        "y": 0.747
    },
    {
        "x": new Date(1407715200000),
        "y": 0.7471
    },
    {
        "x": new Date(1407801600000),
        "y": 0.7494
    },
    {
        "x": new Date(1407888000000),
        "y": 0.7486
    },
    {
        "x": new Date(1407974400000),
        "y": 0.7479
    },
    {
        "x": new Date(1408060800000),
        "y": 0.747
    },
    {
        "x": new Date(1408320000000),
        "y": 0.7473
    },
    {
        "x": new Date(1408406400000),
        "y": 0.7489
    },
    {
        "x": new Date(1408492800000),
        "y": 0.7529
    },
    {
        "x": new Date(1408579200000),
        "y": 0.7541
    },
    {
        "x": new Date(1408665600000),
        "y": 0.7538
    },
    {
        "x": new Date(1408924800000),
        "y": 0.7577
    },
    {
        "x": new Date(1409011200000),
        "y": 0.7581
    },
    {
        "x": new Date(1409097600000),
        "y": 0.759
    },
    {
        "x": new Date(1409184000000),
        "y": 0.7589
    },
    {
        "x": new Date(1409270400000),
        "y": 0.7584
    },
    {
        "x": new Date(1409529600000),
        "y": 0.7615
    },
    {
        "x": new Date(1409616000000),
        "y": 0.7626
    },
    {
        "x": new Date(1409702400000),
        "y": 0.7605
    },
    {
        "x": new Date(1409788800000),
        "y": 0.7684
    },
    {
        "x": new Date(1409875200000),
        "y": 0.7724
    },
    {
        "x": new Date(1410134400000),
        "y": 0.7725
    },
    {
        "x": new Date(1410220800000),
        "y": 0.7752
    },
    {
        "x": new Date(1410307200000),
        "y": 0.7736
    },
    {
        "x": new Date(1410393600000),
        "y": 0.7736
    },
    {
        "x": new Date(1410480000000),
        "y": 0.7734
    },
    {
        "x": new Date(1410739200000),
        "y": 0.7746
    },
    {
        "x": new Date(1410825600000),
        "y": 0.7724
    },
    {
        "x": new Date(1410912000000),
        "y": 0.7719
    },
    {
        "x": new Date(1410998400000),
        "y": 0.777
    },
    {
        "x": new Date(1411084800000),
        "y": 0.7782
    },
    {
        "x": new Date(1411344000000),
        "y": 0.7786
    },
    {
        "x": new Date(1411430400000),
        "y": 0.7758
    },
    {
        "x": new Date(1411516800000),
        "y": 0.7798
    },
    {
        "x": new Date(1411603200000),
        "y": 0.7868
    },
    {
        "x": new Date(1411689600000),
        "y": 0.7855
    },
    {
        "x": new Date(1411948800000),
        "y": 0.7874
    },
    {
        "x": new Date(1412035200000),
        "y": 0.7948
    },
    {
        "x": new Date(1412121600000),
        "y": 0.7936
    },
    {
        "x": new Date(1412208000000),
        "y": 0.7918
    },
    {
        "x": new Date(1412294400000),
        "y": 0.7927
    },
    {
        "x": new Date(1412553600000),
        "y": 0.796
    },
    {
        "x": new Date(1412640000000),
        "y": 0.7933
    },
    {
        "x": new Date(1412726400000),
        "y": 0.7909
    },
    {
        "x": new Date(1412812800000),
        "y": 0.7836
    },
    {
        "x": new Date(1412899200000),
        "y": 0.7914
    },
    {
        "x": new Date(1413158400000),
        "y": 0.7888
    },
    {
        "x": new Date(1413244800000),
        "y": 0.7909
    },
    {
        "x": new Date(1413331200000),
        "y": 0.7896
    },
    {
        "x": new Date(1413417600000),
        "y": 0.7845
    },
    {
        "x": new Date(1413504000000),
        "y": 0.7799
    },
    {
        "x": new Date(1413763200000),
        "y": 0.783
    },
    {
        "x": new Date(1413849600000),
        "y": 0.7837
    },
    {
        "x": new Date(1413936000000),
        "y": 0.7879
    },
    {
        "x": new Date(1414022400000),
        "y": 0.7894
    },
    {
        "x": new Date(1414108800000),
        "y": 0.7901
    },
    {
        "x": new Date(1414368000000),
        "y": 0.7888
    },
    {
        "x": new Date(1414454400000),
        "y": 0.7845
    },
    {
        "x": new Date(1414540800000),
        "y": 0.7852
    },
    {
        "x": new Date(1414627200000),
        "y": 0.7939
    },
    {
        "x": new Date(1414713600000),
        "y": 0.7986
    },
    {
        "x": new Date(1414972800000),
        "y": 0.8005
    },
    {
        "x": new Date(1415059200000),
        "y": 0.7992
    },
    {
        "x": new Date(1415145600000),
        "y": 0.8014
    },
    {
        "x": new Date(1415232000000),
        "y": 0.799
    },
    {
        "x": new Date(1415318400000),
        "y": 0.807
    },
    {
        "x": new Date(1415577600000),
        "y": 0.801
    },
    {
        "x": new Date(1415664000000),
        "y": 0.805
    },
    {
        "x": new Date(1415750400000),
        "y": 0.8022
    },
    {
        "x": new Date(1415836800000),
        "y": 0.8029
    },
    {
        "x": new Date(1415923200000),
        "y": 0.8042
    },
    {
        "x": new Date(1416182400000),
        "y": 0.8004
    },
    {
        "x": new Date(1416268800000),
        "y": 0.7992
    },
    {
        "x": new Date(1416355200000),
        "y": 0.7979
    },
    {
        "x": new Date(1416441600000),
        "y": 0.7976
    },
    {
        "x": new Date(1416528000000),
        "y": 0.8051
    },
    {
        "x": new Date(1416787200000),
        "y": 0.8059
    },
    {
        "x": new Date(1416873600000),
        "y": 0.805
    },
    {
        "x": new Date(1416960000000),
        "y": 0.8017
    },
    {
        "x": new Date(1417046400000),
        "y": 0.8014
    },
    {
        "x": new Date(1417132800000),
        "y": 0.8012
    },
    {
        "x": new Date(1417392000000),
        "y": 0.8021
    },
    {
        "x": new Date(1417478400000),
        "y": 0.805
    },
    {
        "x": new Date(1417564800000),
        "y": 0.8111
    },
    {
        "x": new Date(1417651200000),
        "y": 0.8124
    },
    {
        "x": new Date(1417737600000),
        "y": 0.809
    },
    {
        "x": new Date(1417996800000),
        "y": 0.8159
    },
    {
        "x": new Date(1418083200000),
        "y": 0.8086
    },
    {
        "x": new Date(1418169600000),
        "y": 0.8071
    },
    {
        "x": new Date(1418256000000),
        "y": 0.8047
    },
    {
        "x": new Date(1418342400000),
        "y": 0.8033
    },
    {
        "x": new Date(1418601600000),
        "y": 0.8049
    },
    {
        "x": new Date(1418688000000),
        "y": 0.7977
    },
    {
        "x": new Date(1418774400000),
        "y": 0.8034
    },
    {
        "x": new Date(1418860800000),
        "y": 0.8141
    },
    {
        "x": new Date(1418947200000),
        "y": 0.8145
    },
    {
        "x": new Date(1419206400000),
        "y": 0.8158
    },
    {
        "x": new Date(1419292800000),
        "y": 0.8189
    },
    {
        "x": new Date(1419379200000),
        "y": 0.8185
    },
    {
        "x": new Date(1419811200000),
        "y": 0.82
    },
    {
        "x": new Date(1419897600000),
        "y": 0.8225
    },
    {
        "x": new Date(1419984000000),
        "y": 0.8238
    },
    {
        "x": new Date(1420156800000),
        "y": 0.8305
    },
    {
        "x": new Date(1420416000000),
        "y": 0.8394
    },
    {
        "x": new Date(1420502400000),
        "y": 0.8394
    },
    {
        "x": new Date(1420588800000),
        "y": 0.8453
    },
    {
        "x": new Date(1420675200000),
        "y": 0.8499
    },
    {
        "x": new Date(1420761600000),
        "y": 0.8466
    },
    {
        "x": new Date(1421020800000),
        "y": 0.8473
    },
    {
        "x": new Date(1421107200000),
        "y": 0.8489
    },
    {
        "x": new Date(1421193600000),
        "y": 0.8494
    },
    {
        "x": new Date(1421280000000),
        "y": 0.8542
    },
    {
        "x": new Date(1421366400000),
        "y": 0.8631
    },
    {
        "x": new Date(1421625600000),
        "y": 0.8618
    },
    {
        "x": new Date(1421712000000),
        "y": 0.8637
    },
    {
        "x": new Date(1421798400000),
        "y": 0.8627
    },
    {
        "x": new Date(1421884800000),
        "y": 0.8608
    },
    {
        "x": new Date(1421971200000),
        "y": 0.8931
    },
    {
        "x": new Date(1422230400000),
        "y": 0.8895
    },
    {
        "x": new Date(1422316800000),
        "y": 0.8846
    },
    {
        "x": new Date(1422403200000),
        "y": 0.8816
    },
    {
        "x": new Date(1422489600000),
        "y": 0.8839
    },
    {
        "x": new Date(1422576000000),
        "y": 0.8847
    },
    {
        "x": new Date(1422835200000),
        "y": 0.8843
    },
    {
        "x": new Date(1422921600000),
        "y": 0.8791
    },
    {
        "x": new Date(1423008000000),
        "y": 0.8738
    },
    {
        "x": new Date(1423094400000),
        "y": 0.8765
    },
    {
        "x": new Date(1423180800000),
        "y": 0.8737
    },
    {
        "x": new Date(1423440000000),
        "y": 0.887
    },
    {
        "x": new Date(1423526400000),
        "y": 0.8853
    },
    {
        "x": new Date(1423612800000),
        "y": 0.884
    },
    {
        "x": new Date(1423699200000),
        "y": 0.8829
    },
    {
        "x": new Date(1423785600000),
        "y": 0.8788
    },
    {
        "x": new Date(1424044800000),
        "y": 0.8767
    },
    {
        "x": new Date(1424131200000),
        "y": 0.8761
    },
    {
        "x": new Date(1424217600000),
        "y": 0.8795
    },
    {
        "x": new Date(1424304000000),
        "y": 0.8783
    },
    {
        "x": new Date(1424390400000),
        "y": 0.8852
    },
    {
        "x": new Date(1424649600000),
        "y": 0.8852
    },
    {
        "x": new Date(1424736000000),
        "y": 0.8829
    },
    {
        "x": new Date(1424822400000),
        "y": 0.8815
    },
    {
        "x": new Date(1424908800000),
        "y": 0.8837
    },
    {
        "x": new Date(1424995200000),
        "y": 0.8898
    },
    {
        "x": new Date(1425254400000),
        "y": 0.8908
    },
    {
        "x": new Date(1425340800000),
        "y": 0.8955
    },
    {
        "x": new Date(1425427200000),
        "y": 0.8991
    },
    {
        "x": new Date(1425513600000),
        "y": 0.9035
    },
    {
        "x": new Date(1425600000000),
        "y": 0.9123
    },
    {
        "x": new Date(1425859200000),
        "y": 0.9209
    },
    {
        "x": new Date(1425945600000),
        "y": 0.9314
    },
    {
        "x": new Date(1426032000000),
        "y": 0.9455
    },
    {
        "x": new Date(1426118400000),
        "y": 0.9423
    },
    {
        "x": new Date(1426204800000),
        "y": 0.946
    },
    {
        "x": new Date(1426464000000),
        "y": 0.9473
    },
    {
        "x": new Date(1426550400000),
        "y": 0.9404
    },
    {
        "x": new Date(1426636800000),
        "y": 0.9442
    },
    {
        "x": new Date(1426723200000),
        "y": 0.9367
    },
    {
        "x": new Date(1426809600000),
        "y": 0.9281
    },
    {
        "x": new Date(1427068800000),
        "y": 0.9165
    },
    {
        "x": new Date(1427155200000),
        "y": 0.9133
    },
    {
        "x": new Date(1427241600000),
        "y": 0.9104
    },
    {
        "x": new Date(1427328000000),
        "y": 0.9114
    },
    {
        "x": new Date(1427414400000),
        "y": 0.9212
    },
    {
        "x": new Date(1427673600000),
        "y": 0.9222
    },
    {
        "x": new Date(1427760000000),
        "y": 0.9296
    },
    {
        "x": new Date(1427846400000),
        "y": 0.9299
    },
    {
        "x": new Date(1427932800000),
        "y": 0.9235
    },
    {
        "x": new Date(1428364800000),
        "y": 0.922
    },
    {
        "x": new Date(1428451200000),
        "y": 0.9207
    },
    {
        "x": new Date(1428537600000),
        "y": 0.9283
    },
    {
        "x": new Date(1428624000000),
        "y": 0.9462
    },
    {
        "x": new Date(1428883200000),
        "y": 0.9478
    },
    {
        "x": new Date(1428969600000),
        "y": 0.9467
    },
    {
        "x": new Date(1429056000000),
        "y": 0.9454
    },
    {
        "x": new Date(1429142400000),
        "y": 0.9337
    },
    {
        "x": new Date(1429228800000),
        "y": 0.9248
    },
    {
        "x": new Date(1429488000000),
        "y": 0.9327
    },
    {
        "x": new Date(1429574400000),
        "y": 0.9347
    },
    {
        "x": new Date(1429660800000),
        "y": 0.9309
    },
    {
        "x": new Date(1429747200000),
        "y": 0.9284
    },
    {
        "x": new Date(1429833600000),
        "y": 0.924
    },
    {
        "x": new Date(1430092800000),
        "y": 0.9241
    },
    {
        "x": new Date(1430179200000),
        "y": 0.9153
    },
    {
        "x": new Date(1430265600000),
        "y": 0.909
    },
    {
        "x": new Date(1430352000000),
        "y": 0.8918
    },
    {
        "x": new Date(1430697600000),
        "y": 0.8968
    },
    {
        "x": new Date(1430784000000),
        "y": 0.8996
    },
    {
        "x": new Date(1430870400000),
        "y": 0.8906
    },
    {
        "x": new Date(1430956800000),
        "y": 0.8847
    },
    {
        "x": new Date(1431043200000),
        "y": 0.8913
    },
    {
        "x": new Date(1431302400000),
        "y": 0.8976
    },
    {
        "x": new Date(1431388800000),
        "y": 0.8899
    },
    {
        "x": new Date(1431475200000),
        "y": 0.8913
    },
    {
        "x": new Date(1431561600000),
        "y": 0.8758
    },
    {
        "x": new Date(1431648000000),
        "y": 0.8829
    },
    {
        "x": new Date(1431907200000),
        "y": 0.8781
    },
    {
        "x": new Date(1431993600000),
        "y": 0.8946
    },
    {
        "x": new Date(1432080000000),
        "y": 0.8995
    },
    {
        "x": new Date(1432166400000),
        "y": 0.8983
    },
    {
        "x": new Date(1432252800000),
        "y": 0.8958
    },
    {
        "x": new Date(1432512000000),
        "y": 0.911
    },
    {
        "x": new Date(1432598400000),
        "y": 0.9153
    },
    {
        "x": new Date(1432684800000),
        "y": 0.9207
    },
    {
        "x": new Date(1432771200000),
        "y": 0.9179
    },
    {
        "x": new Date(1432857600000),
        "y": 0.9117
    },
    {
        "x": new Date(1433116800000),
        "y": 0.9138
    },
    {
        "x": new Date(1433203200000),
        "y": 0.9068
    },
    {
        "x": new Date(1433289600000),
        "y": 0.8982
    },
    {
        "x": new Date(1433376000000),
        "y": 0.8837
    },
    {
        "x": new Date(1433462400000),
        "y": 0.8915
    },
    {
        "x": new Date(1433721600000),
        "y": 0.896
    },
    {
        "x": new Date(1433808000000),
        "y": 0.8891
    },
    {
        "x": new Date(1433894400000),
        "y": 0.8867
    },
    {
        "x": new Date(1433980800000),
        "y": 0.8904
    },
    {
        "x": new Date(1434067200000),
        "y": 0.8914
    },
    {
        "x": new Date(1434326400000),
        "y": 0.8915
    },
    {
        "x": new Date(1434412800000),
        "y": 0.8918
    },
    {
        "x": new Date(1434499200000),
        "y": 0.8867
    },
    {
        "x": new Date(1434585600000),
        "y": 0.877
    },
    {
        "x": new Date(1434672000000),
        "y": 0.8851
    },
    {
        "x": new Date(1434931200000),
        "y": 0.8815
    },
    {
        "x": new Date(1435017600000),
        "y": 0.8926
    },
    {
        "x": new Date(1435104000000),
        "y": 0.8919
    },
    {
        "x": new Date(1435190400000),
        "y": 0.8925
    },
    {
        "x": new Date(1435276800000),
        "y": 0.8928
    },
    {
        "x": new Date(1435536000000),
        "y": 0.8983
    },
    {
        "x": new Date(1435622400000),
        "y": 0.8938
    },
    {
        "x": new Date(1435708800000),
        "y": 0.901
    },
    {
        "x": new Date(1435795200000),
        "y": 0.9038
    },
    {
        "x": new Date(1435881600000),
        "y": 0.9013
    },
    {
        "x": new Date(1436140800000),
        "y": 0.9085
    },
    {
        "x": new Date(1436227200000),
        "y": 0.9149
    },
    {
        "x": new Date(1436313600000),
        "y": 0.9072
    },
    {
        "x": new Date(1436400000000),
        "y": 0.9047
    },
    {
        "x": new Date(1436486400000),
        "y": 0.8942
    },
    {
        "x": new Date(1436745600000),
        "y": 0.9052
    },
    {
        "x": new Date(1436832000000),
        "y": 0.9066
    },
    {
        "x": new Date(1436918400000),
        "y": 0.9084
    },
    {
        "x": new Date(1437004800000),
        "y": 0.9203
    },
    {
        "x": new Date(1437091200000),
        "y": 0.9185
    },
    {
        "x": new Date(1437350400000),
        "y": 0.9216
    },
    {
        "x": new Date(1437436800000),
        "y": 0.9203
    },
    {
        "x": new Date(1437523200000),
        "y": 0.9174
    },
    {
        "x": new Date(1437609600000),
        "y": 0.9093
    },
    {
        "x": new Date(1437696000000),
        "y": 0.9143
    },
    {
        "x": new Date(1437955200000),
        "y": 0.9044
    },
    {
        "x": new Date(1438041600000),
        "y": 0.9071
    },
    {
        "x": new Date(1438128000000),
        "y": 0.9067
    },
    {
        "x": new Date(1438214400000),
        "y": 0.9129
    },
    {
        "x": new Date(1438300800000),
        "y": 0.9119
    },
    {
        "x": new Date(1438560000000),
        "y": 0.9133
    },
    {
        "x": new Date(1438646400000),
        "y": 0.9114
    },
    {
        "x": new Date(1438732800000),
        "y": 0.919
    },
    {
        "x": new Date(1438819200000),
        "y": 0.9188
    },
    {
        "x": new Date(1438905600000),
        "y": 0.9141
    },
    {
        "x": new Date(1439164800000),
        "y": 0.9125
    },
    {
        "x": new Date(1439251200000),
        "y": 0.9047
    },
    {
        "x": new Date(1439337600000),
        "y": 0.8966
    },
    {
        "x": new Date(1439424000000),
        "y": 0.9003
    },
    {
        "x": new Date(1439510400000),
        "y": 0.8953
    },
    {
        "x": new Date(1439769600000),
        "y": 0.901
    },
    {
        "x": new Date(1439856000000),
        "y": 0.9043
    },
    {
        "x": new Date(1439942400000),
        "y": 0.9058
    },
    {
        "x": new Date(1440028800000),
        "y": 0.8943
    },
    {
        "x": new Date(1440115200000),
        "y": 0.8865
    },
    {
        "x": new Date(1440374400000),
        "y": 0.8699
    },
    {
        "x": new Date(1440460800000),
        "y": 0.8692
    },
    {
        "x": new Date(1440547200000),
        "y": 0.8771
    },
    {
        "x": new Date(1440633600000),
        "y": 0.8863
    },
    {
        "x": new Date(1440720000000),
        "y": 0.8876
    },
    {
        "x": new Date(1440979200000),
        "y": 0.8918
    },
    {
        "x": new Date(1441065600000),
        "y": 0.8901
    },
    {
        "x": new Date(1441152000000),
        "y": 0.8886
    },
    {
        "x": new Date(1441238400000),
        "y": 0.8907
    },
    {
        "x": new Date(1441324800000),
        "y": 0.8979
    },
    {
        "x": new Date(1441584000000),
        "y": 0.8973
    },
    {
        "x": new Date(1441670400000),
        "y": 0.896
    },
    {
        "x": new Date(1441756800000),
        "y": 0.8978
    },
    {
        "x": new Date(1441843200000),
        "y": 0.8942
    },
    {
        "x": new Date(1441929600000),
        "y": 0.8876
    },
    {
        "x": new Date(1442188800000),
        "y": 0.8847
    },
    {
        "x": new Date(1442275200000),
        "y": 0.8835
    },
    {
        "x": new Date(1442361600000),
        "y": 0.8907
    },
    {
        "x": new Date(1442448000000),
        "y": 0.8841
    },
    {
        "x": new Date(1442534400000),
        "y": 0.8758
    },
    {
        "x": new Date(1442793600000),
        "y": 0.889
    },
    {
        "x": new Date(1442880000000),
        "y": 0.8966
    },
    {
        "x": new Date(1442966400000),
        "y": 0.897
    },
    {
        "x": new Date(1443052800000),
        "y": 0.8897
    },
    {
        "x": new Date(1443139200000),
        "y": 0.8969
    },
    {
        "x": new Date(1443398400000),
        "y": 0.8954
    },
    {
        "x": new Date(1443484800000),
        "y": 0.8926
    },
    {
        "x": new Date(1443571200000),
        "y": 0.8927
    },
    {
        "x": new Date(1443657600000),
        "y": 0.8967
    },
    {
        "x": new Date(1443744000000),
        "y": 0.8962
    },
    {
        "x": new Date(1444003200000),
        "y": 0.8901
    },
    {
        "x": new Date(1444089600000),
        "y": 0.891
    },
    {
        "x": new Date(1444176000000),
        "y": 0.8877
    },
    {
        "x": new Date(1444262400000),
        "y": 0.8887
    },
    {
        "x": new Date(1444348800000),
        "y": 0.8802
    },
    {
        "x": new Date(1444608000000),
        "y": 0.8794
    },
    {
        "x": new Date(1444694400000),
        "y": 0.8793
    },
    {
        "x": new Date(1444780800000),
        "y": 0.8765
    },
    {
        "x": new Date(1444867200000),
        "y": 0.8743
    },
    {
        "x": new Date(1444953600000),
        "y": 0.8804
    },
    {
        "x": new Date(1445212800000),
        "y": 0.8825
    },
    {
        "x": new Date(1445299200000),
        "y": 0.8794
    },
    {
        "x": new Date(1445385600000),
        "y": 0.8808
    },
    {
        "x": new Date(1445472000000),
        "y": 0.884
    },
    {
        "x": new Date(1445558400000),
        "y": 0.9023
    },
    {
        "x": new Date(1445817600000),
        "y": 0.9083
    },
    {
        "x": new Date(1445904000000),
        "y": 0.9042
    },
    {
        "x": new Date(1445990400000),
        "y": 0.9022
    },
    {
        "x": new Date(1446076800000),
        "y": 0.915
    },
    {
        "x": new Date(1446163200000),
        "y": 0.9078
    },
    {
        "x": new Date(1446422400000),
        "y": 0.9066
    },
    {
        "x": new Date(1446508800000),
        "y": 0.9112
    },
    {
        "x": new Date(1446595200000),
        "y": 0.9146
    },
    {
        "x": new Date(1446681600000),
        "y": 0.919
    },
    {
        "x": new Date(1446768000000),
        "y": 0.9206
    },
    {
        "x": new Date(1447027200000),
        "y": 0.9281
    },
    {
        "x": new Date(1447113600000),
        "y": 0.9337
    },
    {
        "x": new Date(1447200000000),
        "y": 0.9333
    },
    {
        "x": new Date(1447286400000),
        "y": 0.9324
    },
    {
        "x": new Date(1447372800000),
        "y": 0.9291
    },
    {
        "x": new Date(1447632000000),
        "y": 0.9327
    },
    {
        "x": new Date(1447718400000),
        "y": 0.9373
    },
    {
        "x": new Date(1447804800000),
        "y": 0.9377
    },
    {
        "x": new Date(1447891200000),
        "y": 0.9358
    },
    {
        "x": new Date(1447977600000),
        "y": 0.9357
    },
    {
        "x": new Date(1448236800000),
        "y": 0.9407
    },
    {
        "x": new Date(1448323200000),
        "y": 0.939
    },
    {
        "x": new Date(1448409600000),
        "y": 0.9447
    },
    {
        "x": new Date(1448496000000),
        "y": 0.9424
    },
    {
        "x": new Date(1448582400000),
        "y": 0.9453
    },
    {
        "x": new Date(1448841600000),
        "y": 0.9454
    },
    {
        "x": new Date(1448928000000),
        "y": 0.9435
    },
    {
        "x": new Date(1449014400000),
        "y": 0.9424
    },
    {
        "x": new Date(1449100800000),
        "y": 0.9372
    },
    {
        "x": new Date(1449187200000),
        "y": 0.9174
    },
    {
        "x": new Date(1449446400000),
        "y": 0.9253
    },
    {
        "x": new Date(1449532800000),
        "y": 0.9196
    },
    {
        "x": new Date(1449619200000),
        "y": 0.9141
    },
    {
        "x": new Date(1449705600000),
        "y": 0.9139
    },
    {
        "x": new Date(1449792000000),
        "y": 0.9133
    },
    {
        "x": new Date(1450051200000),
        "y": 0.9106
    },
    {
        "x": new Date(1450137600000),
        "y": 0.91
    },
    {
        "x": new Date(1450224000000),
        "y": 0.9148
    },
    {
        "x": new Date(1450310400000),
        "y": 0.9225
    },
    {
        "x": new Date(1450396800000),
        "y": 0.9229
    },
    {
        "x": new Date(1450656000000),
        "y": 0.9201
    },
    {
        "x": new Date(1450742400000),
        "y": 0.9132
    },
    {
        "x": new Date(1450828800000),
        "y": 0.9162
    },
    {
        "x": new Date(1450915200000),
        "y": 0.9136
    },
    {
        "x": new Date(1451260800000),
        "y": 0.9123
    },
    {
        "x": new Date(1451347200000),
        "y": 0.9132
    },
    {
        "x": new Date(1451433600000),
        "y": 0.9153
    },
    {
        "x": new Date(1451520000000),
        "y": 0.9186
    },
    {
        "x": new Date(1451865600000),
        "y": 0.9177
    },
    {
        "x": new Date(1451952000000),
        "y": 0.9307
    },
    {
        "x": new Date(1452038400000),
        "y": 0.931
    },
    {
        "x": new Date(1452124800000),
        "y": 0.9202
    },
    {
        "x": new Date(1452211200000),
        "y": 0.9208
    },
    {
        "x": new Date(1452470400000),
        "y": 0.9185
    },
    {
        "x": new Date(1452556800000),
        "y": 0.9229
    },
    {
        "x": new Date(1452643200000),
        "y": 0.9247
    },
    {
        "x": new Date(1452729600000),
        "y": 0.9181
    },
    {
        "x": new Date(1452816000000),
        "y": 0.9164
    },
    {
        "x": new Date(1453075200000),
        "y": 0.9182
    },
    {
        "x": new Date(1453161600000),
        "y": 0.9202
    },
    {
        "x": new Date(1453248000000),
        "y": 0.9169
    },
    {
        "x": new Date(1453334400000),
        "y": 0.9181
    },
    {
        "x": new Date(1453420800000),
        "y": 0.9253
    },
    {
        "x": new Date(1453680000000),
        "y": 0.9247
    },
    {
        "x": new Date(1453766400000),
        "y": 0.9229
    },
    {
        "x": new Date(1453852800000),
        "y": 0.9185
    },
    {
        "x": new Date(1453939200000),
        "y": 0.9173
    },
    {
        "x": new Date(1454025600000),
        "y": 0.9159
    },
    {
        "x": new Date(1454284800000),
        "y": 0.9189
    },
    {
        "x": new Date(1454371200000),
        "y": 0.9159
    },
    {
        "x": new Date(1454457600000),
        "y": 0.9148
    },
    {
        "x": new Date(1454544000000),
        "y": 0.8925
    },
    {
        "x": new Date(1454630400000),
        "y": 0.8928
    },
    {
        "x": new Date(1454889600000),
        "y": 0.9009
    },
    {
        "x": new Date(1454976000000),
        "y": 0.8901
    },
    {
        "x": new Date(1455062400000),
        "y": 0.8884
    },
    {
        "x": new Date(1455148800000),
        "y": 0.8814
    },
    {
        "x": new Date(1455235200000),
        "y": 0.887
    },
    {
        "x": new Date(1455494400000),
        "y": 0.8946
    },
    {
        "x": new Date(1455580800000),
        "y": 0.8957
    },
    {
        "x": new Date(1455667200000),
        "y": 0.8981
    },
    {
        "x": new Date(1455753600000),
        "y": 0.9023
    },
    {
        "x": new Date(1455840000000),
        "y": 0.9013
    },
    {
        "x": new Date(1456099200000),
        "y": 0.907
    },
    {
        "x": new Date(1456185600000),
        "y": 0.909
    },
    {
        "x": new Date(1456272000000),
        "y": 0.9108
    },
    {
        "x": new Date(1456358400000),
        "y": 0.907
    },
    {
        "x": new Date(1456444800000),
        "y": 0.9087
    },
    {
        "x": new Date(1456704000000),
        "y": 0.9185
    },
    {
        "x": new Date(1456790400000),
        "y": 0.9199
    },
    {
        "x": new Date(1456876800000),
        "y": 0.9212
    },
    {
        "x": new Date(1456963200000),
        "y": 0.9174
    },
    {
        "x": new Date(1457049600000),
        "y": 0.9117
    },
    {
        "x": new Date(1457308800000),
        "y": 0.9131
    },
    {
        "x": new Date(1457395200000),
        "y": 0.9069
    },
    {
        "x": new Date(1457481600000),
        "y": 0.9114
    },
    {
        "x": new Date(1457568000000),
        "y": 0.9212
    },
    {
        "x": new Date(1457654400000),
        "y": 0.9018
    },
    {
        "x": new Date(1457913600000),
        "y": 0.8995
    },
    {
        "x": new Date(1458000000000),
        "y": 0.9003
    },
    {
        "x": new Date(1458086400000),
        "y": 0.9039
    },
    {
        "x": new Date(1458172800000),
        "y": 0.8842
    },
    {
        "x": new Date(1458259200000),
        "y": 0.8867
    },
    {
        "x": new Date(1458518400000),
        "y": 0.8873
    },
    {
        "x": new Date(1458604800000),
        "y": 0.892
    },
    {
        "x": new Date(1458691200000),
        "y": 0.8953
    },
    {
        "x": new Date(1458777600000),
        "y": 0.8966
    },
    {
        "x": new Date(1459209600000),
        "y": 0.8934
    },
    {
        "x": new Date(1459296000000),
        "y": 0.8832
    },
    {
        "x": new Date(1459382400000),
        "y": 0.8784
    },
    {
        "x": new Date(1459468800000),
        "y": 0.8748
    },
    {
        "x": new Date(1459728000000),
        "y": 0.8788
    },
    {
        "x": new Date(1459814400000),
        "y": 0.8798
    },
    {
        "x": new Date(1459900800000),
        "y": 0.8822
    },
    {
        "x": new Date(1459987200000),
        "y": 0.8801
    },
    {
        "x": new Date(1460073600000),
        "y": 0.8801
    },
    {
        "x": new Date(1460332800000),
        "y": 0.8781
    },
    {
        "x": new Date(1460419200000),
        "y": 0.8776
    },
    {
        "x": new Date(1460505600000),
        "y": 0.8852
    },
    {
        "x": new Date(1460592000000),
        "y": 0.8888
    },
    {
        "x": new Date(1460678400000),
        "y": 0.8863
    },
    {
        "x": new Date(1460937600000),
        "y": 0.8846
    },
    {
        "x": new Date(1461024000000),
        "y": 0.8817
    },
    {
        "x": new Date(1461110400000),
        "y": 0.8789
    },
    {
        "x": new Date(1461196800000),
        "y": 0.8808
    },
    {
        "x": new Date(1461283200000),
        "y": 0.888
    },
    {
        "x": new Date(1461542400000),
        "y": 0.8879
    },
    {
        "x": new Date(1461628800000),
        "y": 0.8861
    },
    {
        "x": new Date(1461715200000),
        "y": 0.8848
    },
    {
        "x": new Date(1461801600000),
        "y": 0.8805
    },
    {
        "x": new Date(1461888000000),
        "y": 0.8771
    },
    {
        "x": new Date(1462147200000),
        "y": 0.8702
    },
    {
        "x": new Date(1462233600000),
        "y": 0.8645
    },
    {
        "x": new Date(1462320000000),
        "y": 0.8693
    },
    {
        "x": new Date(1462406400000),
        "y": 0.8743
    },
    {
        "x": new Date(1462492800000),
        "y": 0.8752
    },
    {
        "x": new Date(1462752000000),
        "y": 0.8777
    },
    {
        "x": new Date(1462838400000),
        "y": 0.8792
    },
    {
        "x": new Date(1462924800000),
        "y": 0.8766
    },
    {
        "x": new Date(1463011200000),
        "y": 0.8781
    },
    {
        "x": new Date(1463097600000),
        "y": 0.8813
    },
    {
        "x": new Date(1463356800000),
        "y": 0.8832
    },
    {
        "x": new Date(1463443200000),
        "y": 0.8836
    },
    {
        "x": new Date(1463529600000),
        "y": 0.8867
    },
    {
        "x": new Date(1463616000000),
        "y": 0.8932
    },
    {
        "x": new Date(1463702400000),
        "y": 0.8914
    },
    {
        "x": new Date(1463961600000),
        "y": 0.8918
    },
    {
        "x": new Date(1464048000000),
        "y": 0.8955
    },
    {
        "x": new Date(1464134400000),
        "y": 0.8973
    },
    {
        "x": new Date(1464220800000),
        "y": 0.8955
    },
    {
        "x": new Date(1464307200000),
        "y": 0.8955
    },
    {
        "x": new Date(1464566400000),
        "y": 0.8978
    },
    {
        "x": new Date(1464652800000),
        "y": 0.8966
    },
    {
        "x": new Date(1464739200000),
        "y": 0.895
    },
    {
        "x": new Date(1464825600000),
        "y": 0.8939
    },
    {
        "x": new Date(1464912000000),
        "y": 0.8966
    },
    {
        "x": new Date(1465171200000),
        "y": 0.8812
    },
    {
        "x": new Date(1465257600000),
        "y": 0.8813
    },
    {
        "x": new Date(1465344000000),
        "y": 0.879
    },
    {
        "x": new Date(1465430400000),
        "y": 0.8817
    },
    {
        "x": new Date(1465516800000),
        "y": 0.8847
    },
    {
        "x": new Date(1465776000000),
        "y": 0.8876
    },
    {
        "x": new Date(1465862400000),
        "y": 0.891
    },
    {
        "x": new Date(1465948800000),
        "y": 0.8906
    },
    {
        "x": new Date(1466035200000),
        "y": 0.895
    },
    {
        "x": new Date(1466121600000),
        "y": 0.8887
    },
    {
        "x": new Date(1466380800000),
        "y": 0.8826
    },
    {
        "x": new Date(1466467200000),
        "y": 0.884
    },
    {
        "x": new Date(1466553600000),
        "y": 0.8864
    },
    {
        "x": new Date(1466640000000),
        "y": 0.8781
    },
    {
        "x": new Date(1466726400000),
        "y": 0.9038
    },
    {
        "x": new Date(1466985600000),
        "y": 0.9094
    },
    {
        "x": new Date(1467072000000),
        "y": 0.9032
    },
    {
        "x": new Date(1467158400000),
        "y": 0.9018
    },
    {
        "x": new Date(1467244800000),
        "y": 0.9008
    },
    {
        "x": new Date(1467331200000),
        "y": 0.8982
    },
    {
        "x": new Date(1467590400000),
        "y": 0.8979
    },
    {
        "x": new Date(1467676800000),
        "y": 0.8973
    },
    {
        "x": new Date(1467763200000),
        "y": 0.9035
    },
    {
        "x": new Date(1467849600000),
        "y": 0.9026
    },
    {
        "x": new Date(1467936000000),
        "y": 0.9034
    },
    {
        "x": new Date(1468195200000),
        "y": 0.9052
    },
    {
        "x": new Date(1468281600000),
        "y": 0.9017
    },
    {
        "x": new Date(1468368000000),
        "y": 0.9033
    },
    {
        "x": new Date(1468454400000),
        "y": 0.8964
    },
    {
        "x": new Date(1468540800000),
        "y": 0.8987
    },
    {
        "x": new Date(1468800000000),
        "y": 0.9048
    },
    {
        "x": new Date(1468886400000),
        "y": 0.9063
    },
    {
        "x": new Date(1468972800000),
        "y": 0.9081
    },
    {
        "x": new Date(1469059200000),
        "y": 0.908
    },
    {
        "x": new Date(1469145600000),
        "y": 0.908
    },
    {
        "x": new Date(1469404800000),
        "y": 0.9107
    },
    {
        "x": new Date(1469491200000),
        "y": 0.9094
    },
    {
        "x": new Date(1469577600000),
        "y": 0.9099
    },
    {
        "x": new Date(1469664000000),
        "y": 0.9018
    },
    {
        "x": new Date(1469750400000),
        "y": 0.8999
    },
    {
        "x": new Date(1470009600000),
        "y": 0.8958
    },
    {
        "x": new Date(1470096000000),
        "y": 0.8935
    },
    {
        "x": new Date(1470182400000),
        "y": 0.893
    },
    {
        "x": new Date(1470268800000),
        "y": 0.8981
    },
    {
        "x": new Date(1470355200000),
        "y": 0.8965
    },
    {
        "x": new Date(1470614400000),
        "y": 0.9021
    },
    {
        "x": new Date(1470700800000),
        "y": 0.9028
    },
    {
        "x": new Date(1470787200000),
        "y": 0.8942
    },
    {
        "x": new Date(1470873600000),
        "y": 0.8967
    },
    {
        "x": new Date(1470960000000),
        "y": 0.8963
    },
    {
        "x": new Date(1471219200000),
        "y": 0.8946
    },
    {
        "x": new Date(1471305600000),
        "y": 0.8854
    },
    {
        "x": new Date(1471392000000),
        "y": 0.8869
    },
    {
        "x": new Date(1471478400000),
        "y": 0.8834
    },
    {
        "x": new Date(1471564800000),
        "y": 0.883
    },
    {
        "x": new Date(1471824000000),
        "y": 0.8846
    },
    {
        "x": new Date(1471910400000),
        "y": 0.882
    },
    {
        "x": new Date(1471996800000),
        "y": 0.8876
    },
    {
        "x": new Date(1472083200000),
        "y": 0.8858
    },
    {
        "x": new Date(1472169600000),
        "y": 0.8858
    },
    {
        "x": new Date(1472428800000),
        "y": 0.8954
    },
    {
        "x": new Date(1472515200000),
        "y": 0.8955
    },
    {
        "x": new Date(1472601600000),
        "y": 0.8984
    },
    {
        "x": new Date(1472688000000),
        "y": 0.8973
    },
    {
        "x": new Date(1472774400000),
        "y": 0.8935
    },
    {
        "x": new Date(1473033600000),
        "y": 0.8965
    },
    {
        "x": new Date(1473120000000),
        "y": 0.8962
    },
    {
        "x": new Date(1473206400000),
        "y": 0.89
    },
    {
        "x": new Date(1473292800000),
        "y": 0.8854
    },
    {
        "x": new Date(1473379200000),
        "y": 0.8876
    },
    {
        "x": new Date(1473638400000),
        "y": 0.8909
    },
    {
        "x": new Date(1473724800000),
        "y": 0.8892
    },
    {
        "x": new Date(1473811200000),
        "y": 0.8915
    },
    {
        "x": new Date(1473897600000),
        "y": 0.8887
    },
    {
        "x": new Date(1473984000000),
        "y": 0.8909
    },
    {
        "x": new Date(1474243200000),
        "y": 0.8958
    },
    {
        "x": new Date(1474329600000),
        "y": 0.8942
    },
    {
        "x": new Date(1474416000000),
        "y": 0.897
    },
    {
        "x": new Date(1474502400000),
        "y": 0.8899
    },
    {
        "x": new Date(1474588800000),
        "y": 0.8918
    },
    {
        "x": new Date(1474848000000),
        "y": 0.888
    },
    {
        "x": new Date(1474934400000),
        "y": 0.8914
    },
    {
        "x": new Date(1475020800000),
        "y": 0.891
    },
    {
        "x": new Date(1475107200000),
        "y": 0.8913
    },
    {
        "x": new Date(1475193600000),
        "y": 0.8961
    },
    {
        "x": new Date(1475452800000),
        "y": 0.8901
    },
    {
        "x": new Date(1475539200000),
        "y": 0.8961
    },
    {
        "x": new Date(1475625600000),
        "y": 0.8921
    },
    {
        "x": new Date(1475712000000),
        "y": 0.8942
    },
    {
        "x": new Date(1475798400000),
        "y": 0.8978
    },
    {
        "x": new Date(1476057600000),
        "y": 0.8962
    },
    {
        "x": new Date(1476144000000),
        "y": 0.9027
    },
    {
        "x": new Date(1476230400000),
        "y": 0.9075
    },
    {
        "x": new Date(1476316800000),
        "y": 0.9061
    },
    {
        "x": new Date(1476403200000),
        "y": 0.909
    },
    {
        "x": new Date(1476662400000),
        "y": 0.9097
    },
    {
        "x": new Date(1476748800000),
        "y": 0.9098
    },
    {
        "x": new Date(1476835200000),
        "y": 0.9109
    },
    {
        "x": new Date(1476921600000),
        "y": 0.9108
    },
    {
        "x": new Date(1477008000000),
        "y": 0.9187
    },
    {
        "x": new Date(1477267200000),
        "y": 0.9183
    },
    {
        "x": new Date(1477353600000),
        "y": 0.9199
    },
    {
        "x": new Date(1477440000000),
        "y": 0.9154
    },
    {
        "x": new Date(1477526400000),
        "y": 0.9153
    },
    {
        "x": new Date(1477612800000),
        "y": 0.9157
    },
    {
        "x": new Date(1477872000000),
        "y": 0.9137
    },
    {
        "x": new Date(1477958400000),
        "y": 0.9071
    },
    {
        "x": new Date(1478044800000),
        "y": 0.9014
    },
    {
        "x": new Date(1478131200000),
        "y": 0.9039
    },
    {
        "x": new Date(1478217600000),
        "y": 0.9016
    },
    {
        "x": new Date(1478476800000),
        "y": 0.9041
    },
    {
        "x": new Date(1478563200000),
        "y": 0.9061
    },
    {
        "x": new Date(1478649600000),
        "y": 0.9074
    },
    {
        "x": new Date(1478736000000),
        "y": 0.918
    },
    {
        "x": new Date(1478822400000),
        "y": 0.9172
    },
    {
        "x": new Date(1479081600000),
        "y": 0.928
    },
    {
        "x": new Date(1479168000000),
        "y": 0.929
    },
    {
        "x": new Date(1479254400000),
        "y": 0.9345
    },
    {
        "x": new Date(1479340800000),
        "y": 0.9332
    },
    {
        "x": new Date(1479427200000),
        "y": 0.9409
    },
    {
        "x": new Date(1479686400000),
        "y": 0.9407
    },
    {
        "x": new Date(1479772800000),
        "y": 0.942
    },
    {
        "x": new Date(1479859200000),
        "y": 0.9433
    },
    {
        "x": new Date(1479945600000),
        "y": 0.9481
    },
    {
        "x": new Date(1480032000000),
        "y": 0.9442
    },
    {
        "x": new Date(1480291200000),
        "y": 0.9446
    },
    {
        "x": new Date(1480377600000),
        "y": 0.9456
    },
    {
        "x": new Date(1480464000000),
        "y": 0.9404
    },
    {
        "x": new Date(1480550400000),
        "y": 0.9411
    },
    {
        "x": new Date(1480636800000),
        "y": 0.9398
    },
    {
        "x": new Date(1480896000000),
        "y": 0.9345
    },
    {
        "x": new Date(1480982400000),
        "y": 0.9317
    },
    {
        "x": new Date(1481068800000),
        "y": 0.9321
    },
    {
        "x": new Date(1481155200000),
        "y": 0.9293
    },
    {
        "x": new Date(1481241600000),
        "y": 0.9472
    },
    {
        "x": new Date(1481500800000),
        "y": 0.9439
    },
    {
        "x": new Date(1481587200000),
        "y": 0.9426
    },
    {
        "x": new Date(1481673600000),
        "y": 0.9396
    },
    {
        "x": new Date(1481760000000),
        "y": 0.9599
    },
    {
        "x": new Date(1481846400000),
        "y": 0.958
    },
    {
        "x": new Date(1482105600000),
        "y": 0.9596
    },
    {
        "x": new Date(1482192000000),
        "y": 0.965
    },
    {
        "x": new Date(1482278400000),
        "y": 0.9597
    },
    {
        "x": new Date(1482364800000),
        "y": 0.9576
    },
    {
        "x": new Date(1482451200000),
        "y": 0.9574
    },
    {
        "x": new Date(1482796800000),
        "y": 0.9575
    },
    {
        "x": new Date(1482883200000),
        "y": 0.9615
    },
    {
        "x": new Date(1482969600000),
        "y": 0.9568
    },
    {
        "x": new Date(1483056000000),
        "y": 0.9488
    },
    {
        "x": new Date(1483315200000),
        "y": 0.9557
    },
    {
        "x": new Date(1483401600000),
        "y": 0.963
    },
    {
        "x": new Date(1483488000000),
        "y": 0.9582
    },
    {
        "x": new Date(1483574400000),
        "y": 0.9524
    },
    {
        "x": new Date(1483660800000),
        "y": 0.9445
    },
    {
        "x": new Date(1483920000000),
        "y": 0.951
    },
    {
        "x": new Date(1484006400000),
        "y": 0.9464
    },
    {
        "x": new Date(1484092800000),
        "y": 0.9522
    },
    {
        "x": new Date(1484179200000),
        "y": 0.9365
    },
    {
        "x": new Date(1484265600000),
        "y": 0.9381
    },
    {
        "x": new Date(1484524800000),
        "y": 0.944
    },
    {
        "x": new Date(1484611200000),
        "y": 0.9361
    },
    {
        "x": new Date(1484697600000),
        "y": 0.9378
    },
    {
        "x": new Date(1484784000000),
        "y": 0.9375
    },
    {
        "x": new Date(1484870400000),
        "y": 0.9407
    },
    {
        "x": new Date(1485129600000),
        "y": 0.9334
    },
    {
        "x": new Date(1485216000000),
        "y": 0.9305
    },
    {
        "x": new Date(1485302400000),
        "y": 0.9309
    },
    {
        "x": new Date(1485388800000),
        "y": 0.9347
    },
    {
        "x": new Date(1485475200000),
        "y": 0.9363
    },
    {
        "x": new Date(1485734400000),
        "y": 0.9408
    },
    {
        "x": new Date(1485820800000),
        "y": 0.9299
    },
    {
        "x": new Date(1485907200000),
        "y": 0.9269
    },
    {
        "x": new Date(1485993600000),
        "y": 0.9253
    },
    {
        "x": new Date(1486080000000),
        "y": 0.9311
    },
    {
        "x": new Date(1486339200000),
        "y": 0.9336
    },
    {
        "x": new Date(1486425600000),
        "y": 0.9369
    },
    {
        "x": new Date(1486512000000),
        "y": 0.9377
    },
    {
        "x": new Date(1486598400000),
        "y": 0.9354
    },
    {
        "x": new Date(1486684800000),
        "y": 0.9409
    },
    {
        "x": new Date(1486944000000),
        "y": 0.9409
    },
    {
        "x": new Date(1487030400000),
        "y": 0.9415
    },
    {
        "x": new Date(1487116800000),
        "y": 0.9475
    },
    {
        "x": new Date(1487203200000),
        "y": 0.9389
    },
    {
        "x": new Date(1487289600000),
        "y": 0.9391
    },
    {
        "x": new Date(1487548800000),
        "y": 0.9421
    },
    {
        "x": new Date(1487635200000),
        "y": 0.9491
    },
    {
        "x": new Date(1487721600000),
        "y": 0.9513
    },
    {
        "x": new Date(1487808000000),
        "y": 0.9459
    },
    {
        "x": new Date(1487894400000),
        "y": 0.9427
    },
    {
        "x": new Date(1488153600000),
        "y": 0.9447
    },
    {
        "x": new Date(1488240000000),
        "y": 0.9438
    },
    {
        "x": new Date(1488326400000),
        "y": 0.9495
    },
    {
        "x": new Date(1488412800000),
        "y": 0.9512
    },
    {
        "x": new Date(1488499200000),
        "y": 0.9466
    },
    {
        "x": new Date(1488758400000),
        "y": 0.9442
    },
    {
        "x": new Date(1488844800000),
        "y": 0.9456
    },
    {
        "x": new Date(1488931200000),
        "y": 0.9474
    },
    {
        "x": new Date(1489017600000),
        "y": 0.9479
    },
    {
        "x": new Date(1489104000000),
        "y": 0.943
    },
    {
        "x": new Date(1489363200000),
        "y": 0.9379
    },
    {
        "x": new Date(1489449600000),
        "y": 0.9407
    },
    {
        "x": new Date(1489536000000),
        "y": 0.9415
    },
    {
        "x": new Date(1489622400000),
        "y": 0.9324
    },
    {
        "x": new Date(1489708800000),
        "y": 0.9315
    },
    {
        "x": new Date(1489968000000),
        "y": 0.9302
    },
    {
        "x": new Date(1490054400000),
        "y": 0.9259
    },
    {
        "x": new Date(1490140800000),
        "y": 0.9254
    },
    {
        "x": new Date(1490227200000),
        "y": 0.9272
    },
    {
        "x": new Date(1490313600000),
        "y": 0.9256
    },
    {
        "x": new Date(1490572800000),
        "y": 0.9185
    },
    {
        "x": new Date(1490659200000),
        "y": 0.921
    },
    {
        "x": new Date(1490745600000),
        "y": 0.9305
    },
    {
        "x": new Date(1490832000000),
        "y": 0.9315
    },
    {
        "x": new Date(1490918400000),
        "y": 0.9355
    },
    {
        "x": new Date(1491177600000),
        "y": 0.9381
    },
    {
        "x": new Date(1491264000000),
        "y": 0.939
    },
    {
        "x": new Date(1491350400000),
        "y": 0.9366
    },
    {
        "x": new Date(1491436800000),
        "y": 0.9377
    },
    {
        "x": new Date(1491523200000),
        "y": 0.9408
    },
    {
        "x": new Date(1491782400000),
        "y": 0.9455
    },
    {
        "x": new Date(1491868800000),
        "y": 0.9421
    },
    {
        "x": new Date(1491955200000),
        "y": 0.9431
    },
    {
        "x": new Date(1492041600000),
        "y": 0.9408
    },
    {
        "x": new Date(1492473600000),
        "y": 0.9363
    },
    {
        "x": new Date(1492560000000),
        "y": 0.9325
    },
    {
        "x": new Date(1492646400000),
        "y": 0.9308
    },
    {
        "x": new Date(1492732800000),
        "y": 0.9349
    },
    {
        "x": new Date(1492992000000),
        "y": 0.9219
    },
    {
        "x": new Date(1493078400000),
        "y": 0.9183
    },
    {
        "x": new Date(1493164800000),
        "y": 0.9181
    },
    {
        "x": new Date(1493251200000),
        "y": 0.9191
    },
    {
        "x": new Date(1493337600000),
        "y": 0.915
    },
    {
        "x": new Date(1493683200000),
        "y": 0.9163
    },
    {
        "x": new Date(1493769600000),
        "y": 0.9159
    },
    {
        "x": new Date(1493856000000),
        "y": 0.9153
    },
    {
        "x": new Date(1493942400000),
        "y": 0.9124
    },
    {
        "x": new Date(1494201600000),
        "y": 0.9143
    },
    {
        "x": new Date(1494288000000),
        "y": 0.9185
    },
    {
        "x": new Date(1494374400000),
        "y": 0.919
    },
    {
        "x": new Date(1494460800000),
        "y": 0.9209
    },
    {
        "x": new Date(1494547200000),
        "y": 0.9196
    },
    {
        "x": new Date(1494806400000),
        "y": 0.9115
    },
    {
        "x": new Date(1494892800000),
        "y": 0.9043
    },
    {
        "x": new Date(1494979200000),
        "y": 0.8996
    },
    {
        "x": new Date(1495065600000),
        "y": 0.8987
    },
    {
        "x": new Date(1495152000000),
        "y": 0.8946
    },
    {
        "x": new Date(1495411200000),
        "y": 0.8895
    },
    {
        "x": new Date(1495497600000),
        "y": 0.8918
    },
    {
        "x": new Date(1495584000000),
        "y": 0.8935
    },
    {
        "x": new Date(1495670400000),
        "y": 0.8918
    },
    {
        "x": new Date(1495756800000),
        "y": 0.8933
    },
    {
        "x": new Date(1496016000000),
        "y": 0.8939
    },
    {
        "x": new Date(1496102400000),
        "y": 0.8951
    },
    {
        "x": new Date(1496188800000),
        "y": 0.8913
    },
    {
        "x": new Date(1496275200000),
        "y": 0.8914
    },
    {
        "x": new Date(1496361600000),
        "y": 0.8916
    },
    {
        "x": new Date(1496620800000),
        "y": 0.8891
    },
    {
        "x": new Date(1496707200000),
        "y": 0.8884
    },
    {
        "x": new Date(1496793600000),
        "y": 0.8916
    },
    {
        "x": new Date(1496880000000),
        "y": 0.8907
    },
    {
        "x": new Date(1496966400000),
        "y": 0.8949
    },
    {
        "x": new Date(1497225600000),
        "y": 0.8913
    },
    {
        "x": new Date(1497312000000),
        "y": 0.8916
    },
    {
        "x": new Date(1497398400000),
        "y": 0.8927
    },
    {
        "x": new Date(1497484800000),
        "y": 0.8957
    },
    {
        "x": new Date(1497571200000),
        "y": 0.8956
    },
    {
        "x": new Date(1497830400000),
        "y": 0.893
    },
    {
        "x": new Date(1497916800000),
        "y": 0.8965
    },
    {
        "x": new Date(1498003200000),
        "y": 0.8972
    },
    {
        "x": new Date(1498089600000),
        "y": 0.8954
    },
    {
        "x": new Date(1498176000000),
        "y": 0.8951
    },
    {
        "x": new Date(1498435200000),
        "y": 0.894
    },
    {
        "x": new Date(1498521600000),
        "y": 0.8868
    },
    {
        "x": new Date(1498608000000),
        "y": 0.8792
    },
    {
        "x": new Date(1498694400000),
        "y": 0.8763
    },
    {
        "x": new Date(1498780800000),
        "y": 0.8764
    },
    {
        "x": new Date(1499040000000),
        "y": 0.8797
    },
    {
        "x": new Date(1499126400000),
        "y": 0.8809
    },
    {
        "x": new Date(1499212800000),
        "y": 0.8828
    },
    {
        "x": new Date(1499299200000),
        "y": 0.8784
    },
    {
        "x": new Date(1499385600000),
        "y": 0.8764
    },
    {
        "x": new Date(1499644800000),
        "y": 0.8783
    },
    {
        "x": new Date(1499731200000),
        "y": 0.8769
    },
    {
        "x": new Date(1499817600000),
        "y": 0.8735
    },
    {
        "x": new Date(1499904000000),
        "y": 0.876
    },
    {
        "x": new Date(1499990400000),
        "y": 0.8761
    },
    {
        "x": new Date(1500249600000),
        "y": 0.8725
    },
    {
        "x": new Date(1500336000000),
        "y": 0.8655
    },
    {
        "x": new Date(1500422400000),
        "y": 0.8672
    },
    {
        "x": new Date(1500508800000),
        "y": 0.8708
    },
    {
        "x": new Date(1500595200000),
        "y": 0.8591
    },
    {
        "x": new Date(1500854400000),
        "y": 0.8586
    },
    {
        "x": new Date(1500940800000),
        "y": 0.8552
    },
    {
        "x": new Date(1501027200000),
        "y": 0.8589
    },
    {
        "x": new Date(1501113600000),
        "y": 0.8552
    },
    {
        "x": new Date(1501200000000),
        "y": 0.8527
    },
    {
        "x": new Date(1501459200000),
        "y": 0.8528
    },
    {
        "x": new Date(1501545600000),
        "y": 0.8467
    },
    {
        "x": new Date(1501632000000),
        "y": 0.8455
    },
    {
        "x": new Date(1501718400000),
        "y": 0.8433
    },
    {
        "x": new Date(1501804800000),
        "y": 0.8427
    },
    {
        "x": new Date(1502064000000),
        "y": 0.8478
    },
    {
        "x": new Date(1502150400000),
        "y": 0.8466
    },
    {
        "x": new Date(1502236800000),
        "y": 0.8525
    },
    {
        "x": new Date(1502323200000),
        "y": 0.8525
    },
    {
        "x": new Date(1502409600000),
        "y": 0.8501
    },
    {
        "x": new Date(1502668800000),
        "y": 0.8478
    },
    {
        "x": new Date(1502755200000),
        "y": 0.8516
    },
    {
        "x": new Date(1502841600000),
        "y": 0.8541
    },
    {
        "x": new Date(1502928000000),
        "y": 0.855
    },
    {
        "x": new Date(1503014400000),
        "y": 0.8519
    },
    {
        "x": new Date(1503273600000),
        "y": 0.8504
    },
    {
        "x": new Date(1503360000000),
        "y": 0.8496
    },
    {
        "x": new Date(1503446400000),
        "y": 0.8476
    },
    {
        "x": new Date(1503532800000),
        "y": 0.8471
    },
    {
        "x": new Date(1503619200000),
        "y": 0.847
    },
    {
        "x": new Date(1503878400000),
        "y": 0.8387
    },
    {
        "x": new Date(1503964800000),
        "y": 0.8301
    },
    {
        "x": new Date(1504051200000),
        "y": 0.8393
    },
    {
        "x": new Date(1504137600000),
        "y": 0.8458
    },
    {
        "x": new Date(1504224000000),
        "y": 0.839
    },
    {
        "x": new Date(1504483200000),
        "y": 0.8401
    },
    {
        "x": new Date(1504569600000),
        "y": 0.8411
    },
    {
        "x": new Date(1504656000000),
        "y": 0.8383
    },
    {
        "x": new Date(1504742400000),
        "y": 0.8355
    },
    {
        "x": new Date(1504828800000),
        "y": 0.8293
    },
    {
        "x": new Date(1505088000000),
        "y": 0.8336
    },
    {
        "x": new Date(1505174400000),
        "y": 0.8381
    },
    {
        "x": new Date(1505260800000),
        "y": 0.8349
    },
    {
        "x": new Date(1505347200000),
        "y": 0.8415
    },
    {
        "x": new Date(1505433600000),
        "y": 0.836
    },
    {
        "x": new Date(1505692800000),
        "y": 0.8371
    },
    {
        "x": new Date(1505779200000),
        "y": 0.8354
    },
    {
        "x": new Date(1505865600000),
        "y": 0.8329
    },
    {
        "x": new Date(1505952000000),
        "y": 0.8401
    },
    {
        "x": new Date(1506038400000),
        "y": 0.8362
    },
    {
        "x": new Date(1506297600000),
        "y": 0.8428
    },
    {
        "x": new Date(1506384000000),
        "y": 0.8485
    },
    {
        "x": new Date(1506470400000),
        "y": 0.8518
    },
    {
        "x": new Date(1506556800000),
        "y": 0.8491
    },
    {
        "x": new Date(1506643200000),
        "y": 0.8471
    },
    {
        "x": new Date(1506902400000),
        "y": 0.8516
    },
    {
        "x": new Date(1506988800000),
        "y": 0.8509
    },
    {
        "x": new Date(1507075200000),
        "y": 0.8485
    },
    {
        "x": new Date(1507161600000),
        "y": 0.8517
    },
    {
        "x": new Date(1507248000000),
        "y": 0.8543
    },
    {
        "x": new Date(1507507200000),
        "y": 0.8515
    },
    {
        "x": new Date(1507593600000),
        "y": 0.8478
    },
    {
        "x": new Date(1507680000000),
        "y": 0.8454
    },
    {
        "x": new Date(1507766400000),
        "y": 0.8436
    },
    {
        "x": new Date(1507852800000),
        "y": 0.8468
    },
    {
        "x": new Date(1508112000000),
        "y": 0.8473
    },
    {
        "x": new Date(1508198400000),
        "y": 0.8505
    },
    {
        "x": new Date(1508284800000),
        "y": 0.8512
    },
    {
        "x": new Date(1508371200000),
        "y": 0.8451
    },
    {
        "x": new Date(1508457600000),
        "y": 0.8463
    },
    {
        "x": new Date(1508716800000),
        "y": 0.8519
    },
    {
        "x": new Date(1508803200000),
        "y": 0.8504
    },
    {
        "x": new Date(1508889600000),
        "y": 0.8486
    },
    {
        "x": new Date(1508976000000),
        "y": 0.8509
    },
    {
        "x": new Date(1509062400000),
        "y": 0.8618
    },
    {
        "x": new Date(1509321600000),
        "y": 0.8613
    },
    {
        "x": new Date(1509408000000),
        "y": 0.8594
    },
    {
        "x": new Date(1509494400000),
        "y": 0.8613
    },
    {
        "x": new Date(1509580800000),
        "y": 0.8588
    },
    {
        "x": new Date(1509667200000),
        "y": 0.858
    },
    {
        "x": new Date(1509926400000),
        "y": 0.8629
    },
    {
        "x": new Date(1510012800000),
        "y": 0.865
    },
    {
        "x": new Date(1510099200000),
        "y": 0.8629
    },
    {
        "x": new Date(1510185600000),
        "y": 0.8599
    },
    {
        "x": new Date(1510272000000),
        "y": 0.8582
    },
    {
        "x": new Date(1510531200000),
        "y": 0.858
    },
    {
        "x": new Date(1510617600000),
        "y": 0.8515
    },
    {
        "x": new Date(1510704000000),
        "y": 0.8447
    },
    {
        "x": new Date(1510790400000),
        "y": 0.8496
    },
    {
        "x": new Date(1510876800000),
        "y": 0.8479
    },
    {
        "x": new Date(1511136000000),
        "y": 0.8489
    },
    {
        "x": new Date(1511222400000),
        "y": 0.8535
    },
    {
        "x": new Date(1511308800000),
        "y": 0.8512
    },
    {
        "x": new Date(1511395200000),
        "y": 0.8441
    },
    {
        "x": new Date(1511481600000),
        "y": 0.8421
    },
    {
        "x": new Date(1511740800000),
        "y": 0.8368
    },
    {
        "x": new Date(1511827200000),
        "y": 0.8413
    },
    {
        "x": new Date(1511913600000),
        "y": 0.8456
    },
    {
        "x": new Date(1512000000000),
        "y": 0.8441
    },
    {
        "x": new Date(1512086400000),
        "y": 0.8415
    },
    {
        "x": new Date(1512345600000),
        "y": 0.8429
    },
    {
        "x": new Date(1512432000000),
        "y": 0.8442
    },
    {
        "x": new Date(1512518400000),
        "y": 0.8463
    },
    {
        "x": new Date(1512604800000),
        "y": 0.8486
    },
    {
        "x": new Date(1512691200000),
        "y": 0.8517
    },
    {
        "x": new Date(1512950400000),
        "y": 0.8478
    },
    {
        "x": new Date(1513036800000),
        "y": 0.85
    },
    {
        "x": new Date(1513123200000),
        "y": 0.8522
    },
    {
        "x": new Date(1513209600000),
        "y": 0.8443
    },
    {
        "x": new Date(1513296000000),
        "y": 0.8471
    },
    {
        "x": new Date(1513555200000),
        "y": 0.8479
    },
    {
        "x": new Date(1513641600000),
        "y": 0.8459
    },
    {
        "x": new Date(1513728000000),
        "y": 0.8443
    },
    {
        "x": new Date(1513814400000),
        "y": 0.8433
    },
    {
        "x": new Date(1513900800000),
        "y": 0.8438
    },
    {
        "x": new Date(1514332800000),
        "y": 0.8408
    },
    {
        "x": new Date(1514419200000),
        "y": 0.838
    },
    {
        "x": new Date(1514505600000),
        "y": 0.8339
    }
];


var chartData = [
    {
        x: new Date('2012-04-02'),
        open: 85.9757,
        high: 90.6657,
        low: 85.7685,
        close: 90.5257,
        volume: 660187068
    },
    {
        x: new Date('2012-04-09'),
        open: 89.4471,
        high: 92,
        low: 86.2157,
        close: 86.4614,
        volume: 912634864
    },
    {
        x: new Date('2012-04-16'),
        open: 87.1514,
        high: 88.6071,
        low: 81.4885,
        close: 81.8543,
        volume: 1221746066
    },
    {
        x: new Date('2012-04-23'),
        open: 81.5157,
        high: 88.2857,
        low: 79.2857,
        close: 86.1428,
        volume: 965935749
    },
    {
        x: new Date('2012-04-30'),
        open: 85.4,
        high: 85.4857,
        low: 80.7385,
        close: 80.75,
        volume: 615249365
    },
    {
        x: new Date('2012-05-07'),
        open: 80.2143,
        high: 82.2685,
        low: 79.8185,
        close: 80.9585,
        volume: 541742692
    },
    {
        x: new Date('2012-05-14'),
        open: 80.3671,
        high: 81.0728,
        low: 74.5971,
        close: 75.7685,
        volume: 708126233
    },
    {
        x: new Date('2012-05-21'),
        open: 76.3571,
        high: 82.3571,
        low: 76.2928,
        close: 80.3271,
        volume: 682076215
    },
    {
        x: new Date('2012-05-28'),
        open: 81.5571,
        high: 83.0714,
        low: 80.0743,
        close: 80.1414,
        volume: 480059584
    },
    {
        x: new Date('2012-06-04'),
        open: 80.2143,
        high: 82.9405,
        low: 78.3571,
        close: 82.9028,
        volume: 517577005
    },
    {
        x: new Date('2012-06-11'),
        open: 83.96,
        high: 84.0714,
        low: 80.9571,
        close: 82.0185,
        volume: 499693120
    },
    {
        x: new Date('2012-06-18'),
        open: 81.5657,
        high: 84.2857,
        low: 81.4814,
        close: 83.1571,
        volume: 442172142
    },
    {
        x: new Date('2012-06-25'),
        open: 82.4714,
        high: 83.4285,
        low: 80.8014,
        close: 83.4285,
        volume: 371529102
    },
    {
        x: new Date('2012-07-02'),
        open: 83.5328,
        high: 87.7628,
        low: 83.3714,
        close: 86.5543,
        volume: 385906790
    },
    {
        x: new Date('2012-07-09'),
        open: 86.4714,
        high: 88.5528,
        low: 84.6685,
        close: 86.4243,
        volume: 524235196
    },
    {
        x: new Date('2012-07-16'),
        open: 86.4457,
        high: 87.9071,
        low: 86.1643,
        close: 86.3285,
        volume: 419537217
    },
    {
        x: new Date('2012-07-23'),
        open: 84.9143,
        high: 87.0971,
        low: 81.4285,
        close: 83.5943,
        volume: 680773023
    },
    {
        x: new Date('2012-07-30'),
        open: 84.4171,
        high: 88.2828,
        low: 83.9743,
        close: 87.9571,
        volume: 475109323
    },
    {
        x: new Date('2012-08-06'),
        open: 88.1843,
        high: 89.2857,
        low: 87.8943,
        close: 88.8143,
        volume: 312826308
    },
    {
        x: new Date('2012-08-13'),
        open: 89.0557,
        high: 92.5985,
        low: 89.0357,
        close: 92.5871,
        volume: 392867193
    },
    {
        x: new Date('2012-08-20'),
        open: 92.8585,
        high: 96.4114,
        low: 92.5871,
        close: 94.746,
        volume: 708614692
    },
    {
        x: new Date('2012-08-27'),
        open: 97.1414,
        high: 97.2671,
        low: 93.8928,
        close: 95.0343,
        volume: 383807217
    },
    {
        x: new Date('2012-09-03'),
        open: 95.1085,
        high: 97.4971,
        low: 94.9285,
        close: 97.2057,
        volume: 355722047
    },
    {
        x: new Date('2012-09-10'),
        open: 97.2071,
        high: 99.5685,
        low: 93.7143,
        close: 98.7543,
        volume: 724042207
    },
    {
        x: new Date('2012-09-17'),
        open: 99.9071,
        high: 100.7243,
        low: 99.0885,
        close: 100.0135,
        volume: 500166040
    },
    {
        x: new Date('2012-09-24'),
        open: 98.1228,
        high: 99.3028,
        low: 94.3357,
        close: 95.3007,
        volume: 714507994
    },
    {
        x: new Date('2012-10-01'),
        open: 95.88,
        high: 96.6785,
        low: 92.95,
        close: 93.2271,
        volume: 638543622
    },
    {
        x: new Date('2012-10-08'),
        open: 92.4114,
        high: 92.5085,
        low: 89.0785,
        close: 89.9591,
        volume: 747127724
    },
    {
        x: new Date('2012-10-15'),
        open: 90.3357,
        high: 93.2557,
        low: 87.0885,
        close: 87.12,
        volume: 646996264
    },
    {
        x: new Date('2012-10-22'),
        open: 87.4885,
        high: 90.7685,
        low: 84.4285,
        close: 86.2857,
        volume: 866040680
    },
    {
        x: new Date('2012-10-29'),
        open: 84.9828,
        high: 86.1428,
        low: 82.1071,
        close: 82.4,
        volume: 367371310
    },
    {
        x: new Date('2012-11-05'),
        open: 83.3593,
        high: 84.3914,
        low: 76.2457,
        close: 78.1514,
        volume: 919719846
    },
    {
        x: new Date('2012-11-12'),
        open: 79.1643,
        high: 79.2143,
        low: 72.25,
        close: 75.3825,
        volume: 894382149
    },
    {
        x: new Date('2012-11-19'),
        open: 77.2443,
        high: 81.7143,
        low: 77.1257,
        close: 81.6428,
        volume: 527416747
    },
    {
        x: new Date('2012-11-26'),
        open: 82.2714,
        high: 84.8928,
        low: 81.7514,
        close: 83.6114,
        volume: 646467974
    },
    {
        x: new Date('2012-12-03'),
        open: 84.8071,
        high: 84.9414,
        low: 74.09,
        close: 76.1785,
        volume: 980096264
    },
    {
        x: new Date('2012-12-10'),
        open: 75,
        high: 78.5085,
        low: 72.2257,
        close: 72.8277,
        volume: 835016110
    },
    {
        x: new Date('2012-12-17'),
        open: 72.7043,
        high: 76.4143,
        low: 71.6043,
        close: 74.19,
        volume: 726150329
    },
    {
        x: new Date('2012-12-24'),
        open: 74.3357,
        high: 74.8928,
        low: 72.0943,
        close: 72.7984,
        volume: 321104733
    },
    {
        x: new Date('2012-12-31'),
        open: 72.9328,
        high: 79.2857,
        low: 72.7143,
        close: 75.2857,
        volume: 540854882
    },
    {
        x: new Date('2013-01-07'),
        open: 74.5714,
        high: 75.9843,
        low: 73.6,
        close: 74.3285,
        volume: 574594262
    },
    {
        x: new Date('2013-01-14'),
        open: 71.8114,
        high: 72.9643,
        low: 69.0543,
        close: 71.4285,
        volume: 803105621
    },
    {
        x: new Date('2013-01-21'),
        open: 72.08,
        high: 73.57,
        low: 62.1428,
        close: 62.84,
        volume: 971912560
    },
    {
        x: new Date('2013-01-28'),
        open: 62.5464,
        high: 66.0857,
        low: 62.2657,
        close: 64.8028,
        volume: 656549587
    },
    {
        x: new Date('2013-02-04'),
        open: 64.8443,
        high: 68.4014,
        low: 63.1428,
        close: 67.8543,
        volume: 743778993
    },
    {
        x: new Date('2013-02-11'),
        open: 68.0714,
        high: 69.2771,
        low: 65.7028,
        close: 65.7371,
        volume: 585292366
    },
    {
        x: new Date('2013-02-18'),
        open: 65.8714,
        high: 66.1043,
        low: 63.26,
        close: 64.4014,
        volume: 421766997
    },
    {
        x: new Date('2013-02-25'),
        open: 64.8357,
        high: 65.0171,
        low: 61.4257,
        close: 61.4957,
        volume: 582741215
    },
    {
        x: new Date('2013-03-04'),
        open: 61.1143,
        high: 62.2043,
        low: 59.8571,
        close: 61.6743,
        volume: 632856539
    },
    {
        x: new Date('2013-03-11'),
        open: 61.3928,
        high: 63.4614,
        low: 60.7343,
        close: 63.38,
        volume: 572066981
    },
    {
        x: new Date('2013-03-18'),
        open: 63.0643,
        high: 66.0143,
        low: 63.0286,
        close: 65.9871,
        volume: 552156035
    },
    {
        x: new Date('2013-03-25'),
        open: 66.3843,
        high: 67.1357,
        low: 63.0886,
        close: 63.2371,
        volume: 390762517
    },
    {
        x: new Date('2013-04-01'),
        open: 63.1286,
        high: 63.3854,
        low: 59.9543,
        close: 60.4571,
        volume: 505273732
    },
    {
        x: new Date('2013-04-08'),
        open: 60.6928,
        high: 62.57,
        low: 60.3557,
        close: 61.4,
        volume: 387323550
    },
    {
        x: new Date('2013-04-15'),
        open: 61,
        high: 61.1271,
        low: 55.0143,
        close: 55.79,
        volume: 709945604
    },
    {
        x: new Date('2013-04-22'),
        open: 56.0914,
        high: 59.8241,
        low: 55.8964,
        close: 59.6007,
        volume: 787007506
    },
    {
        x: new Date('2013-04-29'),
        open: 60.0643,
        high: 64.7471,
        low: 60,
        close: 64.2828,
        volume: 655020017
    },
    {
        x: new Date('2013-05-06'),
        open: 65.1014,
        high: 66.5357,
        low: 64.3543,
        close: 64.71,
        volume: 545488533
    },
    {
        x: new Date('2013-05-13'),
        open: 64.5014,
        high: 65.4143,
        low: 59.8428,
        close: 61.8943,
        volume: 633706550
    },
    {
        x: new Date('2013-05-20'),
        open: 61.7014,
        high: 64.05,
        low: 61.4428,
        close: 63.5928,
        volume: 494379068
    },
    {
        x: new Date('2013-05-27'),
        open: 64.2714,
        high: 65.3,
        low: 62.7714,
        close: 64.2478,
        volume: 362907830
    },
    {
        x: new Date('2013-06-03'),
        open: 64.39,
        high: 64.9186,
        low: 61.8243,
        close: 63.1158,
        volume: 443249793
    },
    {
        x: new Date('2013-06-10'),
        open: 63.5328,
        high: 64.1541,
        low: 61.2143,
        close: 61.4357,
        volume: 389680092
    },
    {
        x: new Date('2013-06-17'),
        open: 61.6343,
        high: 62.2428,
        low: 58.3,
        close: 59.0714,
        volume: 400384818
    },
    {
        x: new Date('2013-06-24'),
        open: 58.2,
        high: 58.38,
        low: 55.5528,
        close: 56.6471,
        volume: 519314826
    },
    {
        x: new Date('2013-07-01'),
        open: 57.5271,
        high: 60.47,
        low: 57.3171,
        close: 59.6314,
        volume: 343878841
    },
    {
        x: new Date('2013-07-08'),
        open: 60.0157,
        high: 61.3986,
        low: 58.6257,
        close: 60.93,
        volume: 384106977
    },
    {
        x: new Date('2013-07-15'),
        open: 60.7157,
        high: 62.1243,
        low: 60.5957,
        close: 60.7071,
        volume: 286035513
    },
    {
        x: new Date('2013-07-22'),
        open: 61.3514,
        high: 63.5128,
        low: 59.8157,
        close: 62.9986,
        volume: 395816827
    },
    {
        x: new Date('2013-07-29'),
        open: 62.9714,
        high: 66.1214,
        low: 62.8857,
        close: 66.0771,
        volume: 339668858
    },
    {
        x: new Date('2013-08-05'),
        open: 66.3843,
        high: 67.4128,
        low: 64.8071,
        close: 64.9214,
        volume: 368486781
    },
    {
        x: new Date('2013-08-12'),
        open: 65.2657,
        high: 72.0357,
        low: 65.2328,
        close: 71.7614,
        volume: 711563584
    },
    {
        x: new Date('2013-08-19'),
        open: 72.0485,
        high: 73.3914,
        low: 71.1714,
        close: 71.5743,
        volume: 417119660
    },
    {
        x: new Date('2013-08-26'),
        open: 71.5357,
        high: 72.8857,
        low: 69.4286,
        close: 69.6023,
        volume: 392805888
    },
    {
        x: new Date('2013-09-02'),
        open: 70.4428,
        high: 71.7485,
        low: 69.6214,
        close: 71.1743,
        volume: 317244380
    },
    {
        x: new Date('2013-09-09'),
        open: 72.1428,
        high: 72.56,
        low: 66.3857,
        close: 66.4143,
        volume: 669376320
    },
    {
        x: new Date('2013-09-16'),
        open: 65.8571,
        high: 68.3643,
        low: 63.8886,
        close: 66.7728,
        volume: 625142677
    },
    {
        x: new Date('2013-09-23'),
        open: 70.8714,
        high: 70.9871,
        low: 68.6743,
        close: 68.9643,
        volume: 475274537
    },
    {
        x: new Date('2013-09-30'),
        open: 68.1786,
        high: 70.3357,
        low: 67.773,
        close: 69.0043,
        volume: 368198906
    },
    {
        x: new Date('2013-10-07'),
        open: 69.5086,
        high: 70.5486,
        low: 68.3257,
        close: 70.4017,
        volume: 361437661
    },
    {
        x: new Date('2013-10-14'),
        open: 69.9757,
        high: 72.7514,
        low: 69.9071,
        close: 72.6985,
        volume: 342694379
    },
    {
        x: new Date('2013-10-21'),
        open: 73.11,
        high: 76.1757,
        low: 72.5757,
        close: 75.1368,
        volume: 490458997
    },
    {
        x: new Date('2013-10-28'),
        open: 75.5771,
        high: 77.0357,
        low: 73.5057,
        close: 74.29,
        volume: 508130174
    },
    {
        x: new Date('2013-11-04'),
        open: 74.4428,
        high: 75.555,
        low: 73.1971,
        close: 74.3657,
        volume: 318132218
    },
    {
        x: new Date('2013-11-11'),
        open: 74.2843,
        high: 75.6114,
        low: 73.4871,
        close: 74.9987,
        volume: 306711021
    },
    {
        x: new Date('2013-11-18'),
        open: 74.9985,
        high: 75.3128,
        low: 73.3814,
        close: 74.2571,
        volume: 282778778
    },
    {
        x: new Date('2013-11-25'),
        open: 74.4314,
        high: 79.7614,
        low: 74.4285,
        close: 79.4385,
        volume: 327405302
    },
    {
        x: new Date('2013-12-02'),
        open: 79.7143,
        high: 82.1622,
        low: 78.6885,
        close: 80.0028,
        volume: 522055676
    },
    {
        x: new Date('2013-12-09'),
        open: 80.1286,
        high: 81.5671,
        low: 79.0957,
        close: 79.2043,
        volume: 387271099
    },
    {
        x: new Date('2013-12-16'),
        open: 79.2885,
        high: 80.377,
        low: 76.9714,
        close: 78.4314,
        volume: 457580848
    },
    {
        x: new Date('2013-12-23'),
        open: 81.1428,
        high: 81.6971,
        low: 79.9285,
        close: 80.0128,
        volume: 274253503
    },
    {
        x: new Date('2013-12-30'),
        open: 79.6371,
        high: 80.1828,
        low: 77.2043,
        close: 77.2828,
        volume: 275734934
    },
    {
        x: new Date('2014-01-06'),
        open: 76.7785,
        high: 78.1228,
        low: 75.8728,
        close: 76.1343,
        volume: 393462075
    },
    {
        x: new Date('2014-01-13'),
        open: 75.7014,
        high: 80.0285,
        low: 75.6971,
        close: 77.2385,
        volume: 439557459
    },
    {
        x: new Date('2014-01-20'),
        open: 77.2843,
        high: 79.6128,
        low: 77.2028,
        close: 78.01,
        volume: 385585525
    },
    {
        x: new Date('2014-01-27'),
        open: 78.5814,
        high: 79.2571,
        low: 70.5071,
        close: 71.5143,
        volume: 813702575
    },
    {
        x: new Date('2014-02-03'),
        open: 71.8014,
        high: 74.7042,
        low: 71.3286,
        close: 74.24,
        volume: 434447570
    },
    {
        x: new Date('2014-02-10'),
        open: 74.0943,
        high: 77.9971,
        low: 74,
        close: 77.7128,
        volume: 379011880
    },
    {
        x: new Date('2014-02-17'),
        open: 78,
        high: 78.7414,
        low: 74.9428,
        close: 75.0357,
        volume: 289609443
    },
    {
        x: new Date('2014-02-24'),
        open: 74.7357,
        high: 76.1071,
        low: 73.6571,
        close: 75.1771,
        volume: 367569649
    },
    {
        x: new Date('2014-03-03'),
        open: 74.7743,
        high: 76.3928,
        low: 74.6871,
        close: 75.7771,
        volume: 275972640
    },
    {
        x: new Date('2014-03-10'),
        open: 75.48,
        high: 77.0943,
        low: 74.7143,
        close: 74.9557,
        volume: 287729528
    },
    {
        x: new Date('2014-03-17'),
        open: 75.3857,
        high: 76.6057,
        low: 75.0286,
        close: 76.1243,
        volume: 303531061
    },
    {
        x: new Date('2014-03-24'),
        open: 76.9171,
        high: 78.4285,
        low: 76.3214,
        close: 76.6943,
        volume: 338387221
    },
    {
        x: new Date('2014-03-31'),
        open: 77.0328,
        high: 77.64,
        low: 75.7971,
        close: 75.9743,
        volume: 245749459
    },
    {
        x: new Date('2014-04-07'),
        open: 75.4314,
        high: 76.0343,
        low: 73.8771,
        close: 74.23,
        volume: 312008139
    },
    {
        x: new Date('2014-04-14'),
        open: 74.5571,
        high: 75.3943,
        low: 73.0471,
        close: 74.9914,
        volume: 241209047
    },
    {
        x: new Date('2014-04-21'),
        open: 75.0485,
        high: 81.7128,
        low: 74.8514,
        close: 81.7057,
        volume: 476651465
    },
    {
        x: new Date('2014-04-28'),
        open: 81.8285,
        high: 85.6328,
        low: 81.7928,
        close: 84.6543,
        volume: 473712709
    },
    {
        x: new Date('2014-05-05'),
        open: 84.3057,
        high: 86.3442,
        low: 82.9043,
        close: 83.6489,
        volume: 365535013
    },
    {
        x: new Date('2014-05-12'),
        open: 83.9271,
        high: 85.3614,
        low: 83.6285,
        close: 85.3585,
        volume: 260931637
    },
    {
        x: new Date('2014-05-19'),
        open: 85.4071,
        high: 87.8184,
        low: 85.3328,
        close: 87.7328,
        volume: 294298274
    },
    {
        x: new Date('2014-05-26'),
        open: 87.9828,
        high: 92.0243,
        low: 87.9471,
        close: 90.4285,
        volume: 400232120
    },
    {
        x: new Date('2014-06-02'),
        open: 90.5657,
        high: 93.0371,
        low: 88.9285,
        close: 92.2243,
        volume: 412158024
    },
    {
        x: new Date('2014-06-09'),
        open: 92.7,
        high: 95.05,
        low: 90.88,
        close: 91.28,
        volume: 292422550
    },
    {
        x: new Date('2014-06-16'),
        open: 91.51,
        high: 92.75,
        low: 90.9,
        close: 90.91,
        volume: 234325480
    },
    {
        x: new Date('2014-06-23'),
        open: 91.32,
        high: 92,
        low: 89.65,
        close: 91.98,
        volume: 213712160
    },
    {
        x: new Date('2014-06-30'),
        open: 92.1,
        high: 94.1,
        low: 92.09,
        close: 94.03,
        volume: 138936570
    },
    {
        x: new Date('2014-07-07'),
        open: 94.14,
        high: 96.8,
        low: 93.52,
        close: 95.22,
        volume: 229782440
    },
    {
        x: new Date('2014-07-14'),
        open: 95.86,
        high: 97.1,
        low: 92.57,
        close: 94.43,
        volume: 248104390
    },
    {
        x: new Date('2014-07-21'),
        open: 94.99,
        high: 97.88,
        low: 93.72,
        close: 97.671,
        volume: 273021350
    },
    {
        x: new Date('2014-07-28'),
        open: 97.82,
        high: 99.44,
        low: 94.81,
        close: 96.13,
        volume: 235868530
    },
    {
        x: new Date('2014-08-04'),
        open: 96.37,
        high: 96.58,
        low: 93.28,
        close: 94.74,
        volume: 222522120
    },
    {
        x: new Date('2014-08-11'),
        open: 95.27,
        high: 98.19,
        low: 94.8355,
        close: 97.98,
        volume: 178806580
    },
    {
        x: new Date('2014-08-18'),
        open: 98.49,
        high: 101.47,
        low: 97.98,
        close: 101.32,
        volume: 246446280
    },
    {
        x: new Date('2014-08-25'),
        open: 101.79,
        high: 102.9,
        low: 100.7,
        close: 102.5,
        volume: 232858250
    },
    {
        x: new Date('2014-09-01'),
        open: 103.06,
        high: 103.74,
        low: 97.79,
        close: 98.97,
        volume: 322045910
    },
    {
        x: new Date('2014-09-08'),
        open: 99.3,
        high: 103.08,
        low: 96.14,
        close: 101.66,
        volume: 460851840
    },
    {
        x: new Date('2014-09-15'),
        open: 102.81,
        high: 103.05,
        low: 98.89,
        close: 100.96,
        volume: 296425730
    },
    {
        x: new Date('2014-09-22'),
        open: 101.8,
        high: 102.94,
        low: 97.72,
        close: 100.75,
        volume: 337617850
    },
    {
        x: new Date('2014-09-29'),
        open: 98.65,
        high: 101.54,
        low: 98.04,
        close: 99.62,
        volume: 246900230
    },
    {
        x: new Date('2014-10-06'),
        open: 99.95,
        high: 102.38,
        low: 98.31,
        close: 100.73,
        volume: 279646740
    },
    {
        x: new Date('2014-10-13'),
        open: 101.33,
        high: 101.78,
        low: 95.18,
        close: 97.67,
        volume: 356408760
    },
    {
        x: new Date('2014-10-20'),
        open: 98.315,
        high: 105.49,
        low: 98.22,
        close: 105.22,
        volume: 355329760
    },
    {
        x: new Date('2014-10-27'),
        open: 104.85,
        high: 108.04,
        low: 104.7,
        close: 108,
        volume: 219443560
    },
    {
        x: new Date('2014-11-03'),
        open: 108.22,
        high: 110.3,
        low: 107.72,
        close: 109.01,
        volume: 199332700
    },
    {
        x: new Date('2014-11-10'),
        open: 109.02,
        high: 114.19,
        low: 108.4,
        close: 114.18,
        volume: 203976340
    },
    {
        x: new Date('2014-11-17'),
        open: 114.27,
        high: 117.57,
        low: 113.3,
        close: 116.47,
        volume: 232574480
    },
    {
        x: new Date('2014-11-24'),
        open: 116.85,
        high: 119.75,
        low: 116.62,
        close: 118.93,
        volume: 181158620
    },
    {
        x: new Date('2014-12-01'),
        open: 118.81,
        high: 119.25,
        low: 111.27,
        close: 115,
        volume: 266118290
    },
    {
        x: new Date('2014-12-08'),
        open: 114.1,
        high: 114.85,
        low: 109.35,
        close: 109.73,
        volume: 259311140
    },
    {
        x: new Date('2014-12-15'),
        open: 110.7,
        high: 113.24,
        low: 106.26,
        close: 111.78,
        volume: 326382400
    },
    {
        x: new Date('2014-12-22'),
        open: 112.16,
        high: 114.52,
        low: 111.97,
        close: 113.99,
        volume: 119248900
    },
    {
        x: new Date('2014-12-29'),
        open: 113.79,
        high: 114.77,
        low: 107.35,
        close: 109.33,
        volume: 151780640
    },
    {
        x: new Date('2015-01-05'),
        open: 108.29,
        high: 113.25,
        low: 104.63,
        close: 112.01,
        volume: 282690970
    },
    {
        x: new Date('2015-01-12'),
        open: 112.6,
        high: 112.8,
        low: 105.2,
        close: 105.99,
        volume: 303531140
    },
    {
        x: new Date('2015-01-19'),
        open: 107.84,
        high: 113.75,
        low: 106.5,
        close: 112.98,
        volume: 198362640
    },
    {
        x: new Date('2015-01-26'),
        open: 113.74,
        high: 120,
        low: 109.03,
        close: 117.16,
        volume: 461747290
    },
    {
        x: new Date('2015-02-02'),
        open: 118.05,
        high: 120.51,
        low: 116.08,
        close: 118.93,
        volume: 270190470
    },
    {
        x: new Date('2015-02-09'),
        open: 118.55,
        high: 127.48,
        low: 118.43,
        close: 127.08,
        volume: 301354470
    },
    {
        x: new Date('2015-02-16'),
        open: 127.49,
        high: 129.5,
        low: 126.92,
        close: 129.495,
        volume: 193883960
    },
    {
        x: new Date('2015-02-23'),
        open: 130.02,
        high: 133.6,
        low: 126.61,
        close: 128.46,
        volume: 369856960
    },
    {
        x: new Date('2015-03-02'),
        open: 129.25,
        high: 130.28,
        low: 125.76,
        close: 126.6,
        volume: 246472020
    },
    {
        x: new Date('2015-03-09'),
        open: 127.96,
        high: 129.57,
        low: 121.63,
        close: 123.59,
        volume: 325921230
    },
    {
        x: new Date('2015-03-16'),
        open: 123.88,
        high: 129.2451,
        low: 122.87,
        close: 125.9,
        volume: 266016400
    },
    {
        x: new Date('2015-03-23'),
        open: 127.12,
        high: 128.04,
        low: 122.6,
        close: 123.25,
        volume: 208731730
    },
    {
        x: new Date('2015-03-30'),
        open: 124.05,
        high: 126.49,
        low: 123.1,
        close: 125.32,
        volume: 161628950
    },
    {
        x: new Date('2015-04-06'),
        open: 124.47,
        high: 128.1218,
        low: 124.33,
        close: 127.1,
        volume: 181454510
    },
    {
        x: new Date('2015-04-13'),
        open: 128.37,
        high: 128.57,
        low: 124.46,
        close: 124.75,
        volume: 170090870
    },
    {
        x: new Date('2015-04-20'),
        open: 125.57,
        high: 130.63,
        low: 125.17,
        close: 130.28,
        volume: 206698310
    },
    {
        x: new Date('2015-04-27'),
        open: 132.31,
        high: 134.54,
        low: 124.58,
        close: 128.95,
        volume: 417115180
    },
    {
        x: new Date('2015-05-04'),
        open: 129.5,
        high: 130.57,
        low: 123.36,
        close: 127.62,
        volume: 270197900
    },
    {
        x: new Date('2015-05-11'),
        open: 127.39,
        high: 129.49,
        low: 124.82,
        close: 128.77,
        volume: 207858180
    },
    {
        x: new Date('2015-05-18'),
        open: 128.38,
        high: 132.97,
        low: 128.36,
        close: 132.54,
        volume: 216438970
    },
    {
        x: new Date('2015-05-25'),
        open: 132.6,
        high: 132.91,
        low: 129.12,
        close: 130.28,
        volume: 197468800
    },
    {
        x: new Date('2015-06-01'),
        open: 131.2,
        high: 131.39,
        low: 128.36,
        close: 128.65,
        volume: 170465550
    },
    {
        x: new Date('2015-06-08'),
        open: 128.9,
        high: 130.18,
        low: 125.62,
        close: 127.17,
        volume: 219812710
    },
    {
        x: new Date('2015-06-15'),
        open: 126.1,
        high: 128.31,
        low: 125.71,
        close: 126.6,
        volume: 197925030
    },
    {
        x: new Date('2015-06-22'),
        open: 127.49,
        high: 129.8,
        low: 126.51,
        close: 126.75,
        volume: 195104520
    },
    {
        x: new Date('2015-06-29'),
        open: 125.46,
        high: 126.94,
        low: 124.48,
        close: 126.44,
        volume: 150747530
    },
    {
        x: new Date('2015-07-06'),
        open: 124.94,
        high: 126.23,
        low: 119.22,
        close: 123.28,
        volume: 274904180
    },
    {
        x: new Date('2015-07-13'),
        open: 125.03,
        high: 129.62,
        low: 124.32,
        close: 129.62,
        volume: 188579340
    },
    {
        x: new Date('2015-07-20'),
        open: 130.97,
        high: 132.97,
        low: 121.99,
        close: 124.5,
        volume: 336423370
    },
    {
        x: new Date('2015-07-27'),
        open: 123.09,
        high: 123.91,
        low: 120.91,
        close: 121.3,
        volume: 191087840
    },
    {
        x: new Date('2015-08-03'),
        open: 121.5,
        high: 122.57,
        low: 112.1,
        close: 115.52,
        volume: 383883210
    },
    {
        x: new Date('2015-08-10'),
        open: 116.53,
        high: 119.99,
        low: 109.63,
        close: 115.96,
        volume: 344549090
    },
    {
        x: new Date('2015-08-17'),
        open: 116.04,
        high: 117.65,
        low: 105.645,
        close: 105.76,
        volume: 318855760
    },
    {
        x: new Date('2015-08-24'),
        open: 110.87,
        high: 113.31,
        low: 102.6,
        close: 113.29,
        volume: 498047270
    },
    {
        x: new Date('2015-08-31'),
        open: 112.03,
        high: 114.53,
        low: 107.36,
        close: 109.27,
        volume: 297402060
    },
    {
        x: new Date('2015-09-07'),
        open: 111.65,
        high: 114.21,
        low: 109.77,
        close: 114.21,
        volume: 251859600
    },
    {
        x: new Date('2015-09-14'),
        open: 116.58,
        high: 116.89,
        low: 111.87,
        close: 113.45,
        volume: 276281980
    },
    {
        x: new Date('2015-09-21'),
        open: 113.67,
        high: 116.69,
        low: 112.37,
        close: 114.71,
        volume: 238617740
    },
    {
        x: new Date('2015-09-28'),
        open: 113.85,
        high: 114.57,
        low: 107.31,
        close: 110.38,
        volume: 313017610
    },
    {
        x: new Date('2015-10-05'),
        open: 109.88,
        high: 112.28,
        low: 108.21,
        close: 112.12,
        volume: 261920950
    },
    {
        x: new Date('2015-10-12'),
        open: 112.73,
        high: 112.75,
        low: 109.56,
        close: 111.04,
        volume: 184208970
    },
    {
        x: new Date('2015-10-19'),
        open: 110.8,
        high: 119.228,
        low: 110.11,
        close: 119.08,
        volume: 221612230
    },
    {
        x: new Date('2015-10-26'),
        open: 118.08,
        high: 121.22,
        low: 113.99,
        close: 119.5,
        volume: 319660750
    },
    {
        x: new Date('2015-11-02'),
        open: 119.87,
        high: 123.82,
        low: 119.61,
        close: 121.06,
        volume: 194953700
    },
    {
        x: new Date('2015-11-09'),
        open: 120.96,
        high: 121.81,
        low: 112.27,
        close: 112.34,
        volume: 216054740
    },
    {
        x: new Date('2015-11-16'),
        open: 111.38,
        high: 119.92,
        low: 111,
        close: 119.3,
        volume: 189492500
    },
    {
        x: new Date('2015-11-23'),
        open: 119.27,
        high: 119.73,
        low: 117.12,
        close: 117.81,
        volume: 109582040
    },
    {
        x: new Date('2015-11-30'),
        open: 117.99,
        high: 119.41,
        low: 114.22,
        close: 119.03,
        volume: 205415620
    },
    {
        x: new Date('2015-12-07'),
        open: 118.98,
        high: 119.86,
        low: 112.851,
        close: 113.18,
        volume: 188609110
    },
    {
        x: new Date('2015-12-14'),
        open: 112.18,
        high: 112.8,
        low: 105.81,
        close: 106.03,
        volume: 314856190
    },
    {
        x: new Date('2015-12-21'),
        open: 107.28,
        high: 109,
        low: 105.57,
        close: 108.03,
        volume: 126450510
    },
    {
        x: new Date('2015-12-28'),
        open: 107.59,
        high: 109.43,
        low: 104.82,
        close: 105.26,
        volume: 123621760
    },
    {
        x: new Date('2016-01-04'),
        open: 102.61,
        high: 105.85,
        low: 96.43,
        close: 96.96,
        volume: 343000960
    },
    {
        x: new Date('2016-01-11'),
        open: 98.97,
        high: 101.19,
        low: 95.36,
        close: 97.13,
        volume: 303375940
    },
    {
        x: new Date('2016-01-18'),
        open: 98.41,
        high: 101.46,
        low: 93.42,
        close: 101.42,
        volume: 242982970
    },
    {
        x: new Date('2016-01-25'),
        open: 101.52,
        high: 101.53,
        low: 92.39,
        close: 97.34,
        volume: 376481100
    },
    {
        x: new Date('2016-02-01'),
        open: 96.47,
        high: 97.33,
        low: 93.69,
        close: 94.02,
        volume: 216608840
    },
    {
        x: new Date('2016-02-08'),
        open: 93.13,
        high: 96.35,
        low: 92.59,
        close: 93.99,
        volume: 230794620
    },
    {
        x: new Date('2016-02-15'),
        open: 95.02,
        high: 98.89,
        low: 94.61,
        close: 96.04,
        volume: 167001070
    },
    {
        x: new Date('2016-02-22'),
        open: 96.31,
        high: 98.0237,
        low: 93.32,
        close: 96.91,
        volume: 158759600
    },
    {
        x: new Date('2016-02-29'),
        open: 96.86,
        high: 103.75,
        low: 96.65,
        close: 103.01,
        volume: 201482180
    },
    {
        x: new Date('2016-03-07'),
        open: 102.39,
        high: 102.83,
        low: 100.15,
        close: 102.26,
        volume: 155437450
    },
    {
        x: new Date('2016-03-14'),
        open: 101.91,
        high: 106.5,
        low: 101.78,
        close: 105.92,
        volume: 181323210
    },
    {
        x: new Date('2016-03-21'),
        open: 105.93,
        high: 107.65,
        low: 104.89,
        close: 105.67,
        volume: 119054360
    },
    {
        x: new Date('2016-03-28'),
        open: 106,
        high: 110.42,
        low: 104.88,
        close: 109.99,
        volume: 147641240
    },
    {
        x: new Date('2016-04-04'),
        open: 110.42,
        high: 112.19,
        low: 108.121,
        close: 108.66,
        volume: 145351790
    },
    {
        x: new Date('2016-04-11'),
        open: 108.97,
        high: 112.39,
        low: 108.66,
        close: 109.85,
        volume: 161518860
    },
    {
        x: new Date('2016-04-18'),
        open: 108.89,
        high: 108.95,
        low: 104.62,
        close: 105.68,
        volume: 188775240
    },
    {
        x: new Date('2016-04-25'),
        open: 105,
        high: 105.65,
        low: 92.51,
        close: 93.74,
        volume: 345910030
    },
    {
        x: new Date('2016-05-02'),
        open: 93.965,
        high: 95.9,
        low: 91.85,
        close: 92.72,
        volume: 225114110
    },
    {
        x: new Date('2016-05-09'),
        open: 93,
        high: 93.77,
        low: 89.47,
        close: 90.52,
        volume: 215596350
    },
    {
        x: new Date('2016-05-16'),
        open: 92.39,
        high: 95.43,
        low: 91.65,
        close: 95.22,
        volume: 212312980
    },
    {
        x: new Date('2016-05-23'),
        open: 95.87,
        high: 100.73,
        low: 95.67,
        close: 100.35,
        volume: 203902650
    },
    {
        x: new Date('2016-05-30'),
        open: 99.6,
        high: 100.4,
        low: 96.63,
        close: 97.92,
        volume: 140064910
    },
    {
        x: new Date('2016-06-06'),
        open: 97.99,
        high: 101.89,
        low: 97.55,
        close: 98.83,
        volume: 124731320
    },
    {
        x: new Date('2016-06-13'),
        open: 98.69,
        high: 99.12,
        low: 95.3,
        close: 95.33,
        volume: 191017280
    },
    {
        x: new Date('2016-06-20'),
        open: 96,
        high: 96.89,
        low: 92.65,
        close: 93.4,
        volume: 206149160
    },
    {
        x: new Date('2016-06-27'),
        open: 93,
        high: 96.465,
        low: 91.5,
        close: 95.89,
        volume: 184254460
    },
    {
        x: new Date('2016-07-04'),
        open: 95.39,
        high: 96.89,
        low: 94.37,
        close: 96.68,
        volume: 111769640
    },
    {
        x: new Date('2016-07-11'),
        open: 96.75,
        high: 99.3,
        low: 96.73,
        close: 98.78,
        volume: 142244590
    },
    {
        x: new Date('2016-07-18'),
        open: 98.7,
        high: 101,
        low: 98.31,
        close: 98.66,
        volume: 147358320
    },
    {
        x: new Date('2016-07-25'),
        open: 98.25,
        high: 104.55,
        low: 96.42,
        close: 104.21,
        volume: 252358930
    },
    {
        x: new Date('2016-08-01'),
        open: 104.41,
        high: 107.65,
        low: 104,
        close: 107.48,
        volume: 168265830
    },
    {
        x: new Date('2016-08-08'),
        open: 107.52,
        high: 108.94,
        low: 107.16,
        close: 108.18,
        volume: 124255340
    },
    {
        x: new Date('2016-08-15'),
        open: 108.14,
        high: 110.23,
        low: 108.08,
        close: 109.36,
        volume: 131814920
    },
    {
        x: new Date('2016-08-22'),
        open: 108.86,
        high: 109.32,
        low: 106.31,
        close: 106.94,
        volume: 123373540
    },
    {
        x: new Date('2016-08-29'),
        open: 106.62,
        high: 108,
        low: 105.5,
        close: 107.73,
        volume: 134426100
    },
    {
        x: new Date('2016-09-05'),
        open: 107.9,
        high: 108.76,
        low: 103.13,
        close: 103.13,
        volume: 168312530
    },
    {
        x: new Date('2016-09-12'),
        open: 102.65,
        high: 116.13,
        low: 102.53,
        close: 114.92,
        volume: 388543710
    },
    {
        x: new Date('2016-09-19'),
        open: 115.19,
        high: 116.18,
        low: 111.55,
        close: 112.71,
        volume: 200842480
    },
    {
        x: new Date('2016-09-26'),
        open: 111.64,
        high: 114.64,
        low: 111.55,
        close: 113.05,
        volume: 156186800
    },
    {
        x: new Date('2016-10-03'),
        open: 112.71,
        high: 114.56,
        low: 112.28,
        close: 114.06,
        volume: 125587350
    },
    {
        x: new Date('2016-10-10'),
        open: 115.02,
        high: 118.69,
        low: 114.72,
        close: 117.63,
        volume: 208231690
    },
    {
        x: new Date('2016-10-17'),
        open: 117.33,
        high: 118.21,
        low: 113.8,
        close: 116.6,
        volume: 114497020
    },
    {
        x: new Date('2016-10-24'),
        open: 117.1,
        high: 118.36,
        low: 113.31,
        close: 113.72,
        volume: 204530120
    },
    {
        x: new Date('2016-10-31'),
        open: 113.65,
        high: 114.23,
        low: 108.11,
        close: 108.84,
        volume: 155287280
    },
    {
        x: new Date('2016-11-07'),
        open: 110.08,
        high: 111.72,
        low: 105.83,
        close: 108.43,
        volume: 206825070
    },
    {
        x: new Date('2016-11-14'),
        open: 107.71,
        high: 110.54,
        low: 104.08,
        close: 110.06,
        volume: 197790040
    },
    {
        x: new Date('2016-11-21'),
        open: 110.12,
        high: 112.42,
        low: 110.01,
        close: 111.79,
        volume: 93992370
    },
    {
        x: new Date('2016-11-28'),
        open: 111.43,
        high: 112.465,
        low: 108.85,
        close: 109.9,
        volume: 155229390
    },
    {
        x: new Date('2016-12-05'),
        open: 110,
        high: 114.7,
        low: 108.25,
        close: 113.95,
        volume: 151624650
    },
    {
        x: new Date('2016-12-12'),
        open: 113.29,
        high: 116.73,
        low: 112.49,
        close: 115.97,
        volume: 194003220
    },
    {
        x: new Date('2016-12-19'),
        open: 115.8,
        high: 117.5,
        low: 115.59,
        close: 116.52,
        volume: 113106370
    },
    {
        x: new Date('2016-12-26'),
        open: 116.52,
        high: 118.0166,
        low: 115.43,
        close: 115.82,
        volume: 84354060
    },
    {
        x: new Date('2017-01-02'),
        open: 115.8,
        high: 118.16,
        low: 114.76,
        close: 117.91,
        volume: 103680760
    },
    {
        x: new Date('2017-01-09'),
        open: 117.95,
        high: 119.93,
        low: 117.94,
        close: 119.04,
        volume: 138446660
    },
    {
        x: new Date('2017-01-16'),
        open: 118.34,
        high: 120.5,
        low: 118.22,
        close: 120,
        volume: 113576380
    },
    {
        x: new Date('2017-01-23'),
        open: 120,
        high: 122.44,
        low: 119.5,
        close: 121.95,
        volume: 124406640
    },
    {
        x: new Date('2017-01-30'),
        open: 120.93,
        high: 130.49,
        low: 120.62,
        close: 129.08,
        volume: 248063580
    },
    {
        x: new Date('2017-02-06'),
        open: 129.13,
        high: 132.94,
        low: 128.9,
        close: 132.12,
        volume: 136252280
    },
    {
        x: new Date('2017-02-13'),
        open: 133.08,
        high: 136.27,
        low: 132.75,
        close: 135.72,
        volume: 136326260
    },
    {
        x: new Date('2017-02-20'),
        open: 136.23,
        high: 137.48,
        low: 135.28,
        close: 136.66,
        volume: 87773190
    },
    {
        x: new Date('2017-02-27'),
        open: 137.14,
        high: 140.2786,
        low: 136.28,
        close: 139.78,
        volume: 127757050
    },
    {
        x: new Date('2017-03-06'),
        open: 139.365,
        high: 139.98,
        low: 137.05,
        close: 139.14,
        volume: 99061270
    },
    {
        x: new Date('2017-03-13'),
        open: 138.85,
        high: 141.02,
        low: 138.82,
        close: 139.99,
        volume: 120881720
    },
    {
        x: new Date('2017-03-20'),
        open: 140.4,
        high: 142.8,
        low: 139.73,
        close: 140.64,
        volume: 129178500
    },
    {
        x: new Date('2017-03-27'),
        open: 139.39,
        high: 144.5,
        low: 138.62,
        close: 143.66,
        volume: 126819590
    },
    {
        x: new Date('2017-04-03'),
        open: 143.71,
        high: 145.46,
        low: 143.05,
        close: 143.34,
        volume: 105274540
    },
    {
        x: new Date('2017-04-10'),
        open: 143.6,
        high: 143.8792,
        low: 140.06,
        close: 141.05,
        volume: 87342130
    },
    {
        x: new Date('2017-04-17'),
        open: 141.48,
        high: 142.92,
        low: 140.45,
        close: 142.27,
        volume: 89092650
    },
    {
        x: new Date('2017-04-24'),
        open: 143.5,
        high: 144.9,
        low: 143.18,
        close: 143.65,
        volume: 90423600
    },
    {
        x: new Date('2017-05-01'),
        open: 145.1,
        high: 148.98,
        low: 144.27,
        close: 148.96,
        volume: 173861760
    },
    {
        x: new Date('2017-05-08'),
        open: 149.03,
        high: 156.42,
        low: 149.03,
        close: 156.1,
        volume: 173087500
    },
    {
        x: new Date('2017-05-15'),
        open: 156.01,
        high: 156.65,
        low: 149.71,
        close: 153.06,
        volume: 156993820
    },
    {
        x: new Date('2017-05-22'),
        open: 154,
        high: 154.9,
        low: 152.67,
        close: 153.61,
        volume: 103151450
    },
    {
        x: new Date('2017-05-29'),
        open: 153.42,
        high: 155.45,
        low: 152.22,
        close: 155.45,
        volume: 88670120
    },
    {
        x: new Date('2017-06-05'),
        open: 154.34,
        high: 155.98,
        low: 146.02,
        close: 148.98,
        volume: 158814040
    },
    {
        x: new Date('2017-06-12'),
        open: 145.74,
        high: 147.5,
        low: 142.2,
        close: 142.27,
        volume: 219638930
    },
    {
        x: new Date('2017-06-19'),
        open: 143.66,
        high: 147.16,
        low: 143.66,
        close: 146.28,
        volume: 132832660
    },
    {
        x: new Date('2017-06-26'),
        open: 147.17,
        high: 148.28,
        low: 142.28,
        close: 144.02,
        volume: 126890110
    },
    {
        x: new Date('2017-07-03'),
        open: 144.88,
        high: 145.3001,
        low: 142.41,
        close: 144.18,
        volume: 78465450
    },
    {
        x: new Date('2017-07-10'),
        open: 144.11,
        high: 149.33,
        low: 143.37,
        close: 149.04,
        volume: 109759170
    },
    {
        x: new Date('2017-07-17'),
        open: 148.82,
        high: 151.74,
        low: 148.57,
        close: 150.27,
        volume: 104744470
    },
    {
        x: new Date('2017-07-24'),
        open: 150.58,
        high: 153.99,
        low: 147.3,
        close: 149.5,
        volume: 105536280
    },
    {
        x: new Date('2017-07-31'),
        open: 149.9,
        high: 159.75,
        low: 148.13,
        close: 156.39,
        volume: 170204830
    },
    {
        x: new Date('2017-08-07'),
        open: 157.06,
        high: 161.83,
        low: 154.63,
        close: 157.48,
        volume: 149860480
    },
    {
        x: new Date('2017-08-14'),
        open: 159.32,
        high: 162.51,
        low: 156.72,
        close: 157.5,
        volume: 133829670
    },
    {
        x: new Date('2017-08-21'),
        open: 157.5,
        high: 160.74,
        low: 155.1101,
        close: 159.86,
        volume: 112238670
    },
    {
        x: new Date('2017-08-28'),
        open: 160.14,
        high: 164.94,
        low: 159.93,
        close: 164.05,
        volume: 125610990
    },
    {
        x: new Date('2017-09-04'),
        open: 163.75,
        high: 164.25,
        low: 158.53,
        close: 158.63,
        volume: 101419110
    },
    {
        x: new Date('2017-09-11'),
        open: 160.5,
        high: 163.96,
        low: 157.91,
        close: 159.88,
        volume: 220431100
    },
    {
        x: new Date('2017-09-18'),
        open: 160.11,
        high: 160.5,
        low: 157.995,
        close: 158.67,
        volume: 27939544
    }
];
var axesData = [
    { xDate: new Date('2013-01-29'), Open: 85.97, High: 86.37, Low: 85.96, Close: 86.33 },
    { xDate: new Date('2013-02-01'), Open: 86.1, High: 86.15, Low: 85.9, Close: 86.03 },
    { xDate: new Date('2013-03-03'), Open: 85.93, High: 86.17, Low: 85.84, Close: 86.02 },
    { xDate: new Date('2013-04-05'), Open: 85.74, High: 86, Low: 85.66, Close: 86 },
    { xDate: new Date('2013-05-07'), Open: 85.71, High: 85.71, Low: 85.36, Close: 85.62 },
    { xDate: new Date('2013-06-09'), Open: 85.3, High: 85.92, Low: 85.16, Close: 85.8 },
    { xDate: new Date('2013-07-11'), Open: 84.23, High: 85.46, Low: 84.23, Close: 85.2 },
    { xDate: new Date('2013-08-13'), Open: 84.51, High: 84.54, Low: 84.19, Close: 84.3 },
    { xDate: new Date('2013-09-15'), Open: 84.44, High: 84.65, Low: 84.2, Close: 84.63 },
    { xDate: new Date('2013-10-17'), Open: 84.6, High: 84.81, Low: 84.59, Close: 84.65 },
    { xDate: new Date('2013-11-19'), Open: 84.52, High: 84.86, Low: 84.4, Close: 84.76 },
    { xDate: new Date('2013-12-27'), Open: 85.97, High: 86.37, Low: 85.96, Close: 86.33 },
    { xDate: new Date('2014-01-23'), Open: 84.22, High: 84.3, Low: 83.98, Close: 84.26 },
    { xDate: new Date('2014-02-25'), Open: 83.75, High: 84.1, Low: 83.65, Close: 84 },
    { xDate: new Date('2014-03-27'), Open: 84, High: 84.01, Low: 83.67, Close: 83.74 },
    { xDate: new Date('2014-04-29'), Open: 84, High: 84.01, Low: 83.67, Close: 83.74 },
    { xDate: new Date('2014-05-01'), Open: 84.3, High: 84.45, Low: 84.19, Close: 84.22 },
    { xDate: new Date('2014-06-03'), Open: 83.79, High: 84.19, Low: 83.7, Close: 84.04 },
    { xDate: new Date('2014-07-05'), Open: 84.02, High: 84.02, Low: 83.69, Close: 83.71 },
    { xDate: new Date('2014-08-07'), Open: 84.01, High: 84.04, Low: 83.82, Close: 83.96 },
    { xDate: new Date('2014-09-09'), Open: 83.9, High: 84.02, Low: 83.86, Close: 83.94 },
    { xDate: new Date('2014-10-11'), Open: 84.09, High: 84.17, Low: 83.9, Close: 84.06 },
    { xDate: new Date('2014-11-13'), Open: 83.89, High: 84.25, Low: 83.77, Close: 84.01 },
    { xDate: new Date('2014-12-21'), Open: 84.17, High: 84.66, Low: 84.16, Close: 84.47 },
    { xDate: new Date('2015-01-17'), Open: 84.49, High: 84.65, Low: 84.18, Close: 84.22 },
    { xDate: new Date('2015-02-19'), Open: 84.99, High: 85.1, Low: 84.37, Close: 84.43 },
    { xDate: new Date('2015-03-21'), Open: 84.96, High: 85.06, Low: 84.7, Close: 85.01 },
    { xDate: new Date('2015-04-23'), Open: 84.68, High: 84.9, Low: 84.65, Close: 84.76 },
    { xDate: new Date('2015-05-25'), Open: 84.35, High: 85.03, Low: 84.32, Close: 84.67 },
    { xDate: new Date('2015-06-27'), Open: 84.19, High: 84.31, Low: 84.16, Close: 84.19 },
    { xDate: new Date('2015-07-29'), Open: 84.19, High: 84.31, Low: 84.16, Close: 84.19 },
    { xDate: new Date('2015-08-01'), Open: 84.2, High: 84.29, Low: 84.04, Close: 84.15 },
    { xDate: new Date('2015-09-03'), Open: 84.21, High: 84.25, Low: 84.03, Close: 84.17 },
    { xDate: new Date('2015-10-05'), Open: 84.72, High: 84.87, Low: 84.44, Close: 84.49 },
    { xDate: new Date('2015-11-07'), Open: 84.85, High: 84.88, Low: 84.5, Close: 84.72 },
    { xDate: new Date('2015-12-15'), Open: 84.05, High: 84.14, Low: 83.84, Close: 83.91 },
    { xDate: new Date('2016-01-11'), Open: 84.4, High: 84.7, Low: 84.27, Close: 84.52 },
    { xDate: new Date('2016-02-13'), Open: 84.96, High: 85.07, Low: 84.5, Close: 84.57 },
    { xDate: new Date('2016-02-15'), Open: 85.28, High: 85.32, Low: 84.95, Close: 85.03 },
    { xDate: new Date('2016-03-17'), Open: 85.35, High: 85.39, Low: 85.1, Close: 85.32 },
    { xDate: new Date('2016-04-19'), Open: 85.65, High: 85.66, Low: 85.21, Close: 85.36 },
    { xDate: new Date('2016-05-21'), Open: 85.38, High: 85.85, Low: 85.25, Close: 85.67 },
    { xDate: new Date('2016-06-23'), Open: 85.8, High: 85.96, Low: 85.67, Close: 85.83 },
    { xDate: new Date('2016-07-25'), Open: 86.07, High: 86.22, Low: 85.75, Close: 85.87 },
    { xDate: new Date('2016-08-27'), Open: 86.05, High: 86.08, Low: 85.68, Close: 85.79 },
    { xDate: new Date('2016-09-29'), Open: 86.05, High: 86.08, Low: 85.68, Close: 85.79 },
    { xDate: new Date('2016-10-01'), Open: 85.85, High: 86.25, Low: 85.79, Close: 86.06 },
    { xDate: new Date('2016-11-03'), Open: 85.6, High: 85.85, Low: 85.49, Close: 85.81 },
    { xDate: new Date('2016-12-09'), Open: 84.53, High: 84.74, Low: 84.25, Close: 84.69 },
    { xDate: new Date('2017-01-07'), Open: 86.55, High: 86.64, Low: 85.36, Close: 85.92 },
    { xDate: new Date('2017-02-09'), Open: 86.46, High: 86.87, Low: 86.4, Close: 86.71 },
    { xDate: new Date('2017-03-11'), Open: 86.3, High: 86.39, Low: 86.13, Close: 86.38 },
    { xDate: new Date('2017-04-13'), Open: 85.74, High: 86.44, Low: 85.67, Close: 86.19 },
    { xDate: new Date('2017-05-15'), Open: 85.56, High: 85.62, Low: 85.34, Close: 85.61 },
    { xDate: new Date('2017-06-17'), Open: 85.79, High: 85.89, Low: 85.36, Close: 85.52 },
    { xDate: new Date('2017-07-19'), Open: 85.54, High: 86, Low: 85.51, Close: 85.76 },
    { xDate: new Date('2017-08-21'), Open: 85, High: 85.17, Low: 84.87, Close: 85.15 },
    { xDate: new Date('2017-09-23'), Open: 85.1, High: 85.28, Low: 84.72, Close: 85.08 },
    { xDate: new Date('2017-10-25'), Open: 85.46, High: 85.56, Low: 85.18, Close: 85.37 },
    { xDate: new Date('2017-11-27'), Open: 85.42, High: 85.44, Low: 85.09, Close: 85.42 },
    { xDate: new Date('2017-12-05'), Open: 85.94, High: 86, Low: 85.48, Close: 85.66 }
];
var rainFallData = [
    6.279319488350383, 6.44063341316797, 6.2369215935932125, 5.502712120699334, 8.36727387645628,
    6.8763936909119145, 7.539107641248687, 7.168106790298325, 5.088973211088473, 7.3611443626521975,
    6.262482500009694, 7.066946128264099, 7.919136663279815, 6.048770230229623, 6.635693738128687,
    6.914314060997675, 7.3558393638632245, 7.446799394011705, 6.573065012367965, 7.199248800046284,
    7.2478392502172255, 5.841749916549048, 6.2875032915742555, 7.780344597533645, 7.476252964940152,
    7.31130789349302, 6.9795490749342735, 5.25771395445122, 5.209178065323029, 7.253001207479784,
    7.735630771065614, 7.867579691619466, 6.498505124379967, 7.520182796274494, 6.8849552121955355,
    8.409548532300903, 7.280962677695648, 5.90472258083289, 5.493050947663577, 8.049930030095826,
    7.312239096474201, 6.648881892334176, 8.20778156490454, 7.760450642162979, 7.16896788902378,
    6.464002823190773, 6.744274412468741, 7.608063016119123, 8.28437415597541, 6.0686292110951,
    6.903464462707268, 6.21583898264024, 6.593313193313992, 8.173631463364867, 6.2071625059658535,
    6.418795393716696, 6.564866596674945, 7.762970761208759, 6.69332473846462, 6.1351463701281865,
    7.022493415476658, 5.6249468419041895, 7.874458629000931, 5.990122152134347, 6.813180297026457,
    6.193695064120531, 5.296018389402549, 5.17260081829393, 8.408367813193978, 5.021357760833318,
    5.459118447495531, 8.323738731410392, 5.260751854138992, 7.7013503613788545, 7.161869425083509,
    6.4418768926289145, 5.7231475724513015, 5.364349621131238, 6.773111815759874, 8.306374671332607,
    6.165757722561587, 8.011545688002819, 5.701686949133615, 5.811580507651204, 7.948649630117358,
    8.048489436166571, 6.786435040503838, 7.1266629301054945, 7.091275551544603, 8.413378363384973,
    7.589335230735911, 5.5681611987571165, 5.176557932530318, 6.890754293090578, 7.924184435766012,
    7.671728565183779, 6.534081554237517, 6.078696508169291, 6.722649936820086, 8.13565939847763,
    5.322671901142255, 5.876995219513782, 6.5405777428501555, 8.127136324134698, 6.843787638022269,
    8.214383813349539, 7.091099148563872, 5.573444163129094, 6.1157593307379905, 5.363258884106331,
    6.637800048423518, 5.027116944840255, 6.431401722513312, 7.926967677322131, 7.065957313808207,
    8.301185233917279, 6.143757399153787, 6.607680399250383, 7.938494833444157, 6.365288215185968,
    6.184127061001217, 6.260665337126789, 6.372079016740581, 5.376093226995872, 8.299463466935178,
    5.269678124030882, 6.976824154487483, 6.5820865112357545, 6.724430571963181, 8.26091246496553,
    7.401497200117249, 7.386153557663212, 7.963447373445464, 5.337687146800787, 8.286285086593121,
    8.222978426452293, 7.846639766826911, 8.069351366527062, 7.513260268839259, 6.296995869336903,
    8.3590956573818, 7.34430352413543, 5.527911754495014, 7.770708367719198, 8.266752140439358,
    5.2647621706579635, 6.101003552437883, 5.589774929752683, 7.839799629506524, 7.41897730190976
];

var sl = [
        { x: 1, y: 2 },
        { x: 2, y: 3, isWicket: true },
        { x: 3, y: 1 },
        { x: 4, y: 7 },
        { x: 5, y: 5 },
        { x: 6, y: 24 },
        { x: 7, y: 13 },
        { x: 8, y: 4 },
        { x: 9, y: 6 },
        { x: 10, y: 4 },
        { x: 11, y: 7 },
        { x: 12, y: 5 },
        { x: 13, y: 5 },
        { x: 14, y: 10 },
        { x: 15, y: 5 },
        { x: 16, y: 5 },
        { x: 17, y: 13 },
        { x: 18, y: 4 },
        { x: 19, y: 8 },
        { x: 20, y: 2 },
        { x: 21, y: 2 },
        { x: 22, y: 2, isWicket: true },
        { x: 23, y: 5 },
        { x: 24, y: 7 },
        { x: 25, y: 1 },
        { x: 26, y: 4 },
        { x: 27, y: 5 },
        { x: 28, y: 5 },
        { x: 29, y: 5 },
        { x: 30, y: 17 },
        { x: 31, y: 42, isWicket: true },
        { x: 32, y: 7 },
        { x: 33, y: 5 },
        { x: 34, y: 2, isWicket: true },
        { x: 35, y: 6 },
        { x: 36, y: 16 },
        { x: 37, y: 19 },
        { x: 38, y: 6 },
        { x: 39, y: 12 },
        { x: 40, y: 11 },
        { x: 41, y: 8 },
        { x: 42, y: 12, isWicket: true },
        { x: 43, y: 4, isWicket: true },
        { x: 44, y: 8 },
        { x: 45, y: 2, isWicket: true },
        { x: 46, y: 2, isWicket: true }
];
var aus = [
    { x: 1, y: 4 },
    { x: 2, y: 4 },
    { x: 3, y: 5 },
    { x: 4, y: 6 },
    { x: 5, y: 5, isWicket: true },
    { x: 6, y: 8 },
    { x: 7, y: 2 },
    { x: 8, y: 3 },
    { x: 9, y: 4, isWicket: true },
    { x: 10, y: 8 },
    { x: 11, y: 3 },
    { x: 12, y: 4 },
    { x: 13, y: 7 },
    { x: 14, y: 2 },
    { x: 15, y: 7 },
    { x: 16, y: 4 },
    { x: 17, y: 3 },
    { x: 18, y: 3 },
    { x: 19, y: 3 },
    { x: 20, y: 1 },
    { x: 21, y: 7 },
    { x: 22, y: 2 },
    { x: 23, y: 5 },
    { x: 24, y: 7 },
    { x: 25, y: 7 },
    { x: 26, y: 7 },
    { x: 27, y: 5 },
    { x: 28, y: 9 },
    { x: 29, y: 14 },
    { x: 30, y: 10 },
    { x: 31, y: 10 },
    { x: 32, y: 7, isWicket: true },
    { x: 33, y: 2, isWicket: true },
    { x: 34, y: 7 },
    { x: 35, y: 14 },
    { x: 36, y: 3 },
    { x: 37, y: 17 },
    { x: 38, y: 16 },
    { x: 39, y: 10 },
    { x: 40, y: 8 },
    { x: 41, y: 17 },
    { x: 42, y: 10 },
    { x: 43, y: 20 },
    { x: 44, y: 15 },
    { x: 45, y: 6 },
    { x: 46, y: 16 },
    { x: 47, y: 8, isWicket: true },
    { x: 48, y: 4, isWicket: true },
    { x: 49, y: 19, isWicket: true },
    { x: 50, y: 8, isWicket: true }
];
var chartData1 = [
      {
          x: new Date('2012-04-02'),
          open: 85.9757,
          high: 90.6657,
          low: 85.7685,
          close: 90.5257,
          volume: 660187068
      },
        {
            x: new Date('2012-04-09'),
            open: 89.4471,
            high: 92,
            low: 86.2157,
            close: 86.4614,
            volume: 912634864
        },
        {
            x: new Date('2012-04-16'),
            open: 87.1514,
            high: 88.6071,
            low: 81.4885,
            close: 81.8543,
            volume: 1221746066
        },
        {
            x: new Date('2012-04-23'),
            open: 81.5157,
            high: 88.2857,
            low: 79.2857,
            close: 86.1428,
            volume: 965935749
        },
        {
            x: new Date('2012-04-30'),
            open: 85.4,
            high: 85.4857,
            low: 80.7385,
            close: 80.75,
            volume: 615249365
        },
        {
            x: new Date('2012-05-07'),
            open: 80.2143,
            high: 82.2685,
            low: 79.8185,
            close: 80.9585,
            volume: 541742692
        },
        {
            x: new Date('2012-05-14'),
            open: 80.3671,
            high: 81.0728,
            low: 74.5971,
            close: 75.7685,
            volume: 708126233
        },
        {
            x: new Date('2012-05-21'),
            open: 76.3571,
            high: 82.3571,
            low: 76.2928,
            close: 80.3271,
            volume: 682076215
        },
        {
            x: new Date('2012-05-28'),
            open: 81.5571,
            high: 83.0714,
            low: 80.0743,
            close: 80.1414,
            volume: 480059584
        },
        {
            x: new Date('2012-06-04'),
            open: 80.2143,
            high: 82.9405,
            low: 78.3571,
            close: 82.9028,
            volume: 517577005
        },
        {
            x: new Date('2012-06-11'),
            open: 83.96,
            high: 84.0714,
            low: 80.9571,
            close: 82.0185,
            volume: 499693120
        },
        {
            x: new Date('2012-06-18'),
            open: 81.5657,
            high: 84.2857,
            low: 81.4814,
            close: 83.1571,
            volume: 442172142
        },
        {
            x: new Date('2012-06-25'),
            open: 82.4714,
            high: 83.4285,
            low: 80.8014,
            close: 83.4285,
            volume: 371529102
        },
        {
            x: new Date('2012-07-02'),
            open: 83.5328,
            high: 87.7628,
            low: 83.3714,
            close: 86.5543,
            volume: 385906790
        },
        {
            x: new Date('2012-07-09'),
            open: 86.4714,
            high: 88.5528,
            low: 84.6685,
            close: 86.4243,
            volume: 524235196
        },
        {
            x: new Date('2012-07-16'),
            open: 86.4457,
            high: 87.9071,
            low: 86.1643,
            close: 86.3285,
            volume: 419537217
        },
        {
            x: new Date('2012-07-23'),
            open: 84.9143,
            high: 87.0971,
            low: 81.4285,
            close: 83.5943,
            volume: 680773023
        },
        {
            x: new Date('2012-07-30'),
            open: 84.4171,
            high: 88.2828,
            low: 83.9743,
            close: 87.9571,
            volume: 475109323
        },
        {
            x: new Date('2012-08-06'),
            open: 88.1843,
            high: 89.2857,
            low: 87.8943,
            close: 88.8143,
            volume: 312826308
        },
        {
            x: new Date('2012-08-13'),
            open: 89.0557,
            high: 92.5985,
            low: 89.0357,
            close: 92.5871,
            volume: 392867193
        },
        {
            x: new Date('2012-08-20'),
            open: 92.8585,
            high: 96.4114,
            low: 92.5871,
            close: 94.746,
            volume: 708614692
        },
        {
            x: new Date('2012-08-27'),
            open: 97.1414,
            high: 97.2671,
            low: 93.8928,
            close: 95.0343,
            volume: 383807217
        },
        {
            x: new Date('2012-09-03'),
            open: 95.1085,
            high: 97.4971,
            low: 94.9285,
            close: 97.2057,
            volume: 355722047
        },
        {
            x: new Date('2012-09-10'),
            open: 97.2071,
            high: 99.5685,
            low: 93.7143,
            close: 98.7543,
            volume: 724042207
        },
        {
            x: new Date('2012-09-17'),
            open: 99.9071,
            high: 100.7243,
            low: 99.0885,
            close: 100.0135,
            volume: 500166040
        },
        {
            x: new Date('2012-09-24'),
            open: 98.1228,
            high: 99.3028,
            low: 94.3357,
            close: 95.3007,
            volume: 714507994
        },
        {
            x: new Date('2012-10-01'),
            open: 95.88,
            high: 96.6785,
            low: 92.95,
            close: 93.2271,
            volume: 638543622
        },
        {
            x: new Date('2012-10-08'),
            open: 92.4114,
            high: 92.5085,
            low: 89.0785,
            close: 89.9591,
            volume: 747127724
        },
        {
            x: new Date('2012-10-15'),
            open: 90.3357,
            high: 93.2557,
            low: 87.0885,
            close: 87.12,
            volume: 646996264
        },
        {
            x: new Date('2012-10-22'),
            open: 87.4885,
            high: 90.7685,
            low: 84.4285,
            close: 86.2857,
            volume: 866040680
        },
        {
            x: new Date('2012-10-29'),
            open: 84.9828,
            high: 86.1428,
            low: 82.1071,
            close: 82.4,
            volume: 367371310
        },
        {
            x: new Date('2012-11-05'),
            open: 83.3593,
            high: 84.3914,
            low: 76.2457,
            close: 78.1514,
            volume: 919719846
        },
        {
            x: new Date('2012-11-12'),
            open: 79.1643,
            high: 79.2143,
            low: 72.25,
            close: 75.3825,
            volume: 894382149
        },
        {
            x: new Date('2012-11-19'),
            open: 77.2443,
            high: 81.7143,
            low: 77.1257,
            close: 81.6428,
            volume: 527416747
        },
        {
            x: new Date('2012-11-26'),
            open: 82.2714,
            high: 84.8928,
            low: 81.7514,
            close: 83.6114,
            volume: 646467974
        },
        {
            x: new Date('2012-12-03'),
            open: 84.8071,
            high: 84.9414,
            low: 74.09,
            close: 76.1785,
            volume: 980096264
        },
        {
            x: new Date('2012-12-10'),
            open: 75,
            high: 78.5085,
            low: 72.2257,
            close: 72.8277,
            volume: 835016110
        },
        {
            x: new Date('2012-12-17'),
            open: 72.7043,
            high: 76.4143,
            low: 71.6043,
            close: 74.19,
            volume: 726150329
        },
        {
            x: new Date('2012-12-24'),
            open: 74.3357,
            high: 74.8928,
            low: 72.0943,
            close: 72.7984,
            volume: 321104733
        },
        {
            x: new Date('2012-12-31'),
            open: 72.9328,
            high: 79.2857,
            low: 72.7143,
            close: 75.2857,
            volume: 540854882
        },
        {
            x: new Date('2013-01-07'),
            open: 74.5714,
            high: 75.9843,
            low: 73.6,
            close: 74.3285,
            volume: 574594262
        },
        {
            x: new Date('2013-01-14'),
            open: 71.8114,
            high: 72.9643,
            low: 69.0543,
            close: 71.4285,
            volume: 803105621
        },
        {
            x: new Date('2013-01-21'),
            open: 72.08,
            high: 73.57,
            low: 62.1428,
            close: 62.84,
            volume: 971912560
        },
        {
            x: new Date('2013-01-28'),
            open: 62.5464,
            high: 66.0857,
            low: 62.2657,
            close: 64.8028,
            volume: 656549587
        },
        {
            x: new Date('2013-02-04'),
            open: 64.8443,
            high: 68.4014,
            low: 63.1428,
            close: 67.8543,
            volume: 743778993
        },
        {
            x: new Date('2013-02-11'),
            open: 68.0714,
            high: 69.2771,
            low: 65.7028,
            close: 65.7371,
            volume: 585292366
        },
        {
            x: new Date('2013-02-18'),
            open: 65.8714,
            high: 66.1043,
            low: 63.26,
            close: 64.4014,
            volume: 421766997
        },
        {
            x: new Date('2013-02-25'),
            open: 64.8357,
            high: 65.0171,
            low: 61.4257,
            close: 61.4957,
            volume: 582741215
        },
        {
            x: new Date('2013-03-04'),
            open: 61.1143,
            high: 62.2043,
            low: 59.8571,
            close: 61.6743,
            volume: 632856539
        },
        {
            x: new Date('2013-03-11'),
            open: 61.3928,
            high: 63.4614,
            low: 60.7343,
            close: 63.38,
            volume: 572066981
        },
        {
            x: new Date('2013-03-18'),
            open: 63.0643,
            high: 66.0143,
            low: 63.0286,
            close: 65.9871,
            volume: 552156035
        },
        {
            x: new Date('2013-03-25'),
            open: 66.3843,
            high: 67.1357,
            low: 63.0886,
            close: 63.2371,
            volume: 390762517
        },
        {
            x: new Date('2013-04-01'),
            open: 63.1286,
            high: 63.3854,
            low: 59.9543,
            close: 60.4571,
            volume: 505273732
        },
        {
            x: new Date('2013-04-08'),
            open: 60.6928,
            high: 62.57,
            low: 60.3557,
            close: 61.4,
            volume: 387323550
        },
        {
            x: new Date('2013-04-15'),
            open: 61,
            high: 61.1271,
            low: 55.0143,
            close: 55.79,
            volume: 709945604
        },
        {
            x: new Date('2013-04-22'),
            open: 56.0914,
            high: 59.8241,
            low: 55.8964,
            close: 59.6007,
            volume: 787007506
        },
        {
            x: new Date('2013-04-29'),
            open: 60.0643,
            high: 64.7471,
            low: 60,
            close: 64.2828,
            volume: 655020017
        },
        {
            x: new Date('2013-05-06'),
            open: 65.1014,
            high: 66.5357,
            low: 64.3543,
            close: 64.71,
            volume: 545488533
        },
        {
            x: new Date('2013-05-13'),
            open: 64.5014,
            high: 65.4143,
            low: 59.8428,
            close: 61.8943,
            volume: 633706550
        },
        {
            x: new Date('2013-05-20'),
            open: 61.7014,
            high: 64.05,
            low: 61.4428,
            close: 63.5928,
            volume: 494379068
        },
        {
            x: new Date('2013-05-27'),
            open: 64.2714,
            high: 65.3,
            low: 62.7714,
            close: 64.2478,
            volume: 362907830
        },
        {
            x: new Date('2013-06-03'),
            open: 64.39,
            high: 64.9186,
            low: 61.8243,
            close: 63.1158,
            volume: 443249793
        },
        {
            x: new Date('2013-06-10'),
            open: 63.5328,
            high: 64.1541,
            low: 61.2143,
            close: 61.4357,
            volume: 389680092
        },
        {
            x: new Date('2013-06-17'),
            open: 61.6343,
            high: 62.2428,
            low: 58.3,
            close: 59.0714,
            volume: 400384818
        },
        {
            x: new Date('2013-06-24'),
            open: 58.2,
            high: 58.38,
            low: 55.5528,
            close: 56.6471,
            volume: 519314826
        },
        {
            x: new Date('2013-07-01'),
            open: 57.5271,
            high: 60.47,
            low: 57.3171,
            close: 59.6314,
            volume: 343878841
        },
        {
            x: new Date('2013-07-08'),
            open: 60.0157,
            high: 61.3986,
            low: 58.6257,
            close: 60.93,
            volume: 384106977
        },
        {
            x: new Date('2013-07-15'),
            open: 60.7157,
            high: 62.1243,
            low: 60.5957,
            close: 60.7071,
            volume: 286035513
        },
        {
            x: new Date('2013-07-22'),
            open: 61.3514,
            high: 63.5128,
            low: 59.8157,
            close: 62.9986,
            volume: 395816827
        },
        {
            x: new Date('2013-07-29'),
            open: 62.9714,
            high: 66.1214,
            low: 62.8857,
            close: 66.0771,
            volume: 339668858
        },
        {
            x: new Date('2013-08-05'),
            open: 66.3843,
            high: 67.4128,
            low: 64.8071,
            close: 64.9214,
            volume: 368486781
        },
        {
            x: new Date('2013-08-12'),
            open: 65.2657,
            high: 72.0357,
            low: 65.2328,
            close: 71.7614,
            volume: 711563584
        },
        {
            x: new Date('2013-08-19'),
            open: 72.0485,
            high: 73.3914,
            low: 71.1714,
            close: 71.5743,
            volume: 417119660
        },
        {
            x: new Date('2013-08-26'),
            open: 71.5357,
            high: 72.8857,
            low: 69.4286,
            close: 69.6023,
            volume: 392805888
        },
        {
            x: new Date('2013-09-02'),
            open: 70.4428,
            high: 71.7485,
            low: 69.6214,
            close: 71.1743,
            volume: 317244380
        },
        {
            x: new Date('2013-09-09'),
            open: 72.1428,
            high: 72.56,
            low: 66.3857,
            close: 66.4143,
            volume: 669376320
        },
        {
            x: new Date('2013-09-16'),
            open: 65.8571,
            high: 68.3643,
            low: 63.8886,
            close: 66.7728,
            volume: 625142677
        },
        {
            x: new Date('2013-09-23'),
            open: 70.8714,
            high: 70.9871,
            low: 68.6743,
            close: 68.9643,
            volume: 475274537
        },
        {
            x: new Date('2013-09-30'),
            open: 68.1786,
            high: 70.3357,
            low: 67.773,
            close: 69.0043,
            volume: 368198906
        },
        {
            x: new Date('2013-10-07'),
            open: 69.5086,
            high: 70.5486,
            low: 68.3257,
            close: 70.4017,
            volume: 361437661
        },
        {
            x: new Date('2013-10-14'),
            open: 69.9757,
            high: 72.7514,
            low: 69.9071,
            close: 72.6985,
            volume: 342694379
        },
        {
            x: new Date('2013-10-21'),
            open: 73.11,
            high: 76.1757,
            low: 72.5757,
            close: 75.1368,
            volume: 490458997
        },
        {
            x: new Date('2013-10-28'),
            open: 75.5771,
            high: 77.0357,
            low: 73.5057,
            close: 74.29,
            volume: 508130174
        },
        {
            x: new Date('2013-11-04'),
            open: 74.4428,
            high: 75.555,
            low: 73.1971,
            close: 74.3657,
            volume: 318132218
        },
        {
            x: new Date('2013-11-11'),
            open: 74.2843,
            high: 75.6114,
            low: 73.4871,
            close: 74.9987,
            volume: 306711021
        },
        {
            x: new Date('2013-11-18'),
            open: 74.9985,
            high: 75.3128,
            low: 73.3814,
            close: 74.2571,
            volume: 282778778
        },
        {
            x: new Date('2013-11-25'),
            open: 74.4314,
            high: 79.7614,
            low: 74.4285,
            close: 79.4385,
            volume: 327405302
        },
        {
            x: new Date('2013-12-02'),
            open: 79.7143,
            high: 82.1622,
            low: 78.6885,
            close: 80.0028,
            volume: 522055676
        },
        {
            x: new Date('2013-12-09'),
            open: 80.1286,
            high: 81.5671,
            low: 79.0957,
            close: 79.2043,
            volume: 387271099
        },
        {
            x: new Date('2013-12-16'),
            open: 79.2885,
            high: 80.377,
            low: 76.9714,
            close: 78.4314,
            volume: 457580848
        },
        {
            x: new Date('2013-12-23'),
            open: 81.1428,
            high: 81.6971,
            low: 79.9285,
            close: 80.0128,
            volume: 274253503
        },
        {
            x: new Date('2013-12-30'),
            open: 79.6371,
            high: 80.1828,
            low: 77.2043,
            close: 77.2828,
            volume: 275734934
        },
        {
            x: new Date('2014-01-06'),
            open: 76.7785,
            high: 78.1228,
            low: 75.8728,
            close: 76.1343,
            volume: 393462075
        },
        {
            x: new Date('2014-01-13'),
            open: 75.7014,
            high: 80.0285,
            low: 75.6971,
            close: 77.2385,
            volume: 439557459
        },
        {
            x: new Date('2014-01-20'),
            open: 77.2843,
            high: 79.6128,
            low: 77.2028,
            close: 78.01,
            volume: 385585525
        },
        {
            x: new Date('2014-01-27'),
            open: 78.5814,
            high: 79.2571,
            low: 70.5071,
            close: 71.5143,
            volume: 813702575
        },
        {
            x: new Date('2014-02-03'),
            open: 71.8014,
            high: 74.7042,
            low: 71.3286,
            close: 74.24,
            volume: 434447570
        },
        {
            x: new Date('2014-02-10'),
            open: 74.0943,
            high: 77.9971,
            low: 74,
            close: 77.7128,
            volume: 379011880
        },
        {
            x: new Date('2014-02-17'),
            open: 78,
            high: 78.7414,
            low: 74.9428,
            close: 75.0357,
            volume: 289609443
        },
        {
            x: new Date('2014-02-24'),
            open: 74.7357,
            high: 76.1071,
            low: 73.6571,
            close: 75.1771,
            volume: 367569649
        },
        {
            x: new Date('2014-03-03'),
            open: 74.7743,
            high: 76.3928,
            low: 74.6871,
            close: 75.7771,
            volume: 275972640
        },
        {
            x: new Date('2014-03-10'),
            open: 75.48,
            high: 77.0943,
            low: 74.7143,
            close: 74.9557,
            volume: 287729528
        },
        {
            x: new Date('2014-03-17'),
            open: 75.3857,
            high: 76.6057,
            low: 75.0286,
            close: 76.1243,
            volume: 303531061
        },
        {
            x: new Date('2014-03-24'),
            open: 76.9171,
            high: 78.4285,
            low: 76.3214,
            close: 76.6943,
            volume: 338387221
        },
        {
            x: new Date('2014-03-31'),
            open: 77.0328,
            high: 77.64,
            low: 75.7971,
            close: 75.9743,
            volume: 245749459
        },
        {
            x: new Date('2014-04-07'),
            open: 75.4314,
            high: 76.0343,
            low: 73.8771,
            close: 74.23,
            volume: 312008139
        },
        {
            x: new Date('2014-04-14'),
            open: 74.5571,
            high: 75.3943,
            low: 73.0471,
            close: 74.9914,
            volume: 241209047
        },
        {
            x: new Date('2014-04-21'),
            open: 75.0485,
            high: 81.7128,
            low: 74.8514,
            close: 81.7057,
            volume: 476651465
        },
        {
            x: new Date('2014-04-28'),
            open: 81.8285,
            high: 85.6328,
            low: 81.7928,
            close: 84.6543,
            volume: 473712709
        },
        {
            x: new Date('2014-05-05'),
            open: 84.3057,
            high: 86.3442,
            low: 82.9043,
            close: 83.6489,
            volume: 365535013
        },
        {
            x: new Date('2014-05-12'),
            open: 83.9271,
            high: 85.3614,
            low: 83.6285,
            close: 85.3585,
            volume: 260931637
        },
        {
            x: new Date('2014-05-19'),
            open: 85.4071,
            high: 87.8184,
            low: 85.3328,
            close: 87.7328,
            volume: 294298274
        },
        {
            x: new Date('2014-05-26'),
            open: 87.9828,
            high: 92.0243,
            low: 87.9471,
            close: 90.4285,
            volume: 400232120
        },
        {
            x: new Date('2014-06-02'),
            open: 90.5657,
            high: 93.0371,
            low: 88.9285,
            close: 92.2243,
            volume: 412158024
        },
        {
            x: new Date('2014-06-09'),
            open: 92.7,
            high: 95.05,
            low: 90.88,
            close: 91.28,
            volume: 292422550
        },
        {
            x: new Date('2014-06-16'),
            open: 91.51,
            high: 92.75,
            low: 90.9,
            close: 90.91,
            volume: 234325480
        },
        {
            x: new Date('2014-06-23'),
            open: 91.32,
            high: 92,
            low: 89.65,
            close: 91.98,
            volume: 213712160
        },
        {
            x: new Date('2014-06-30'),
            open: 92.1,
            high: 94.1,
            low: 92.09,
            close: 94.03,
            volume: 138936570
        },
        {
            x: new Date('2014-07-07'),
            open: 94.14,
            high: 96.8,
            low: 93.52,
            close: 95.22,
            volume: 229782440
        },
        {
            x: new Date('2014-07-14'),
            open: 95.86,
            high: 97.1,
            low: 92.57,
            close: 94.43,
            volume: 248104390
        },
        {
            x: new Date('2014-07-21'),
            open: 94.99,
            high: 97.88,
            low: 93.72,
            close: 97.671,
            volume: 273021350
        },
        {
            x: new Date('2014-07-28'),
            open: 97.82,
            high: 99.44,
            low: 94.81,
            close: 96.13,
            volume: 235868530
        },
        {
            x: new Date('2014-08-04'),
            open: 96.37,
            high: 96.58,
            low: 93.28,
            close: 94.74,
            volume: 222522120
        },
        {
            x: new Date('2014-08-11'),
            open: 95.27,
            high: 98.19,
            low: 94.8355,
            close: 97.98,
            volume: 178806580
        },
        {
            x: new Date('2014-08-18'),
            open: 98.49,
            high: 101.47,
            low: 97.98,
            close: 101.32,
            volume: 246446280
        },
        {
            x: new Date('2014-08-25'),
            open: 101.79,
            high: 102.9,
            low: 100.7,
            close: 102.5,
            volume: 232858250
        },
        {
            x: new Date('2014-09-01'),
            open: 103.06,
            high: 103.74,
            low: 97.79,
            close: 98.97,
            volume: 322045910
        },
        {
            x: new Date('2014-09-08'),
            open: 99.3,
            high: 103.08,
            low: 96.14,
            close: 101.66,
            volume: 460851840
        },
        {
            x: new Date('2014-09-15'),
            open: 102.81,
            high: 103.05,
            low: 98.89,
            close: 100.96,
            volume: 296425730
        },
        {
            x: new Date('2014-09-22'),
            open: 101.8,
            high: 102.94,
            low: 97.72,
            close: 100.75,
            volume: 337617850
        },
        {
            x: new Date('2014-09-29'),
            open: 98.65,
            high: 101.54,
            low: 98.04,
            close: 99.62,
            volume: 246900230
        },
        {
            x: new Date('2014-10-06'),
            open: 99.95,
            high: 102.38,
            low: 98.31,
            close: 100.73,
            volume: 279646740
        },
        {
            x: new Date('2014-10-13'),
            open: 101.33,
            high: 101.78,
            low: 95.18,
            close: 97.67,
            volume: 356408760
        },
        {
            x: new Date('2014-10-20'),
            open: 98.315,
            high: 105.49,
            low: 98.22,
            close: 105.22,
            volume: 355329760
        },
        {
            x: new Date('2014-10-27'),
            open: 104.85,
            high: 108.04,
            low: 104.7,
            close: 108,
            volume: 219443560
        },
        {
            x: new Date('2014-11-03'),
            open: 108.22,
            high: 110.3,
            low: 107.72,
            close: 109.01,
            volume: 199332700
        },
        {
            x: new Date('2014-11-10'),
            open: 109.02,
            high: 114.19,
            low: 108.4,
            close: 114.18,
            volume: 203976340
        },
        {
            x: new Date('2014-11-17'),
            open: 114.27,
            high: 117.57,
            low: 113.3,
            close: 116.47,
            volume: 232574480
        },
        {
            x: new Date('2014-11-24'),
            open: 116.85,
            high: 119.75,
            low: 116.62,
            close: 118.93,
            volume: 181158620
        },
        {
            x: new Date('2014-12-01'),
            open: 118.81,
            high: 119.25,
            low: 111.27,
            close: 115,
            volume: 266118290
        },
        {
            x: new Date('2014-12-08'),
            open: 114.1,
            high: 114.85,
            low: 109.35,
            close: 109.73,
            volume: 259311140
        },
        {
            x: new Date('2014-12-15'),
            open: 110.7,
            high: 113.24,
            low: 106.26,
            close: 111.78,
            volume: 326382400
        },
        {
            x: new Date('2014-12-22'),
            open: 112.16,
            high: 114.52,
            low: 111.97,
            close: 113.99,
            volume: 119248900
        },
        {
            x: new Date('2014-12-29'),
            open: 113.79,
            high: 114.77,
            low: 107.35,
            close: 109.33,
            volume: 151780640
        },
        {
            x: new Date('2015-01-05'),
            open: 108.29,
            high: 113.25,
            low: 104.63,
            close: 112.01,
            volume: 282690970
        },
        {
            x: new Date('2015-01-12'),
            open: 112.6,
            high: 112.8,
            low: 105.2,
            close: 105.99,
            volume: 303531140
        },
        {
            x: new Date('2015-01-19'),
            open: 107.84,
            high: 113.75,
            low: 106.5,
            close: 112.98,
            volume: 198362640
        },
        {
            x: new Date('2015-01-26'),
            open: 113.74,
            high: 110,
            low: 109.03,
            close: 117.16,
            volume: 461747290
        },
        {
            x: new Date('2015-02-02'),
            open: 118.05,
            high: 116.51,
            low: 116.08,
            close: 118.93,
            volume: 270190470
        },
        {
            x: new Date('2015-02-09'),
            open: 118.55,
            high: 117.48,
            low: 118.43,
            close: 127.08,
            volume: 301354470
        },
        {
            x: new Date('2015-02-16'),
            open: 127.49,
            high: 119.5,
            low: 126.92,
            close: 129.495,
            volume: 193883960
        },
        {
            x: new Date('2015-02-23'),
            open: 130.02,
            high: 103.6,
            low: 126.61,
            close: 128.46,
            volume: 369856960
        },
        {
            x: new Date('2015-03-02'),
            open: 129.25,
            high: 109.28,
            low: 125.76,
            close: 126.6,
            volume: 246472020
        },
        {
            x: new Date('2015-03-09'),
            open: 127.96,
            high: 99.57,
            low: 121.63,
            close: 123.59,
            volume: 325921230
        },
        {
            x: new Date('2015-03-16'),
            open: 123.88,
            high: 119.2451,
            low: 122.87,
            close: 125.9,
            volume: 266016400
        },
        {
            x: new Date('2015-03-23'),
            open: 127.12,
            high: 118.04,
            low: 122.6,
            close: 123.25,
            volume: 208731730
        },
        {
            x: new Date('2015-03-30'),
            open: 124.05,
            high: 116.49,
            low: 123.1,
            close: 125.32,
            volume: 161628950
        },
        {
            x: new Date('2015-04-06'),
            open: 124.47,
            high: 118.1218,
            low: 124.33,
            close: 127.1,
            volume: 181454510
        },
        {
            x: new Date('2015-04-13'),
            open: 128.37,
            high: 118.57,
            low: 124.46,
            close: 124.75,
            volume: 170090870
        },
        {
            x: new Date('2015-04-20'),
            open: 125.57,
            high: 120.63,
            low: 125.17,
            close: 130.28,
            volume: 206698310
        },
        {
            x: new Date('2015-04-27'),
            open: 132.31,
            high: 114.54,
            low: 124.58,
            close: 128.95,
            volume: 417115180
        },
        {
            x: new Date('2015-05-04'),
            open: 129.5,
            high: 120.57,
            low: 123.36,
            close: 127.62,
            volume: 270197900
        },
        {
            x: new Date('2015-05-11'),
            open: 127.39,
            high: 119.49,
            low: 124.82,
            close: 128.77,
            volume: 207858180
        },
        {
            x: new Date('2015-05-18'),
            open: 128.38,
            high: 112.97,
            low: 128.36,
            close: 132.54,
            volume: 216438970
        },
        {
            x: new Date('2015-05-25'),
            open: 132.6,
            high: 102.91,
            low: 129.12,
            close: 130.28,
            volume: 197468800
        },
        {
            x: new Date('2015-06-01'),
            open: 131.2,
            high: 121.39,
            low: 128.36,
            close: 128.65,
            volume: 170465550
        },
        {
            x: new Date('2015-06-08'),
            open: 128.9,
            high: 120.18,
            low: 125.62,
            close: 127.17,
            volume: 219812710
        },
        {
            x: new Date('2015-06-15'),
            open: 126.1,
            high: 118.31,
            low: 125.71,
            close: 126.6,
            volume: 197925030
        },
        {
            x: new Date('2015-06-22'),
            open: 127.49,
            high: 119.8,
            low: 126.51,
            close: 126.75,
            volume: 195104520
        },
        {
            x: new Date('2015-06-29'),
            open: 125.46,
            high: 116.94,
            low: 124.48,
            close: 126.44,
            volume: 150747530
        },
        {
            x: new Date('2015-07-06'),
            open: 124.94,
            high: 116.23,
            low: 119.22,
            close: 123.28,
            volume: 274904180
        },
        {
            x: new Date('2015-07-13'),
            open: 125.03,
            high: 119.62,
            low: 124.32,
            close: 129.62,
            volume: 188579340
        },
        {
            x: new Date('2015-07-20'),
            open: 130.97,
            high: 112.97,
            low: 121.99,
            close: 124.5,
            volume: 336423370
        },
        {
            x: new Date('2015-07-27'),
            open: 123.09,
            high: 113.91,
            low: 120.91,
            close: 121.3,
            volume: 191087840
        },
        {
            x: new Date('2015-08-03'),
            open: 121.5,
            high: 112.57,
            low: 112.1,
            close: 115.52,
            volume: 383883210
        },
        {
            x: new Date('2015-08-10'),
            open: 116.53,
            high: 119.99,
            low: 109.63,
            close: 115.96,
            volume: 344549090
        },
        {
            x: new Date('2015-08-17'),
            open: 116.04,
            high: 117.65,
            low: 105.645,
            close: 105.76,
            volume: 318855760
        },
        {
            x: new Date('2015-08-24'),
            open: 110.87,
            high: 113.31,
            low: 102.6,
            close: 113.29,
            volume: 498047270
        },
        {
            x: new Date('2015-08-31'),
            open: 112.03,
            high: 114.53,
            low: 107.36,
            close: 109.27,
            volume: 297402060
        },
        {
            x: new Date('2015-09-07'),
            open: 111.65,
            high: 114.21,
            low: 109.77,
            close: 114.21,
            volume: 251859600
        },
        {
            x: new Date('2015-09-14'),
            open: 116.58,
            high: 116.89,
            low: 111.87,
            close: 113.45,
            volume: 276281980
        },
        {
            x: new Date('2015-09-21'),
            open: 113.67,
            high: 116.69,
            low: 112.37,
            close: 114.71,
            volume: 238617740
        },
        {
            x: new Date('2015-09-28'),
            open: 113.85,
            high: 114.57,
            low: 107.31,
            close: 110.38,
            volume: 313017610
        },
        {
            x: new Date('2015-10-05'),
            open: 109.88,
            high: 112.28,
            low: 108.21,
            close: 112.12,
            volume: 261920950
        },
        {
            x: new Date('2015-10-12'),
            open: 112.73,
            high: 112.75,
            low: 109.56,
            close: 111.04,
            volume: 184208970
        },
        {
            x: new Date('2015-10-19'),
            open: 110.8,
            high: 119.228,
            low: 110.11,
            close: 119.08,
            volume: 221612230
        },
        {
            x: new Date('2015-10-26'),
            open: 118.08,
            high: 121.22,
            low: 113.99,
            close: 119.5,
            volume: 319660750
        },
        {
            x: new Date('2015-11-02'),
            open: 119.87,
            high: 113.82,
            low: 119.61,
            close: 121.06,
            volume: 194953700
        },
        {
            x: new Date('2015-11-09'),
            open: 120.96,
            high: 111.81,
            low: 112.27,
            close: 112.34,
            volume: 216054740
        },
        {
            x: new Date('2015-11-16'),
            open: 111.38,
            high: 119.92,
            low: 111,
            close: 119.3,
            volume: 189492500
        },
        {
            x: new Date('2015-11-23'),
            open: 119.27,
            high: 119.73,
            low: 117.12,
            close: 117.81,
            volume: 109582040
        },
        {
            x: new Date('2015-11-30'),
            open: 117.99,
            high: 119.41,
            low: 114.22,
            close: 119.03,
            volume: 205415620
        },
        {
            x: new Date('2015-12-07'),
            open: 118.98,
            high: 119.86,
            low: 112.851,
            close: 113.18,
            volume: 188609110
        },
        {
            x: new Date('2015-12-14'),
            open: 112.18,
            high: 112.8,
            low: 105.81,
            close: 106.03,
            volume: 314856190
        },
        {
            x: new Date('2015-12-21'),
            open: 107.28,
            high: 109,
            low: 105.57,
            close: 108.03,
            volume: 126450510
        },
        {
            x: new Date('2015-12-28'),
            open: 107.59,
            high: 109.43,
            low: 104.82,
            close: 105.26,
            volume: 123621760
        },
        {
            x: new Date('2016-01-04'),
            open: 102.61,
            high: 105.85,
            low: 96.43,
            close: 96.96,
            volume: 343000960
        },
        {
            x: new Date('2016-01-11'),
            open: 98.97,
            high: 101.19,
            low: 95.36,
            close: 97.13,
            volume: 303375940
        },
        {
            x: new Date('2016-01-18'),
            open: 98.41,
            high: 101.46,
            low: 93.42,
            close: 101.42,
            volume: 242982970
        },
        {
            x: new Date('2016-01-25'),
            open: 101.52,
            high: 101.53,
            low: 92.39,
            close: 97.34,
            volume: 376481100
        },
        {
            x: new Date('2016-02-01'),
            open: 96.47,
            high: 97.33,
            low: 93.69,
            close: 94.02,
            volume: 216608840
        },
        {
            x: new Date('2016-02-08'),
            open: 93.13,
            high: 96.35,
            low: 92.59,
            close: 93.99,
            volume: 230794620
        },
        {
            x: new Date('2016-02-15'),
            open: 95.02,
            high: 98.89,
            low: 94.61,
            close: 96.04,
            volume: 167001070
        },
        {
            x: new Date('2016-02-22'),
            open: 96.31,
            high: 98.0237,
            low: 93.32,
            close: 96.91,
            volume: 158759600
        },
        {
            x: new Date('2016-02-29'),
            open: 96.86,
            high: 103.75,
            low: 96.65,
            close: 103.01,
            volume: 201482180
        },
        {
            x: new Date('2016-03-07'),
            open: 102.39,
            high: 102.83,
            low: 100.15,
            close: 102.26,
            volume: 155437450
        },
        {
            x: new Date('2016-03-14'),
            open: 101.91,
            high: 106.5,
            low: 101.78,
            close: 105.92,
            volume: 181323210
        },
        {
            x: new Date('2016-03-21'),
            open: 105.93,
            high: 107.65,
            low: 104.89,
            close: 105.67,
            volume: 119054360
        },
        {
            x: new Date('2016-03-28'),
            open: 106,
            high: 110.42,
            low: 104.88,
            close: 109.99,
            volume: 147641240
        },
        {
            x: new Date('2016-04-04'),
            open: 110.42,
            high: 112.19,
            low: 108.121,
            close: 108.66,
            volume: 145351790
        },
        {
            x: new Date('2016-04-11'),
            open: 108.97,
            high: 112.39,
            low: 108.66,
            close: 109.85,
            volume: 161518860
        },
        {
            x: new Date('2016-04-18'),
            open: 108.89,
            high: 108.95,
            low: 104.62,
            close: 105.68,
            volume: 188775240
        },
        {
            x: new Date('2016-04-25'),
            open: 105,
            high: 105.65,
            low: 92.51,
            close: 93.74,
            volume: 345910030
        },
        {
            x: new Date('2016-05-02'),
            open: 93.965,
            high: 95.9,
            low: 91.85,
            close: 92.72,
            volume: 225114110
        },
        {
            x: new Date('2016-05-09'),
            open: 93,
            high: 93.77,
            low: 89.47,
            close: 90.52,
            volume: 215596350
        },
        {
            x: new Date('2016-05-16'),
            open: 92.39,
            high: 95.43,
            low: 91.65,
            close: 95.22,
            volume: 212312980
        },
        {
            x: new Date('2016-05-23'),
            open: 95.87,
            high: 100.73,
            low: 95.67,
            close: 100.35,
            volume: 203902650
        },
        {
            x: new Date('2016-05-30'),
            open: 99.6,
            high: 100.4,
            low: 96.63,
            close: 97.92,
            volume: 140064910
        },
        {
            x: new Date('2016-06-06'),
            open: 97.99,
            high: 101.89,
            low: 97.55,
            close: 98.83,
            volume: 124731320
        },
        {
            x: new Date('2016-06-13'),
            open: 98.69,
            high: 99.12,
            low: 95.3,
            close: 95.33,
            volume: 191017280
        },
        {
            x: new Date('2016-06-20'),
            open: 96,
            high: 96.89,
            low: 92.65,
            close: 93.4,
            volume: 206149160
        },
        {
            x: new Date('2016-06-27'),
            open: 93,
            high: 96.465,
            low: 91.5,
            close: 95.89,
            volume: 184254460
        },
        {
            x: new Date('2016-07-04'),
            open: 95.39,
            high: 96.89,
            low: 94.37,
            close: 96.68,
            volume: 111769640
        },
        {
            x: new Date('2016-07-11'),
            open: 96.75,
            high: 99.3,
            low: 96.73,
            close: 98.78,
            volume: 142244590
        },
        {
            x: new Date('2016-07-18'),
            open: 98.7,
            high: 101,
            low: 98.31,
            close: 98.66,
            volume: 147358320
        },
        {
            x: new Date('2016-07-25'),
            open: 98.25,
            high: 104.55,
            low: 96.42,
            close: 104.21,
            volume: 252358930
        },
        {
            x: new Date('2016-08-01'),
            open: 104.41,
            high: 107.65,
            low: 104,
            close: 107.48,
            volume: 168265830
        },
        {
            x: new Date('2016-08-08'),
            open: 107.52,
            high: 108.94,
            low: 107.16,
            close: 108.18,
            volume: 124255340
        },
        {
            x: new Date('2016-08-15'),
            open: 108.14,
            high: 110.23,
            low: 108.08,
            close: 109.36,
            volume: 131814920
        },
        {
            x: new Date('2016-08-22'),
            open: 108.86,
            high: 109.32,
            low: 106.31,
            close: 106.94,
            volume: 123373540
        },
        {
            x: new Date('2016-08-29'),
            open: 106.62,
            high: 108,
            low: 105.5,
            close: 107.73,
            volume: 134426100
        },
        {
            x: new Date('2016-09-05'),
            open: 107.9,
            high: 108.76,
            low: 103.13,
            close: 103.13,
            volume: 168312530
        },
        {
            x: new Date('2016-09-12'),
            open: 102.65,
            high: 116.13,
            low: 102.53,
            close: 114.92,
            volume: 388543710
        },
        {
            x: new Date('2016-09-19'),
            open: 115.19,
            high: 116.18,
            low: 111.55,
            close: 112.71,
            volume: 200842480
        },
        {
            x: new Date('2016-09-26'),
            open: 111.64,
            high: 114.64,
            low: 111.55,
            close: 113.05,
            volume: 156186800
        },
        {
            x: new Date('2016-10-03'),
            open: 112.71,
            high: 114.56,
            low: 112.28,
            close: 114.06,
            volume: 125587350
        },
        {
            x: new Date('2016-10-10'),
            open: 115.02,
            high: 118.69,
            low: 114.72,
            close: 117.63,
            volume: 208231690
        },
        {
            x: new Date('2016-10-17'),
            open: 117.33,
            high: 118.21,
            low: 113.8,
            close: 116.6,
            volume: 114497020
        },
        {
            x: new Date('2016-10-24'),
            open: 117.1,
            high: 118.36,
            low: 113.31,
            close: 113.72,
            volume: 204530120
        },
        {
            x: new Date('2016-10-31'),
            open: 113.65,
            high: 114.23,
            low: 108.11,
            close: 108.84,
            volume: 155287280
        },
        {
            x: new Date('2016-11-07'),
            open: 110.08,
            high: 111.72,
            low: 105.83,
            close: 108.43,
            volume: 206825070
        },
        {
            x: new Date('2016-11-14'),
            open: 107.71,
            high: 110.54,
            low: 104.08,
            close: 110.06,
            volume: 197790040
        },
        {
            x: new Date('2016-11-21'),
            open: 110.12,
            high: 112.42,
            low: 110.01,
            close: 111.79,
            volume: 93992370
        },
        {
            x: new Date('2016-11-28'),
            open: 111.43,
            high: 112.465,
            low: 108.85,
            close: 109.9,
            volume: 155229390
        },
        {
            x: new Date('2016-12-05'),
            open: 110,
            high: 114.7,
            low: 108.25,
            close: 113.95,
            volume: 151624650
        },
        {
            x: new Date('2016-12-12'),
            open: 113.29,
            high: 116.73,
            low: 112.49,
            close: 115.97,
            volume: 194003220
        },
        {
            x: new Date('2016-12-19'),
            open: 115.8,
            high: 117.5,
            low: 115.59,
            close: 116.52,
            volume: 113106370
        },
        {
            x: new Date('2016-12-26'),
            open: 116.52,
            high: 118.0166,
            low: 115.43,
            close: 115.82,
            volume: 84354060
        }
];
var periodData = [
        { Open: .05, High: .09, Low: .06, Close: .09 },
        { Open: .09, High: .09, Low: .08, Close: .08 },
        { Open: .08, High: .08, Low: .07, Close: .07 },
        { Open: .07, High: .08, Low: .07, Close: .08 },
        { Open: .08, High: .08, Low: .05, Close: .05 },
        { Open: .05, High: .07, Low: .05, Close: .06 },
        { Open: .06, High: .06, Low: .05, Close: .05 },
        { Open: .05, High: .06, Low: .05, Close: .05 },
        { Open: .05, High: .06, Low: .05, Close: .06 },
        { Open: .06, High: .06, Low: .05, Close: .06 },
        { Open: .06, High: .06, Low: .05, Close: .06 },
        { Open: .06, High: .07, Low: .06, Close: .07 },
        { Open: .07, High: .07, Low: .06, Close: .06 },
        { Open: .06, High: .07, Low: .06, Close: .07 },
        { Open: .07, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .07, Low: .06, Close: .07 },
        { Open: .07, High: .07, Low: .07, Close: .07 },
        { Open: .07, High: .08, Low: .06, Close: .07 },
        { Open: .07, High: .07, Low: .06, Close: .07 },
        { Open: .07, High: .07, Low: .06, Close: .06 },
        { Open: .06, High: .07, Low: .06, Close: .07 },
        { Open: .07, High: .07, Low: .06, Close: .07 },
        { Open: .07, High: .07, Low: .06, Close: .07 },
        { Open: .07, High: .08, Low: .06, Close: .07 },
        { Open: .07, High: .07, Low: .07, Close: .07 },
        { Open: .07, High: .07, Low: .07, Close: .07 },
        { Open: .07, High: .07, Low: .06, Close: .07 },
        { Open: .07, High: .07, Low: .06, Close: .07 },
        { Open: .07, High: .07, Low: .06, Close: .07 },
        { Open: .07, High: .07, Low: .06, Close: .06 },
        { Open: .06, High: .07, Low: .06, Close: .06 },
        { Open: .06, High: .07, Low: .06, Close: .06 },
        { Open: .06, High: .07, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .07, Low: .03, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .17, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .06, Low: .06, Close: .06 },
        { Open: .06, High: .07, Low: .06, Close: .07 },
        { Open: .07, High: .09, Low: .01, Close: .09 },
        { Open: .09, High: .12, Low: .07, Close: .09 },
        { Open: .09, High: .13, Low: .08, Close: .1 },
        { Open: .1, High: .1, Low: .09, Close: .09 },
        { Open: .09, High: .1, Low: .08, Close: .09 },
        { Open: .09, High: .1, Low: .09, Close: .1 },
        { Open: .1, High: .1, Low: .06, Close: .1 },
        { Open: .1, High: .12, Low: .09, Close: .1 },
        { Open: .1, High: .1, Low: .1, Close: .1 },
        { Open: .1, High: .1, Low: .1, Close: .1 },
        { Open: .1, High: .1, Low: .1, Close: .1 },
        { Open: .1, High: .1, Low: .1, Close: .1 },
        { Open: .1, High: .1, Low: .09, Close: .1 },
        { Open: .1, High: .11, Low: .1, Close: .11 },
        { Open: .11, High: .11, Low: .1, Close: .1 },
        { Open: .1, High: .11, Low: .1, Close: .11 },
        { Open: .11, High: .19, Low: .11, Close: .11 },
        { Open: .11, High: .19, Low: .09, Close: .13 },
        { Open: .13, High: .18, Low: .13, Close: .15 },
        { Open: .15, High: .19, Low: .15, Close: .19 },
        { Open: .19, High: .19, Low: .17, Close: .17 },
        { Open: .17, High: .19, Low: .17, Close: .19 },
        { Open: .19, High: .2, Low: .19, Close: .2 },
        { Open: .2, High: .2, Low: .17, Close: .19 },
        { Open: .19, High: .2, Low: .17, Close: .2 },
        { Open: .2, High: .19, Low: .19, Close: .19 },
        { Open: .19, High: .27, Low: .12, Close: .19 },
        { Open: .19, High: .24, Low: .19, Close: .23 },
        { Open: .23, High: .26, Low: .21, Close: .26 },
        { Open: .26, High: .5, Low: .24, Close: .39 },
        { Open: .39, High: .47, Low: .29, Close: .34 },
        { Open: .34, High: .37, Low: .23, Close: .24 },
        { Open: .24, High: .32, Low: .2, Close: .21 },
        { Open: .21, High: .24, Low: .14, Close: .24 },
        { Open: .24, High: .24, Low: .21, Close: .22 },
        { Open: .22, High: .29, Low: .22, Close: .27 },
        { Open: .27, High: .3, Low: .27, Close: .28 },
        { Open: .28, High: .3, Low: .27, Close: .28 },
        { Open: .28, High: .28, Low: .27, Close: .27 },
        { Open: .27, High: .27, Low: .22, Close: .22 },
        { Open: .22, High: .29, Low: .21, Close: .23 },
        { Open: .23, High: .28, Low: .22, Close: .27 },
        { Open: .27, High: .28, Low: .27, Close: .28 },
        { Open: .28, High: .29, Low: .27, Close: .28 },
        { Open: .28, High: .28, Low: .28, Close: .28 },
        { Open: .28, High: .29, Low: .27, Close: .29 },
        { Open: .29, High: .28, Low: .28, Close: .28 },
        { Open: .28, High: .28, Low: .28, Close: .28 },
        { Open: .28, High: .28, Low: .28, Close: .28 },
        { Open: .28, High: .29, Low: .28, Close: .28 },
        { Open: .28, High: .28, Low: .28, Close: .28 },
        { Open: .28, High: .28, Low: .27, Close: .27 },
        { Open: .27, High: .28, Low: .22, Close: .23 },
        { Open: .23, High: .23, Low: .2, Close: .21 },
        { Open: .21, High: .23, Low: .21, Close: .23 },
        { Open: .23, High: .26, Low: .22, Close: .25 },
        { Open: .25, High: .26, Low: .24, Close: .25 },
        { Open: .25, High: .26, Low: .2, Close: .2 },
        { Open: .2, High: .23, Low: .19, Close: .19 },
        { Open: .19, High: .22, Low: .18, Close: .2 },
        { Open: .2, High: .25, Low: .17, Close: .23 },
        { Open: .23, High: .24, Low: .22, Close: .24 },
        { Open: .24, High: .23, Low: .17, Close: .2 },
        { Open: .2, High: .2, Low: .18, Close: .2 },
        { Open: .2, High: .23, Low: .19, Close: .23 },
        { Open: .23, High: .23, Low: .21, Close: .22 },
        { Open: .22, High: .23, Low: .21, Close: .23 },
        { Open: .23, High: .25, Low: .21, Close: .25 },
        { Open: .25, High: .25, Low: .24, Close: .24 },
        { Open: .24, High: .25, Low: .22, Close: .25 },
        { Open: .25, High: .25, Low: .24, Close: .24 },
        { Open: .24, High: .25, Low: .24, Close: .24 },
        { Open: .24, High: .25, Low: .24, Close: .24 },
        { Open: .24, High: .27, Low: .24, Close: .27 },
        { Open: .27, High: .27, Low: .24, Close: .24 },
        { Open: .24, High: .25, Low: .24, Close: .25 },
        { Open: .25, High: .25, Low: .24, Close: .25 },
        { Open: .25, High: .25, Low: .24, Close: .25 },
        { Open: .25, High: .25, Low: .25, Close: .25 },
        { Open: .25, High: .27, Low: .25, Close: .26 },
        { Open: .26, High: .27, Low: .25, Close: .26 },
        { Open: .26, High: .28, Low: .26, Close: .28 },
        { Open: .28, High: .3, Low: .27, Close: .3 },
        { Open: .3, High: .3, Low: .29, Close: .3 },
        { Open: .3, High: .3, Low: .29, Close: .3 },
        { Open: .3, High: .3, Low: .29, Close: .3 },
        { Open: .3, High: .3, Low: .29, Close: .3 },
        { Open: .3, High: .3, Low: .29, Close: .29 },
        { Open: .29, High: .3, Low: .29, Close: .3 },
        { Open: .3, High: .3, Low: .29, Close: .3 },
        { Open: .3, High: .3, Low: .29, Close: .3 },
        { Open: .3, High: .32, Low: .3, Close: .32 },
        { Open: .32, High: .32, Low: .31, Close: .32 },
        { Open: .32, High: .32, Low: .32, Close: .32 },
        { Open: .32, High: .33, Low: .32, Close: .33 },
        { Open: .33, High: .33, Low: .32, Close: .33 },
        { Open: .33, High: .36, Low: .32, Close: .32 },
        { Open: .32, High: .4, Low: .32, Close: .32 },
        { Open: .32, High: .45, Low: .32, Close: .4 },
        { Open: .4, High: .4, Low: .38, Close: .39 },
        { Open: .39, High: .4, Low: .39, Close: .39 },
        { Open: .39, High: .39, Low: .31, Close: .35 },
        { Open: .35, High: .35, Low: .3, Close: .31 },
        { Open: .31, High: .31, Low: .3, Close: .31 },
        { Open: .31, High: .39, Low: .31, Close: .39 },
        { Open: .39, High: .44, Low: .37, Close: .42 },
        { Open: .42, High: .44, Low: .39, Close: .44 },
        { Open: .44, High: .44, Low: .42, Close: .44 },
        { Open: .44, High: .44, Low: .38, Close: .42 },
        { Open: .42, High: .42, Low: .4, Close: .41 },
        { Open: .41, High: .42, Low: .39, Close: .42 },
        { Open: .42, High: .45, Low: .41, Close: .42 },
        { Open: .42, High: .45, Low: .42, Close: .45 },
        { Open: .45, High: .44, Low: .43, Close: .44 },
        { Open: .44, High: .48, Low: .44, Close: .48 },
        { Open: .48, High: .95, Low: .47, Close: .52 },
        { Open: .52, High: .85, Low: .52, Close: .7 },
        { Open: .7, High: .76, Low: .69, Close: .72 },
        { Open: .72, High: .75, Low: .65, Close: .69 },
        { Open: .69, High: .88, Low: .67, Close: .81 },
        { Open: .81, High: .92, Low: .81, Close: .92 },
        { Open: .92, High: .92, Low: .83, Close: .9 },
        { Open: .9, High: .9, Low: .83, Close: .89 },
        { Open: .89, High: .92, Low: .86, Close: .92 },
        { Open: .92, High: 1.09, Low: .82, Close: 1.09 },
        { Open: 1.09, High: 1.1, Low: .8, Close: .98 },
        { Open: .98, High: 1.09, Low: .93, Close: 1.07 },
        { Open: 1.07, High: 1.08, Low: .99, Close: 1.08 },
        { Open: 1.08, High: 1.08, Low: 1.02, Close: 1.05 },
        { Open: 1.05, High: 1.08, Low: 1.03, Close: 1.07 },
        { Open: 1.07, High: 1.08, Low: 1.03, Close: 1.05 },
        { Open: 1.05, High: 1.05, Low: 1.02, Close: 1.04 },
        { Open: 1.04, High: 1.05, Low: 1.02, Close: 1.04 },
        { Open: 1.04, High: 1.04, Low: .78, Close: .9 },
        { Open: .9, High: .98, Low: .84, Close: .95 },
        { Open: .95, High: .95, Low: .83, Close: .85 },
        { Open: .85, High: .88, Low: .83, Close: .83 },
        { Open: .83, High: .95, Low: .83, Close: .87 },
        { Open: .87, High: .94, Low: .87, Close: .9 },
        { Open: .9, High: 1., Low: .9, Close: 1. },
        { Open: 1., High: 1., Low: .91, Close: .91 },
        { Open: .91, High: .97, Low: .91, Close: .96 },
        { Open: .96, High: .96, Low: .89, Close: .89 },
        { Open: .89, High: .92, Low: .84, Close: .86 },
        { Open: .86, High: .97, Low: .85, Close: .92 },
        { Open: .92, High: .94, Low: .91, Close: .94 },
        { Open: .94, High: .94, Low: .91, Close: .94 },
        { Open: .94, High: .94, Low: .9, Close: .9 },
        { Open: .9, High: .92, Low: .81, Close: .91 },
        { Open: .91, High: .91, Low: .81, Close: .9 },
        { Open: .9, High: .91, Low: .85, Close: .88 },
        { Open: .88, High: .88, Low: .85, Close: .87 },
        { Open: .87, High: .87, Low: .85, Close: .86 },
        { Open: .86, High: .93, Low: .85, Close: .93 },
        { Open: .93, High: .92, Low: .86, Close: .88 },
        { Open: .88, High: .92, Low: .88, Close: .92 },
        { Open: .92, High: .92, Low: .89, Close: .89 },
        { Open: .89, High: .9, Low: .88, Close: .89 },
        { Open: .89, High: .89, Low: .87, Close: .87 },
        { Open: .87, High: .88, Low: .84, Close: .86 },
        { Open: .86, High: .88, Low: .81, Close: .83 },
        { Open: .83, High: .85, Low: .71, Close: .82 },
        { Open: .82, High: .8, Low: .73, Close: .76 },
        { Open: .76, High: .79, Low: .74, Close: .74 },
        { Open: .74, High: .77, Low: .74, Close: .76 },
        { Open: .76, High: .81, Low: .74, Close: .81 },
        { Open: .81, High: .85, Low: .78, Close: .85 },
        { Open: .85, High: .9, Low: .83, Close: .87 },
        { Open: .87, High: .89, Low: .86, Close: .88 },
        { Open: .88, High: .9, Low: .84, Close: .86 },
        { Open: .86, High: .87, Low: .82, Close: .82 },
        { Open: .82, High: .85, Low: .76, Close: .8 },
        { Open: .8, High: .8, Low: .76, Close: .79 },
        { Open: .79, High: .79, Low: .77, Close: .79 },
        { Open: .79, High: .8, Low: .77, Close: .78 },
        { Open: .78, High: .8, Low: .77, Close: .77 },
        { Open: .77, High: .8, Low: .77, Close: .78 },
        { Open: .78, High: .79, Low: .78, Close: .78 },
        { Open: .78, High: .78, Low: .56, Close: .68 },
        { Open: .68, High: .75, Low: .58, Close: .71 },
        { Open: .71, High: .75, Low: .69, Close: .74 },
        { Open: .74, High: .78, Low: .72, Close: .75 },
        { Open: .75, High: .8, Low: .73, Close: .75 },
        { Open: .75, High: .77, Low: .72, Close: .73 },
        { Open: .73, High: .76, Low: .71, Close: .74 },
        { Open: .74, High: .8, Low: .71, Close: .77 },
        { Open: .77, High: .9, Low: .77, Close: .86 },
        { Open: .86, High: 1., Low: .86, Close: .92 },
        { Open: .92, High: 1., Low: .91, Close: 1. },
        { Open: 1., High: 1.09, Low: .91, Close: .99 },
        { Open: .99, High: 1.09, Low: .95, Close: 1.05 },
        { Open: 1.05, High: 1.14, Low: 1.03, Close: 1.11 },
        { Open: 1.11, High: 1.2, Low: 1.11, Close: 1.16 },
        { Open: 1.16, High: 1.2, Low: 1.14, Close: 1.2 },
        { Open: 1.2, High: 1.2, Low: 1.13, Close: 1.14 },
        { Open: 1.14, High: 1.21, Low: 1.14, Close: 1.21 },
        { Open: 1.21, High: 1.41, Low: 1.19, Close: 1.41 },
        { Open: 1.41, High: 1.95, Low: 1.32, Close: 1.7 },
        { Open: 1.7, High: 1.95, Low: 1.6, Close: 1.63 },
        { Open: 1.63, High: 1.7, Low: 1.52, Close: 1.56 },
        { Open: 1.56, High: 1.79, Low: 1.53, Close: 1.79 },
        { Open: 1.79, High: 1.95, Low: 1.72, Close: 1.9 },
        { Open: 1.9, High: 2.65, Low: 1.66, Close: 2.21 },
        { Open: 2.21, High: 2.95, Low: 2.21, Close: 2.88 },
        { Open: 2.88, High: 4.15, Low: 2.75, Close: 3.5 },
        { Open: 3.5, High: 3.87, Low: 2.5, Close: 3.03 },
        { Open: 3.03, High: 3.49, Low: 3.03, Close: 3.2 },
        { Open: 3.2, High: 3.49, Low: 3.11, Close: 3.41 },
        { Open: 3.41, High: 3.58, Low: 3.25, Close: 3.41 },
        { Open: 3.41, High: 3.45, Low: 3.33, Close: 3.33 },
        { Open: 3.33, High: 3.61, Low: 3.29, Close: 3.45 },
        { Open: 3.45, High: 3.7, Low: 3.42, Close: 3.64 },
        { Open: 3.64, High: 3.94, Low: 3.63, Close: 3.87 },
        { Open: 3.87, High: 3.9, Low: 3.69, Close: 3.8 },
        { Open: 3.8, High: 5.99, Low: 3.81, Close: 5.81 },
        { Open: 5.81, High: 6.06, Low: 4.6, Close: 5.5 },
        { Open: 5.5, High: 6.49, Low: 5.22, Close: 6.3 },
        { Open: 6.3, High: 8.45, Low: 6.32, Close: 8.2 },
        { Open: 8.2, High: 8.9, Low: 5.83, Close: 7.2 },
        { Open: 7.2, High: 7.78, Low: 6.2, Close: 6.99 },
        { Open: 6.99, High: 8.5, Low: 6.75, Close: 8.03 },
        { Open: 8.03, High: 8.39, Low: 6.98, Close: 7.19 },
        { Open: 7.19, High: 7.5, Low: 6.6, Close: 6.88 },
        { Open: 6.88, High: 7.34, Low: 6.61, Close: 6.8 },
        { Open: 6.8, High: 7.1, Low: 5.58, Close: 5.59 },
        { Open: 5.59, High: 6.52, Low: 5.58, Close: 6.12 },
        { Open: 6.12, High: 6.76, Low: 5.99, Close: 6.69 },
        { Open: 6.69, High: 7.45, Low: 6.69, Close: 7.15 },
        { Open: 7.15, High: 7.51, Low: 6.96, Close: 7.42 },
        { Open: 7.42, High: 9.33, Low: 7.22, Close: 8.4 },
        { Open: 8.4, High: 8.99, Low: 8.01, Close: 8.8 },
        { Open: 8.8, High: 8.83, Low: 8.5, Close: 8.5 },
        { Open: 8.5, High: 8.7, Low: 8.11, Close: 8.3 },
        { Open: 8.3, High: 8.49, Low: 8.1, Close: 8.43 },
        { Open: 8.43, High: 9., Low: 8.25, Close: 8.8 },
        { Open: 8.8, High: 9.5, Low: 8.1, Close: 8.74 },
        { Open: 8.74, High: 9.7, Low: 8.3, Close: 9.57 },
        { Open: 9.57, High: 10.89, Low: 9.5, Close: 10.6 },
        { Open: 10.6, High: 14.5, Low: 10.58, Close: 14.29 },
        { Open: 14.29, High: 18.89, Low: 14.04, Close: 18.89 },
        { Open: 18.89, High: 19., Low: 16.2, Close: 16.7 },
        { Open: 16.7, High: 19.23, Low: 16.45, Close: 18.55 },
        { Open: 18.55, High: 24.32, Low: 18.26, Close: 23.92 },
        { Open: 23.92, High: 31.91, Low: 22.21, Close: 29.6 },
        { Open: 29.6, High: 31.5, Low: 26.15, Close: 28.92 },
        { Open: 28.92, High: 29.4, Low: 20.01, Close: 23.95 },
        { Open: 23.95, High: 23.99, Low: 13., Close: 14.65 },
        { Open: 14.65, High: 24.99, Low: 10.25, Close: 18.55 },
        { Open: 18.55, High: 24.5, Low: 16., Close: 19.84 },
        { Open: 19.84, High: 20.5, Low: 18., Close: 19.28 },
        { Open: 19.28, High: 20., Low: 19.02, Close: 19.49 },
        { Open: 19.49, High: 19.89, Low: 17., Close: 17. },
        { Open: 17., High: 18.34, Low: 13., Close: 15.68 },
        { Open: 15.68, High: 16.95, Low: 15.05, Close: 16.89 },
        { Open: 16.89, High: 18.88, Low: 16.85, Close: 17.51 },
        { Open: 17.51, High: 17.51, Low: 17.51, Close: 17.51 },
        { Open: 17.51, High: 17.51, Low: 17.51, Close: 17.51 },
        { Open: 17.51, High: 17.51, Low: 17.51, Close: 17.51 },
        { Open: 17.51, High: 17.51, Low: 17.51, Close: 17.51 },
        { Open: 17.51, High: 17.51, Low: 17.51, Close: 17.51 },
        { Open: 17.51, High: 17.51, Low: 17.51, Close: 17.51 },
        { Open: 17.51, High: 17.51, Low: 14.01, Close: 16.45 },
        { Open: 16.45, High: 18., Low: 15., Close: 16.75 },
        { Open: 16.75, High: 17.52, Low: 16.5, Close: 16.95 },
        { Open: 16.95, High: 17.2, Low: 16.67, Close: 16.84 },
        { Open: 16.84, High: 17., Low: 15.73, Close: 16.1 },
        { Open: 16.1, High: 16.74, Low: 15.26, Close: 15.4 },
        { Open: 15.4, High: 15.8, Low: 15.27, Close: 15.4 },
        { Open: 15.4, High: 15.69, Low: 15.31, Close: 15.44 },
        { Open: 15.44, High: 15.49, Low: 13.14, Close: 13.86 },
        { Open: 13.86, High: 15., Low: 11., Close: 12.91 },
        { Open: 12.91, High: 16.5, Low: 12.67, Close: 14.78 },
        { Open: 14.78, High: 15.9, Low: 14.5, Close: 14.78 },
        { Open: 14.78, High: 15.64, Low: 13.9, Close: 14.31 },
        { Open: 14.31, High: 14.7, Low: 14.02, Close: 14.38 },
        { Open: 14.38, High: 15.68, Low: 14.35, Close: 14.9 },
        { Open: 14.9, High: 15.2, Low: 13.8, Close: 14.21 },
        { Open: 14.21, High: 14.64, Low: 13.9, Close: 14.01 },
        { Open: 14.01, High: 14.15, Low: 13.91, Close: 13.95 },
        { Open: 13.95, High: 14.07, Low: 13.7, Close: 13.99 },
        { Open: 13.99, High: 14.09, Low: 13.5, Close: 13.81 },
        { Open: 13.81, High: 13.81, Low: 13.5, Close: 13.72 },
        { Open: 13.72, High: 13.75, Low: 13.02, Close: 13.16 },
        { Open: 13.16, High: 13.91, Low: 12.51, Close: 13.48 },
        { Open: 13.48, High: 14.7, Low: 13.44, Close: 13.85 },
        { Open: 13.85, High: 14., Low: 13.4, Close: 13.69 },
        { Open: 13.69, High: 13.78, Low: 13.4, Close: 13.61 },
        { Open: 13.61, High: 13.81, Low: 13.45, Close: 13.7 },
        { Open: 13.7, High: 13.76, Low: 13.51, Close: 13.68 },
        { Open: 13.68, High: 14.1, Low: 13.6, Close: 13.98 },
        { Open: 13.98, High: 14.72, Low: 13.76, Close: 14.05 },
        { Open: 14.05, High: 14.05, Low: 13.77, Close: 13.88 },
        { Open: 13.88, High: 14.13, Low: 13.85, Close: 13.94 },
        { Open: 13.94, High: 13.94, Low: 13.31, Close: 13.49 },
        { Open: 13.49, High: 13.7, Low: 13.33, Close: 13.5 },
        { Open: 13.5, High: 13.63, Low: 13.45, Close: 13.53 },
        { Open: 13.53, High: 14.9, Low: 12.83, Close: 13.35 },
        { Open: 13.35, High: 13.55, Low: 12.85, Close: 13.09 },
        { Open: 13.09, High: 13.1, Low: 11.5, Close: 12.05 },
        { Open: 12.05, High: 12.16, Low: 8.7, Close: 9.26 },
        { Open: 9.26, High: 11.15, Low: 9.27, Close: 10.75 },
        { Open: 10.75, High: 10.99, Low: 9.5, Close: 9.8 },
        { Open: 9.8, High: 9.95, Low: 5.74, Close: 6.55 },
        { Open: 6.55, High: 9.47, Low: 6.01, Close: 7.9 },
        { Open: 7.9, High: 8.16, Low: 7.05, Close: 7.8 },
        { Open: 7.8, High: 12.1, Low: 7.67, Close: 9.99 },
        { Open: 9.99, High: 10.4, Low: 9.5, Close: 9.98 },
        { Open: 9.98, High: 10.5, Low: 8.45, Close: 9.46 },
        { Open: 9.46, High: 9.8, Low: 8.91, Close: 9.46 },
        { Open: 9.46, High: 10.25, Low: 9.28, Close: 10.13 },
        { Open: 10.13, High: 11.24, Low: 9.62, Close: 10.8 },
        { Open: 10.8, High: 11.89, Low: 10.72, Close: 11.15 },
        { Open: 11.15, High: 11.32, Low: 10.81, Close: 10.96 },
        { Open: 10.96, High: 11.1, Low: 10.66, Close: 10.95 },
        { Open: 10.95, High: 11.05, Low: 10.81, Close: 10.83 },
        { Open: 10.83, High: 11.81, Low: 10.83, Close: 11.65 },
        { Open: 11.65, High: 11.69, Low: 11.4, Close: 11.45 },
        { Open: 11.45, High: 11.51, Low: 11.31, Close: 11.31 },
        { Open: 11.31, High: 11.5, Low: 10.51, Close: 10.89 },
        { Open: 10.89, High: 11.3, Low: 10.81, Close: 10.94 },
        { Open: 10.94, High: 11.08, Low: 10.83, Close: 10.85 },
        { Open: 10.85, High: 10.89, Low: 9.1, Close: 9.66 },
        { Open: 9.66, High: 9.89, Low: 7.64, Close: 8.18 },
        { Open: 8.18, High: 9.11, Low: 8.12, Close: 8.59 },
        { Open: 8.59, High: 9.48, Low: 8.45, Close: 9.07 },
        { Open: 9.07, High: 9.27, Low: 8.65, Close: 8.97 },
        { Open: 8.97, High: 9., Low: 8.55, Close: 8.79 },
        { Open: 8.79, High: 8.79, Low: 8.01, Close: 8.2 },
        { Open: 8.2, High: 8.36, Low: 8.1, Close: 8.21 },
        { Open: 8.21, High: 8.71, Low: 8.23, Close: 8.64 },
        { Open: 8.64, High: 8.69, Low: 8.36, Close: 8.48 },
        { Open: 8.48, High: 8.49, Low: 7.85, Close: 8.18 },
        { Open: 8.18, High: 8.19, Low: 7.25, Close: 7.61 },
        { Open: 7.61, High: 7.66, Low: 6.12, Close: 6.86 },
        { Open: 6.86, High: 7.6, Low: 6.53, Close: 7.19 },
        { Open: 7.19, High: 7.2, Low: 6.51, Close: 6.53 },
        { Open: 6.53, High: 6.58, Low: 4.18, Close: 5.03 },
        { Open: 5.03, High: 5.49, Low: 4.63, Close: 4.77 },
        { Open: 4.77, High: 7.4, Low: 4.6, Close: 5.86 },
        { Open: 5.86, High: 6.58, Low: 5.41, Close: 6.08 },
        { Open: 6.08, High: 6.08, Low: 5.7, Close: 5.8 },
        { Open: 5.8, High: 5.85, Low: 5.32, Close: 5.62 },
        { Open: 5.62, High: 5.62, Low: 4.44, Close: 4.84 },
        { Open: 4.84, High: 4.99, Low: 4.61, Close: 4.82 },
        { Open: 4.82, High: 4.93, Low: 4.7, Close: 4.77 },
        { Open: 4.77, High: 5.6, Low: 4.72, Close: 5.2 },
        { Open: 5.2, High: 5.64, Low: 4.9, Close: 5.46 },
        { Open: 5.46, High: 6.79, Low: 5.45, Close: 6.11 },
        { Open: 6.11, High: 6.29, Low: 5.06, Close: 5.61 },
        { Open: 5.61, High: 5.83, Low: 5.29, Close: 5.43 },
        { Open: 5.43, High: 5.71, Low: 5.41, Close: 5.55 },
        { Open: 5.55, High: 5.64, Low: 5.32, Close: 5.47 },
        { Open: 5.47, High: 5.49, Low: 5.32, Close: 5.33 },
        { Open: 5.33, High: 5.4, Low: 4.72, Close: 4.87 },
        { Open: 4.87, High: 5.13, Low: 4.78, Close: 4.92 },
        { Open: 4.92, High: 4.97, Low: 4.62, Close: 4.77 },
        { Open: 4.77, High: 4.8, Low: 4.67, Close: 4.78 },
        { Open: 4.78, High: 5.35, Low: 4.74, Close: 5.14 },
        { Open: 5.14, High: 5.25, Low: 4.86, Close: 5.03 },
        { Open: 5.03, High: 5.1, Low: 4.91, Close: 5.03 },
        { Open: 5.03, High: 5.04, Low: 4.89, Close: 5.02 },
        { Open: 5.02, High: 5.02, Low: 4.92, Close: 4.96 },
        { Open: 4.96, High: 5.02, Low: 4.83, Close: 4.87 },
        { Open: 4.87, High: 4.9, Low: 4.5, Close: 4.73 },
        { Open: 4.73, High: 4.8, Low: 3.78, Close: 4.27 },
        { Open: 4.27, High: 4.34, Low: 3.82, Close: 4.01 },
        { Open: 4.01, High: 4.39, Low: 4.01, Close: 4.1 },
        { Open: 4.1, High: 4.2, Low: 4.01, Close: 4.1 },
        { Open: 4.1, High: 4.1, Low: 3.85, Close: 3.93 },
        { Open: 3.93, High: 4.45, Low: 3.9, Close: 4.15 },
        { Open: 4.15, High: 4.2, Low: 4., Close: 4.05 },
        { Open: 4.05, High: 4.11, Low: 3.95, Close: 3.99 },
        { Open: 3.99, High: 4.05, Low: 3.71, Close: 3.84 },
        { Open: 3.84, High: 3.9, Low: 3.4, Close: 3.56 },
        { Open: 3.56, High: 3.74, Low: 2.26, Close: 2.56 },
        { Open: 2.56, High: 2.9, Low: 2.31, Close: 2.42 },
        { Open: 2.42, High: 2.54, Low: 2.04, Close: 2.27 },
        { Open: 2.27, High: 2.39, Low: 2.22, Close: 2.35 },
        { Open: 2.35, High: 2.72, Low: 2.33, Close: 2.57 },
        { Open: 2.57, High: 3.3, Low: 2.55, Close: 3.16 },
        { Open: 3.16, High: 3.2, Low: 2.95, Close: 3.17 },
        { Open: 3.17, High: 3.19, Low: 2.48, Close: 2.54 },
        { Open: 2.54, High: 3.04, Low: 2.44, Close: 2.77 },
        { Open: 2.77, High: 2.85, Low: 2.65, Close: 2.77 },
        { Open: 2.77, High: 3.09, Low: 2.73, Close: 3.04 },
        { Open: 3.04, High: 3.25, Low: 2.9, Close: 3.19 },
        { Open: 3.19, High: 3.83, Low: 3.14, Close: 3.58 },
        { Open: 3.58, High: 3.65, Low: 3.2, Close: 3.27 },
        { Open: 3.27, High: 3.32, Low: 3.07, Close: 3.25 },
        { Open: 3.25, High: 3.35, Low: 3.07, Close: 3.15 },
        { Open: 3.15, High: 3.44, Low: 3.14, Close: 3.25 },
        { Open: 3.25, High: 3.28, Low: 3.1, Close: 3.15 },
        { Open: 3.15, High: 3.21, Low: 3.01, Close: 3.11 },
        { Open: 3.11, High: 3.15, Low: 2.85, Close: 2.97 },
        { Open: 2.97, High: 3., Low: 2.92, Close: 2.96 },
        { Open: 2.96, High: 3.03, Low: 2.95, Close: 3.01 },
        { Open: 3.01, High: 3.21, Low: 3.01, Close: 3.03 },
        { Open: 3.03, High: 3.11, Low: 2.89, Close: 2.95 },
        { Open: 2.95, High: 2.97, Low: 2.8, Close: 2.84 },
        { Open: 2.84, High: 3.11, Low: 2.82, Close: 3.08 },
        { Open: 3.08, High: 3.11, Low: 3.01, Close: 3.03 },
        { Open: 3.03, High: 3.05, Low: 2.95, Close: 3. },
        { Open: 3., High: 3., Low: 2.1, Close: 2.22 },
        { Open: 2.22, High: 2.49, Low: 2.11, Close: 2.33 },
        { Open: 2.33, High: 2.6, Low: 2.3, Close: 2.56 },
        { Open: 2.56, High: 2.59, Low: 1.99, Close: 2.25 },
        { Open: 2.25, High: 2.39, Low: 2., Close: 2.05 },
        { Open: 2.05, High: 2.26, Low: 2., Close: 2.2 },
        { Open: 2.2, High: 2.5, Low: 2.15, Close: 2.2 },
        { Open: 2.2, High: 2.31, Low: 2.17, Close: 2.29 },
        { Open: 2.29, High: 2.35, Low: 2.25, Close: 2.33 },
        { Open: 2.33, High: 2.38, Low: 2.27, Close: 2.33 },
        { Open: 2.33, High: 2.56, Low: 2.31, Close: 2.43 },
        { Open: 2.43, High: 2.53, Low: 2.37, Close: 2.51 },
        { Open: 2.51, High: 2.53, Low: 2.41, Close: 2.47 },
        { Open: 2.47, High: 2.49, Low: 2.42, Close: 2.48 },
        { Open: 2.48, High: 2.55, Low: 2.44, Close: 2.55 },
        { Open: 2.55, High: 2.98, Low: 2.54, Close: 2.75 },
        { Open: 2.75, High: 3.09, Low: 2.73, Close: 2.97 },
        { Open: 2.97, High: 3.14, Low: 2.93, Close: 3.06 },
        { Open: 3.06, High: 3.14, Low: 3.03, Close: 3.12 },
        { Open: 3.12, High: 3.12, Low: 2.75, Close: 2.79 },
        { Open: 2.79, High: 2.9, Low: 2.61, Close: 2.83 },
        { Open: 2.83, High: 2.93, Low: 2.78, Close: 2.88 },
        { Open: 2.88, High: 3.05, Low: 2.87, Close: 3.03 },
        { Open: 3.03, High: 3.08, Low: 2.93, Close: 2.99 },
        { Open: 2.99, High: 3.01, Low: 2.88, Close: 2.98 },
        { Open: 2.98, High: 3.04, Low: 2.93, Close: 2.97 },
        { Open: 2.97, High: 3.13, Low: 2.93, Close: 3.05 },
        { Open: 3.05, High: 3.38, Low: 2.99, Close: 3.25 },
        { Open: 3.25, High: 3.29, Low: 3.08, Close: 3.13 },
        { Open: 3.13, High: 3.25, Low: 3.14, Close: 3.25 },
        { Open: 3.25, High: 3.25, Low: 2.99, Close: 3.15 },
        { Open: 3.15, High: 3.21, Low: 3.11, Close: 3.2 },
        { Open: 3.2, High: 3.22, Low: 3.15, Close: 3.2 },
        { Open: 3.2, High: 3.23, Low: 3.16, Close: 3.2 },
        { Open: 3.2, High: 3.22, Low: 3.18, Close: 3.19 },
        { Open: 3.19, High: 3.7, Low: 3.19, Close: 3.52 },
        { Open: 3.52, High: 4.5, Low: 3.48, Close: 3.95 },
        { Open: 3.95, High: 4.04, Low: 3.81, Close: 3.89 },
        { Open: 3.89, High: 3.99, Low: 3.51, Close: 3.89 },
        { Open: 3.89, High: 3.95, Low: 3.81, Close: 3.95 },
        { Open: 3.95, High: 3.97, Low: 3.85, Close: 3.94 },
        { Open: 3.94, High: 4.39, Low: 3.78, Close: 4.22 },
        { Open: 4.22, High: 4.31, Low: 3.81, Close: 4.02 },
        { Open: 4.02, High: 4.1, Low: 3.96, Close: 4.07 },
        { Open: 4.07, High: 4.25, Low: 3.99, Close: 4.19 },
        { Open: 4.19, High: 4.33, Low: 4.12, Close: 4.17 },
        { Open: 4.17, High: 4.3, Low: 4.06, Close: 4.25 },
        { Open: 4.25, High: 4.99, Low: 4.2, Close: 4.72 },
        { Open: 4.72, High: 5.5, Low: 4.61, Close: 5.27 },
        { Open: 5.27, High: 5.47, Low: 4.8, Close: 5.22 },
        { Open: 5.22, High: 5.29, Low: 4.65, Close: 4.88 },
        { Open: 4.88, High: 5.7, Low: 4.75, Close: 5.57 },
        { Open: 5.57, High: 7.22, Low: 5.57, Close: 6.95 },
        { Open: 6.95, High: 7.21, Low: 6.13, Close: 6.7 },
        { Open: 6.7, High: 7.02, Low: 6.38, Close: 6.81 },
        { Open: 6.81, High: 7.2, Low: 6.73, Close: 7.11 },
        { Open: 7.11, High: 7.19, Low: 5.81, Close: 6.33 },
        { Open: 6.33, High: 6.89, Low: 6., Close: 6.36 },
        { Open: 6.36, High: 7.14, Low: 6.41, Close: 6.9 },
        { Open: 6.9, High: 7., Low: 6.34, Close: 6.8 },
        { Open: 6.8, High: 6.8, Low: 6.4, Close: 6.41 },
        { Open: 6.41, High: 6.95, Low: 6.22, Close: 6.75 },
        { Open: 6.75, High: 7.08, Low: 6.74, Close: 7. },
        { Open: 7., High: 7.19, Low: 6.51, Close: 6.68 },
        { Open: 6.68, High: 6.95, Low: 4.64, Close: 5.6 },
        { Open: 5.6, High: 6.95, Low: 5.1, Close: 5.92 },
        { Open: 5.92, High: 6.36, Low: 5.87, Close: 6.36 },
        { Open: 6.36, High: 6.58, Low: 6.26, Close: 6.49 },
        { Open: 6.49, High: 6.55, Low: 6.1, Close: 6.18 },
        { Open: 6.18, High: 6.45, Low: 6.1, Close: 6.31 },
        { Open: 6.31, High: 6.39, Low: 6.21, Close: 6.36 },
        { Open: 6.36, High: 6.39, Low: 6.22, Close: 6.29 },
        { Open: 6.29, High: 6.32, Low: 5.5, Close: 5.75 },
        { Open: 5.75, High: 5.92, Low: 5.3, Close: 5.34 },
        { Open: 5.34, High: 5.51, Low: 5.05, Close: 5.29 },
        { Open: 5.29, High: 5.76, Low: 5.26, Close: 5.63 },
        { Open: 5.63, High: 5.7, Low: 5.33, Close: 5.38 },
        { Open: 5.38, High: 5.6, Low: 5.37, Close: 5.49 },
        { Open: 5.49, High: 5.65, Low: 5.43, Close: 5.48 },
        { Open: 5.48, High: 6.2, Low: 5.47, Close: 6.08 },
        { Open: 6.08, High: 6.2, Low: 5.82, Close: 6.1 },
        { Open: 6.1, High: 6.14, Low: 5.72, Close: 5.96 },
        { Open: 5.96, High: 5.99, Low: 5.84, Close: 5.87 },
        { Open: 5.87, High: 5.88, Low: 5.45, Close: 5.69 },
        { Open: 5.69, High: 5.72, Low: 5.45, Close: 5.45 },
        { Open: 5.45, High: 5.78, Low: 5.45, Close: 5.69 },
        { Open: 5.69, High: 5.85, Low: 5.3, Close: 5.6 },
        { Open: 5.6, High: 5.91, Low: 5.5, Close: 5.83 },
        { Open: 5.83, High: 5.98, Low: 5.8, Close: 5.91 },
        { Open: 5.91, High: 6., Low: 5.54, Close: 5.6 },
        { Open: 5.6, High: 5.85, Low: 5.43, Close: 5.51 },
        { Open: 5.51, High: 5.72, Low: 5.2, Close: 5.26 },
        { Open: 5.26, High: 5.45, Low: 4.21, Close: 4.46 },
        { Open: 4.46, High: 4.88, Low: 4.2, Close: 4.33 },
        { Open: 4.33, High: 4.44, Low: 3.88, Close: 4.27 },
        { Open: 4.27, High: 4.77, Low: 4.23, Close: 4.41 },
        { Open: 4.41, High: 4.5, Low: 4.12, Close: 4.22 },
        { Open: 4.22, High: 4.52, Low: 4.18, Close: 4.39 },
        { Open: 4.39, High: 4.47, Low: 4.29, Close: 4.36 },
        { Open: 4.36, High: 4.4, Low: 4.21, Close: 4.27 },
        { Open: 4.27, High: 4.54, Low: 4.27, Close: 4.42 },
        { Open: 4.42, High: 5.2, Low: 4.42, Close: 5.01 },
        { Open: 5.01, High: 5.1, Low: 4.82, Close: 5.03 },
        { Open: 5.03, High: 5.07, Low: 4.65, Close: 4.77 },
        { Open: 4.77, High: 5.1, Low: 4.77, Close: 4.92 },
        { Open: 4.92, High: 4.99, Low: 4.89, Close: 4.96 },
        { Open: 4.96, High: 5., Low: 4.73, Close: 4.87 },
        { Open: 4.87, High: 4.9, Low: 4.8, Close: 4.86 },
        { Open: 4.86, High: 4.99, Low: 4.86, Close: 4.92 },
        { Open: 4.92, High: 4.95, Low: 4.51, Close: 4.7 },
        { Open: 4.7, High: 4.78, Low: 4.51, Close: 4.61 },
        { Open: 4.61, High: 4.95, Low: 4.61, Close: 4.82 },
        { Open: 4.82, High: 5.05, Low: 4.82, Close: 4.98 },
        { Open: 4.98, High: 5.07, Low: 4.9, Close: 4.99 },
        { Open: 4.99, High: 5.05, Low: 4.84, Close: 4.94 },
        { Open: 4.94, High: 5., Low: 4.76, Close: 4.93 },
        { Open: 4.93, High: 4.95, Low: 4.82, Close: 4.86 },
        { Open: 4.86, High: 4.91, Low: 4.75, Close: 4.83 },
        { Open: 4.83, High: 4.99, Low: 4.81, Close: 4.91 },
        { Open: 4.91, High: 4.95, Low: 4.86, Close: 4.89 },
        { Open: 4.89, High: 5.41, Low: 4.87, Close: 5.27 },
        { Open: 5.27, High: 5.45, Low: 5.25, Close: 5.38 },
        { Open: 5.38, High: 5.44, Low: 5.25, Close: 5.33 },
        { Open: 5.33, High: 5.4, Low: 5.3, Close: 5.34 },
        { Open: 5.34, High: 5.4, Low: 5.21, Close: 5.22 },
        { Open: 5.22, High: 5.34, Low: 5.21, Close: 5.28 },
        { Open: 5.28, High: 5.31, Low: 4.5, Close: 4.69 },
        { Open: 4.69, High: 4.9, Low: 4.59, Close: 4.84 },
        { Open: 4.84, High: 4.87, Low: 4.75, Close: 4.81 },
        { Open: 4.81, High: 4.88, Low: 4.6, Close: 4.7 },
        { Open: 4.7, High: 4.79, Low: 4.6, Close: 4.69 },
        { Open: 4.69, High: 4.73, Low: 4.6, Close: 4.68 },
        { Open: 4.68, High: 4.68, Low: 4.3, Close: 4.55 },
        { Open: 4.55, High: 4.74, Low: 4.52, Close: 4.62 },
        { Open: 4.62, High: 4.85, Low: 4.49, Close: 4.81 },
        { Open: 4.81, High: 4.84, Low: 4.72, Close: 4.79 },
        { Open: 4.79, High: 4.86, Low: 4.71, Close: 4.81 },
        { Open: 4.81, High: 4.88, Low: 4.72, Close: 4.86 },
        { Open: 4.86, High: 4.95, Low: 4.82, Close: 4.91 },
        { Open: 4.91, High: 4.92, Low: 4.73, Close: 4.83 },
        { Open: 4.83, High: 5.08, Low: 4.76, Close: 4.97 },
        { Open: 4.97, High: 4.99, Low: 4.81, Close: 4.95 },
        { Open: 4.95, High: 4.97, Low: 4.89, Close: 4.91 },
        { Open: 4.91, High: 4.93, Low: 4.87, Close: 4.92 },
        { Open: 4.92, High: 4.98, Low: 4.88, Close: 4.95 },
        { Open: 4.95, High: 4.95, Low: 4.69, Close: 4.69 },
        { Open: 4.69, High: 4.8, Low: 4.62, Close: 4.79 },
        { Open: 4.79, High: 4.88, Low: 4.73, Close: 4.87 },
        { Open: 4.87, High: 4.9, Low: 4.76, Close: 4.84 },
        { Open: 4.84, High: 4.98, Low: 4.79, Close: 4.93 },
        { Open: 4.93, High: 4.95, Low: 4.84, Close: 4.92 },
        { Open: 4.92, High: 4.94, Low: 4.73, Close: 4.94 },
        { Open: 4.94, High: 5.03, Low: 4.9, Close: 4.96 },
        { Open: 4.96, High: 4.98, Low: 4.86, Close: 4.97 },
        { Open: 4.97, High: 4.98, Low: 4.91, Close: 4.93 },
        { Open: 4.93, High: 5.02, Low: 4.92, Close: 4.98 },
        { Open: 4.98, High: 5.18, Low: 4.96, Close: 5.12 },
        { Open: 5.12, High: 5.19, Low: 5.1, Close: 5.14 },
        { Open: 5.14, High: 5.48, Low: 5.1, Close: 5.35 },
        { Open: 5.35, High: 5.48, Low: 5.11, Close: 5.26 },
        { Open: 5.26, High: 5.32, Low: 5.1, Close: 5.2 },
        { Open: 5.2, High: 5.22, Low: 4.96, Close: 4.96 },
        { Open: 4.96, High: 5.2, Low: 4.95, Close: 5.1 },
        { Open: 5.1, High: 5.18, Low: 5.04, Close: 5.13 },
        { Open: 5.13, High: 5.17, Low: 4.99, Close: 5.1 },
        { Open: 5.1, High: 5.12, Low: 5.03, Close: 5.11 },
        { Open: 5.11, High: 5.11, Low: 4.85, Close: 4.98 },
        { Open: 4.98, High: 5.02, Low: 4.88, Close: 4.9 },
        { Open: 4.9, High: 5., Low: 4.87, Close: 4.95 },
        { Open: 4.95, High: 5., Low: 4.92, Close: 5. },
        { Open: 5., High: 5.18, Low: 4.97, Close: 5.07 },
        { Open: 5.07, High: 5.18, Low: 5.02, Close: 5.13 },
        { Open: 5.13, High: 5.15, Low: 5.07, Close: 5.07 },
        { Open: 5.07, High: 5.12, Low: 5.03, Close: 5.08 },
        { Open: 5.08, High: 5.1, Low: 5.01, Close: 5.05 },
        { Open: 5.05, High: 5.1, Low: 4.97, Close: 5.06 },
        { Open: 5.06, High: 5.1, Low: 4.96, Close: 5.05 },
        { Open: 5.05, High: 5.1, Low: 5., Close: 5.04 },
        { Open: 5.04, High: 5.12, Low: 4.8, Close: 4.85 },
        { Open: 4.85, High: 5., Low: 4.8, Close: 4.96 },
        { Open: 4.96, High: 5., Low: 4.91, Close: 4.95 },
        { Open: 4.95, High: 5., Low: 4.92, Close: 4.93 },
        { Open: 4.93, High: 5.04, Low: 4.9, Close: 5.01 },
        { Open: 5.01, High: 5.04, Low: 4.95, Close: 5.03 },
        { Open: 5.03, High: 5.13, Low: 5., Close: 5.09 },
        { Open: 5.09, High: 5.1, Low: 5.05, Close: 5.1 },
        { Open: 5.1, High: 5.13, Low: 5.06, Close: 5.12 },
        { Open: 5.12, High: 5.14, Low: 5.07, Close: 5.1 },
        { Open: 5.1, High: 5.15, Low: 5.09, Close: 5.09 },
        { Open: 5.09, High: 5.13, Low: 5.06, Close: 5.1 },
        { Open: 5.1, High: 5.11, Low: 5.05, Close: 5.1 },
        { Open: 5.1, High: 5.16, Low: 5.06, Close: 5.14 },
        { Open: 5.14, High: 5.15, Low: 5.07, Close: 5.12 },
        { Open: 5.12, High: 5.15, Low: 5.1, Close: 5.15 },
        { Open: 5.15, High: 5.14, Low: 5.1, Close: 5.1 },
        { Open: 5.1, High: 5.15, Low: 5.1, Close: 5.14 },
        { Open: 5.14, High: 5.16, Low: 5.11, Close: 5.14 },
        { Open: 5.14, High: 5.16, Low: 5.01, Close: 5.15 },
        { Open: 5.15, High: 5.17, Low: 5.1, Close: 5.13 },
        { Open: 5.13, High: 5.2, Low: 5.11, Close: 5.18 },
        { Open: 5.18, High: 5.28, Low: 5.18, Close: 5.27 },
        { Open: 5.27, High: 5.27, Low: 5.21, Close: 5.25 },
        { Open: 5.25, High: 5.25, Low: 5.21, Close: 5.21 },
        { Open: 5.21, High: 5.28, Low: 5.18, Close: 5.27 },
        { Open: 5.27, High: 5.5, Low: 5.22, Close: 5.44 },
        { Open: 5.44, High: 5.49, Low: 5.39, Close: 5.46 },
        { Open: 5.46, High: 5.59, Low: 5.41, Close: 5.59 },
        { Open: 5.59, High: 5.66, Low: 5.56, Close: 5.63 },
        { Open: 5.63, High: 5.7, Low: 5.46, Close: 5.56 },
        { Open: 5.56, High: 5.58, Low: 5.43, Close: 5.47 },
        { Open: 5.47, High: 5.6, Low: 5.43, Close: 5.57 },
        { Open: 5.57, High: 5.75, Low: 5.5, Close: 5.7 },
        { Open: 5.7, High: 5.96, Low: 5.66, Close: 5.93 },
        { Open: 5.93, High: 5.97, Low: 5.81, Close: 5.95 },
        { Open: 5.95, High: 6.59, Low: 5.88, Close: 6.5 },
        { Open: 6.5, High: 6.6, Low: 6.26, Close: 6.4 },
        { Open: 6.4, High: 6.53, Low: 6.1, Close: 6.16 },
        { Open: 6.16, High: 6.36, Low: 6.03, Close: 6.31 },
        { Open: 6.31, High: 6.53, Low: 6.28, Close: 6.5 },
        { Open: 6.5, High: 6.71, Low: 6.45, Close: 6.67 },
        { Open: 6.67, High: 6.8, Low: 6.56, Close: 6.68 },
        { Open: 6.68, High: 6.8, Low: 6.43, Close: 6.55 },
        { Open: 6.55, High: 6.65, Low: 6.4, Close: 6.43 },
        { Open: 6.43, High: 6.47, Low: 6.35, Close: 6.35 },
        { Open: 6.35, High: 6.45, Low: 6.22, Close: 6.3 },
        { Open: 6.3, High: 6.47, Low: 6.29, Close: 6.42 },
        { Open: 6.42, High: 6.65, Low: 6.4, Close: 6.65 },
        { Open: 6.65, High: 6.67, Low: 6.49, Close: 6.61 },
        { Open: 6.61, High: 6.68, Low: 6.54, Close: 6.65 },
        { Open: 6.65, High: 6.69, Low: 6.6, Close: 6.69 },
        { Open: 6.69, High: 6.69, Low: 6.54, Close: 6.63 },
        { Open: 6.63, High: 6.76, Low: 6.58, Close: 6.76 },
        { Open: 6.76, High: 6.76, Low: 6.4, Close: 6.45 },
        { Open: 6.45, High: 6.55, Low: 6.45, Close: 6.51 },
        { Open: 6.51, High: 6.77, Low: 6.48, Close: 6.67 },
        { Open: 6.67, High: 6.72, Low: 6.55, Close: 6.65 },
        { Open: 6.65, High: 6.87, Low: 6.63, Close: 6.76 },
        { Open: 6.76, High: 6.86, Low: 6.72, Close: 6.8 },
        { Open: 6.8, High: 7.1, Low: 6.74, Close: 7.02 },
        { Open: 7.02, High: 7.25, Low: 6.96, Close: 7.2 },
        { Open: 7.2, High: 7.26, Low: 7.02, Close: 7.15 },
        { Open: 7.15, High: 7.9, Low: 7.1, Close: 7.76 },
        { Open: 7.76, High: 7.82, Low: 7.42, Close: 7.67 },
        { Open: 7.67, High: 7.66, Low: 7.52, Close: 7.54 },
        { Open: 7.54, High: 7.7, Low: 7.45, Close: 7.62 },
        { Open: 7.62, High: 8.65, Low: 7.62, Close: 8.5 },
        { Open: 8.5, High: 9.49, Low: 7.32, Close: 8.8 },
        { Open: 8.8, High: 9.4, Low: 8.5, Close: 9.11 },
        { Open: 9.11, High: 9.23, Low: 8.82, Close: 8.87 },
        { Open: 8.87, High: 8.87, Low: 7.6, Close: 8.52 },
        { Open: 8.52, High: 9.7, Low: 7.96, Close: 8.85 },
        { Open: 8.85, High: 8.97, Low: 8.27, Close: 8.41 },
        { Open: 8.41, High: 9.2, Low: 7.75, Close: 8.45 },
        { Open: 8.45, High: 8.85, Low: 8.34, Close: 8.6 },
        { Open: 8.6, High: 8.9, Low: 8.37, Close: 8.8 },
        { Open: 8.8, High: 8.9, Low: 8.6, Close: 8.9 },
        { Open: 8.9, High: 8.95, Low: 8.81, Close: 8.9 },
        { Open: 8.9, High: 8.93, Low: 8.71, Close: 8.89 },
        { Open: 8.89, High: 8.89, Low: 8.7, Close: 8.71 },
        { Open: 8.71, High: 9.15, Low: 8.7, Close: 9.1 },
        { Open: 9.1, High: 9.44, Low: 9.08, Close: 9.35 },
        { Open: 9.35, High: 9.65, Low: 9.11, Close: 9.55 },
        { Open: 9.55, High: 11., Low: 9.41, Close: 10.53 },
        { Open: 10.53, High: 11.12, Low: 10.3, Close: 10.97 },
        { Open: 10.97, High: 11.3, Low: 10.53, Close: 10.98 },
        { Open: 10.98, High: 11.29, Low: 10.11, Close: 10.87 },
        { Open: 10.87, High: 11.19, Low: 10.64, Close: 10.86 },
        { Open: 10.86, High: 11.1, Low: 10.65, Close: 11.1 },
        { Open: 11.1, High: 11.15, Low: 10.85, Close: 11.06 },
        { Open: 11.06, High: 12., Low: 10.8, Close: 11.06 },
        { Open: 11.06, High: 11.6, Low: 11.01, Close: 11.39 },
        { Open: 11.39, High: 11.6, Low: 11.39, Close: 11.51 },
        { Open: 11.51, High: 11.76, Low: 11.45, Close: 11.62 },
        { Open: 11.62, High: 12.05, Low: 11.49, Close: 12.04 },
        { Open: 12.04, High: 12.34, Low: 11.89, Close: 12.19 },
        { Open: 12.19, High: 13.25, Low: 12.16, Close: 13.25 },
        { Open: 13.25, High: 13.84, Low: 12.5, Close: 13.5 },
        { Open: 13.5, High: 15.4, Low: 10.6, Close: 11.58 },
        { Open: 11.58, High: 12.9, Low: 11.02, Close: 11.61 },
        { Open: 11.61, High: 11.62, Low: 7.58, Close: 8. },
        { Open: 8., High: 10.5, Low: 7.81, Close: 10.1 },
        { Open: 10.1, High: 10.3, Low: 9.7, Close: 9.91 },
        { Open: 9.91, High: 10.1, Low: 9.57, Close: 9.81 },
        { Open: 9.81, High: 10.25, Low: 9.7, Close: 10.1 },
        { Open: 10.1, High: 10.62, Low: 9.85, Close: 10.6 },
        { Open: 10.6, High: 10.63, Low: 10.2, Close: 10.52 },
        { Open: 10.52, High: 10.62, Low: 10.45, Close: 10.61 },
        { Open: 10.61, High: 12.15, Low: 10.54, Close: 10.95 },
        { Open: 10.95, High: 11.21, Low: 10.5, Close: 10.94 },
        { Open: 10.94, High: 11.13, Low: 10.55, Close: 10.92 },
        { Open: 10.92, High: 10.93, Low: 10.6, Close: 10.78 },
        { Open: 10.78, High: 10.83, Low: 9.66, Close: 10.16 },
        { Open: 10.16, High: 10.3, Low: 9.78, Close: 9.97 },
        { Open: 9.97, High: 10.36, Low: 9.72, Close: 10.2 },
        { Open: 10.2, High: 10.59, Low: 10.09, Close: 10.53 },
        { Open: 10.53, High: 10.53, Low: 10.15, Close: 10.38 },
        { Open: 10.38, High: 11.17, Low: 10.26, Close: 11. },
        { Open: 11., High: 11.29, Low: 10.64, Close: 11.18 },
        { Open: 11.18, High: 11.21, Low: 10.95, Close: 11. },
        { Open: 11., High: 11.14, Low: 10.76, Close: 11.04 },
        { Open: 11.04, High: 11.14, Low: 10.92, Close: 11.02 },
        { Open: 11.02, High: 11.19, Low: 10.87, Close: 11.17 },
        { Open: 11.17, High: 11.35, Low: 10.88, Close: 11.33 },
        { Open: 11.33, High: 11.39, Low: 10.78, Close: 11.36 },
        { Open: 11.36, High: 11.4, Low: 11.22, Close: 11.4 },
        { Open: 11.4, High: 11.8, Low: 11.32, Close: 11.67 },
        { Open: 11.67, High: 11.79, Low: 11.6, Close: 11.75 },
        { Open: 11.75, High: 11.99, Low: 11.72, Close: 11.87 },
        { Open: 11.87, High: 11.96, Low: 11.77, Close: 11.89 },
        { Open: 11.89, High: 12.35, Low: 11.84, Close: 12.25 },
        { Open: 12.25, High: 12.69, Low: 12.15, Close: 12.57 },
        { Open: 12.57, High: 12.66, Low: 12.25, Close: 12.28 },
        { Open: 12.28, High: 12.5, Low: 12.01, Close: 12.37 },
        { Open: 12.37, High: 12.4, Low: 12.14, Close: 12.24 },
        { Open: 12.24, High: 12.27, Low: 11.63, Close: 12.19 },
        { Open: 12.19, High: 12.3, Low: 11.95, Close: 12.1 },
        { Open: 12.1, High: 12.23, Low: 12.01, Close: 12.2 },
        { Open: 12.2, High: 12.46, Low: 12.02, Close: 12.27 },
        { Open: 12.27, High: 12.39, Low: 12.21, Close: 12.31 },
        { Open: 12.31, High: 12.45, Low: 12.12, Close: 12.39 },
        { Open: 12.39, High: 12.49, Low: 12.21, Close: 12.36 },
        { Open: 12.36, High: 12.45, Low: 12.3, Close: 12.4 },
        { Open: 12.4, High: 12.48, Low: 12.32, Close: 12.4 },
        { Open: 12.4, High: 12.88, Low: 12.34, Close: 12.84 },
        { Open: 12.84, High: 12.99, Low: 12.68, Close: 12.89 },
        { Open: 12.89, High: 13.09, Low: 12.6, Close: 12.85 },
        { Open: 12.85, High: 12.97, Low: 12.51, Close: 12.69 },
        { Open: 12.69, High: 12.86, Low: 12.35, Close: 12.5 },
        { Open: 12.5, High: 12.62, Low: 11.7, Close: 11.8 },
        { Open: 11.8, High: 11.95, Low: 10.62, Close: 11.78 },
        { Open: 11.78, High: 12.35, Low: 11.57, Close: 11.89 },
        { Open: 11.89, High: 12.19, Low: 11.77, Close: 12.12 },
        { Open: 12.12, High: 12.15, Low: 11.86, Close: 12.03 },
        { Open: 12.03, High: 12.15, Low: 11.92, Close: 12. },
        { Open: 12., High: 12.11, Low: 11.85, Close: 11.86 },
        { Open: 11.86, High: 12.03, Low: 11.5, Close: 11.74 },
        { Open: 11.74, High: 11.99, Low: 11.43, Close: 11.84 },
        { Open: 11.84, High: 11.99, Low: 11.5, Close: 11.85 },
        { Open: 11.85, High: 11.96, Low: 11.7, Close: 11.81 },
        { Open: 11.81, High: 11.96, Low: 11.75, Close: 11.94 },
        { Open: 11.94, High: 11.97, Low: 11.62, Close: 11.74 },
        { Open: 11.74, High: 11.85, Low: 11.56, Close: 11.74 },
        { Open: 11.74, High: 11.77, Low: 11.61, Close: 11.63 },
        { Open: 11.63, High: 11.81, Low: 11.47, Close: 11.71 },
        { Open: 11.71, High: 12., Low: 11.41, Close: 11.65 },
        { Open: 11.65, High: 11.79, Low: 11.59, Close: 11.65 },
        { Open: 11.65, High: 11.7, Low: 10.52, Close: 10.86 },
        { Open: 10.86, High: 10.95, Low: 9.74, Close: 10.17 },
        { Open: 10.17, High: 10.84, Low: 9.82, Close: 10.26 },
        { Open: 10.26, High: 10.95, Low: 10.25, Close: 10.7 },
        { Open: 10.7, High: 10.94, Low: 10.32, Close: 10.6 },
        { Open: 10.6, High: 10.89, Low: 10.58, Close: 10.89 },
        { Open: 10.89, High: 11.21, Low: 10.71, Close: 11.2 },
        { Open: 11.2, High: 11.28, Low: 10.4, Close: 10.57 },
        { Open: 10.57, High: 10.8, Low: 10.33, Close: 10.47 },
        { Open: 10.47, High: 10.65, Low: 10.4, Close: 10.64 },
        { Open: 10.64, High: 10.9, Low: 10.51, Close: 10.8 },
        { Open: 10.8, High: 10.88, Low: 10.61, Close: 10.75 },
        { Open: 10.75, High: 10.9, Low: 10.67, Close: 10.9 },
        { Open: 10.9, High: 11.22, Low: 10.8, Close: 10.92 },
        { Open: 10.92, High: 11.07, Low: 10.75, Close: 10.92 },
        { Open: 10.92, High: 10.98, Low: 10.79, Close: 10.81 },
        { Open: 10.81, High: 10.96, Low: 10.75, Close: 10.89 },
        { Open: 10.89, High: 10.94, Low: 10.7, Close: 10.87 },
        { Open: 10.87, High: 11.18, Low: 10.77, Close: 11.01 },
        { Open: 11.01, High: 11.13, Low: 10.92, Close: 10.95 },
        { Open: 10.95, High: 11.05, Low: 10.82, Close: 10.95 },
        { Open: 10.95, High: 11.3, Low: 10.86, Close: 11.2 },
        { Open: 11.2, High: 11.8, Low: 11.17, Close: 11.75 },
        { Open: 11.75, High: 11.8, Low: 11.52, Close: 11.79 },
        { Open: 11.79, High: 11.83, Low: 11.62, Close: 11.65 },
        { Open: 11.65, High: 11.84, Low: 11.6, Close: 11.8 },
        { Open: 11.8, High: 11.8, Low: 11.57, Close: 11.73 },
        { Open: 11.73, High: 11.78, Low: 11.64, Close: 11.77 },
        { Open: 11.77, High: 12.43, Low: 11.67, Close: 12.42 },
        { Open: 12.42, High: 12.41, Low: 12.13, Close: 12.34 },
        { Open: 12.34, High: 12.48, Low: 12.25, Close: 12.41 },
        { Open: 12.41, High: 12.6, Low: 12.31, Close: 12.48 },
        { Open: 12.48, High: 12.65, Low: 11.89, Close: 12.25 },
        { Open: 12.25, High: 12.34, Low: 11.9, Close: 12.2 },
        { Open: 12.2, High: 12.41, Low: 12.1, Close: 12.35 },
        { Open: 12.35, High: 12.6, Low: 12.15, Close: 12.45 },
        { Open: 12.45, High: 12.65, Low: 12.42, Close: 12.56 },
        { Open: 12.56, High: 12.69, Low: 12.46, Close: 12.56 },
        { Open: 12.56, High: 12.68, Low: 12.43, Close: 12.5 },
        { Open: 12.5, High: 12.68, Low: 12.48, Close: 12.68 },
        { Open: 12.68, High: 13.5, Low: 12.62, Close: 13.41 },
        { Open: 13.41, High: 13.42, Low: 13.15, Close: 13.38 },
        { Open: 13.38, High: 13.69, Low: 12.9, Close: 13.3 },
        { Open: 13.3, High: 13.55, Low: 12.97, Close: 13.5 },
        { Open: 13.5, High: 13.55, Low: 13.35, Close: 13.42 },
        { Open: 13.42, High: 13.53, Low: 13.02, Close: 13.39 },
        { Open: 13.39, High: 13.55, Low: 13.27, Close: 13.43 },
        { Open: 13.43, High: 13.67, Low: 13.3, Close: 13.56 },
        { Open: 13.56, High: 13.8, Low: 13.3, Close: 13.7 },
        { Open: 13.7, High: 13.8, Low: 13.47, Close: 13.7 },
        { Open: 13.7, High: 13.9, Low: 13., Close: 13.6 },
        { Open: 13.6, High: 13.64, Low: 13.44, Close: 13.49 },
        { Open: 13.49, High: 13.67, Low: 13.13, Close: 13.3 },
        { Open: 13.3, High: 13.48, Low: 12.75, Close: 13.25 },
        { Open: 13.25, High: 13.4, Low: 13.11, Close: 13.3 },
        { Open: 13.3, High: 13.6, Low: 13.2, Close: 13.6 },
        { Open: 13.6, High: 13.72, Low: 13.33, Close: 13.52 },
        { Open: 13.52, High: 13.6, Low: 13.42, Close: 13.5 },
        { Open: 13.5, High: 13.59, Low: 13.32, Close: 13.37 },
        { Open: 13.37, High: 13.47, Low: 13.01, Close: 13.31 },
        { Open: 13.31, High: 13.45, Low: 13.21, Close: 13.38 },
        { Open: 13.38, High: 13.43, Low: 13.14, Close: 13.35 },
        { Open: 13.35, High: 13.47, Low: 13.2, Close: 13.47 },
        { Open: 13.47, High: 13.47, Low: 13.25, Close: 13.42 },
        { Open: 13.42, High: 13.65, Low: 13.34, Close: 13.42 },
        { Open: 13.42, High: 13.67, Low: 13.27, Close: 13.4 },
        { Open: 13.4, High: 13.59, Low: 13.35, Close: 13.45 },
        { Open: 13.45, High: 13.56, Low: 13.37, Close: 13.51 },
        { Open: 13.51, High: 13.56, Low: 13.16, Close: 13.3 },
        { Open: 13.3, High: 13.4, Low: 13.16, Close: 13.28 },
        { Open: 13.28, High: 13.46, Low: 13.25, Close: 13.4 },
        { Open: 13.4, High: 13.52, Low: 13.27, Close: 13.5 },
        { Open: 13.5, High: 13.55, Low: 13.31, Close: 13.44 },
        { Open: 13.44, High: 13.52, Low: 13.36, Close: 13.45 },
        { Open: 13.45, High: 13.59, Low: 13.4, Close: 13.59 },
        { Open: 13.59, High: 13.88, Low: 13.5, Close: 13.74 },
        { Open: 13.74, High: 13.86, Low: 13.62, Close: 13.77 },
        { Open: 13.77, High: 14.32, Low: 13.77, Close: 14.14 },
        { Open: 14.14, High: 14.35, Low: 13.91, Close: 14.14 },
        { Open: 14.14, High: 14.34, Low: 13.97, Close: 14.24 },
        { Open: 14.24, High: 14.31, Low: 13.95, Close: 14.12 },
        { Open: 14.12, High: 14.35, Low: 14.11, Close: 14.3 },
        { Open: 14.3, High: 14.48, Low: 13.99, Close: 14.25 },
        { Open: 14.25, High: 14.73, Low: 14.21, Close: 14.73 },
        { Open: 14.73, High: 15.7, Low: 14.63, Close: 15.5 },
        { Open: 15.5, High: 15.98, Low: 15.41, Close: 15.7 },
        { Open: 15.7, High: 15.77, Low: 15.25, Close: 15.61 },
        { Open: 15.61, High: 15.89, Low: 15.51, Close: 15.7 },
        { Open: 15.7, High: 16.98, Low: 15.63, Close: 16.8 },
        { Open: 16.8, High: 17.59, Low: 16.65, Close: 17.26 },
        { Open: 17.26, High: 17.59, Low: 16.8, Close: 17.5 },
        { Open: 17.5, High: 19.19, Low: 15.61, Close: 16.9 },
        { Open: 16.9, High: 17.8, Low: 15.39, Close: 17.4 },
        { Open: 17.4, High: 17.88, Low: 16.54, Close: 17.88 },
        { Open: 17.88, High: 18., Low: 17.21, Close: 17.82 },
        { Open: 17.82, High: 18.88, Low: 17.75, Close: 18.72 },
        { Open: 18.72, High: 19.8, Low: 18.7, Close: 19.53 },
        { Open: 19.53, High: 19.8, Low: 19.15, Close: 19.7 },
        { Open: 19.7, High: 21.43, Low: 19.51, Close: 20.41 },
        { Open: 20.41, High: 21.13, Low: 20.3, Close: 20.5 },
        { Open: 20.5, High: 20.5, Low: 18., Close: 19.63 },
        { Open: 19.63, High: 20.9, Low: 19.42, Close: 20.59 },
        { Open: 20.59, High: 21.05, Low: 19.85, Close: 20.43 },
        { Open: 20.43, High: 20.79, Low: 20.2, Close: 20.6 },
        { Open: 20.6, High: 21.33, Low: 20.6, Close: 21.18 },
        { Open: 21.18, High: 22.22, Low: 20.77, Close: 22.15 },
        { Open: 22.15, High: 22.77, Low: 22., Close: 22.66 },
        { Open: 22.66, High: 23.99, Low: 22.58, Close: 23.65 },
        { Open: 23.65, High: 24.11, Low: 22.67, Close: 23.97 },
        { Open: 23.97, High: 24.67, Low: 23.65, Close: 24.65 },
        { Open: 24.65, High: 25.83, Low: 24.3, Close: 25.17 },
        { Open: 25.17, High: 26.3, Low: 24.19, Close: 24.2 },
        { Open: 24.2, High: 27.6, Low: 21.72, Close: 27.22 },
        { Open: 27.22, High: 27.51, Low: 26.1, Close: 27.1 },
        { Open: 27.1, High: 27.5, Low: 26.81, Close: 27.22 },
        { Open: 27.22, High: 27.4, Low: 25., Close: 26.81 },
        { Open: 26.81, High: 27.15, Low: 26.36, Close: 26.95 },
        { Open: 26.95, High: 29.65, Low: 26.8, Close: 29.42 },
        { Open: 29.42, High: 29.87, Low: 28.99, Close: 29.64 },
        { Open: 29.64, High: 29.98, Low: 29.31, Close: 29.75 },
        { Open: 29.75, High: 31.3, Low: 29.67, Close: 30.25 },
        { Open: 30.25, High: 30.69, Low: 28., Close: 29.8 },
        { Open: 29.8, High: 30.4, Low: 29.2, Close: 29.89 },
        { Open: 29.89, High: 30.4, Low: 29.55, Close: 30.4 },
        { Open: 30.4, High: 31.7, Low: 30.12, Close: 31.1 },
        { Open: 31.1, High: 31.65, Low: 30.79, Close: 30.9 },
        { Open: 30.9, High: 34.52, Low: 30.9, Close: 33.38 },
        { Open: 33.38, High: 34.9, Low: 32.92, Close: 34.5 },
        { Open: 34.5, High: 34.81, Low: 33.15, Close: 34.25 },
        { Open: 34.25, High: 34.5, Low: 33.8, Close: 34.5 },
        { Open: 34.5, High: 36.7, Low: 34.19, Close: 36.15 },
        { Open: 36.15, High: 40.65, Low: 36.15, Close: 40.33 },
        { Open: 40.33, High: 49.1, Low: 40.14, Close: 41.02 },
        { Open: 41.02, High: 45.5, Low: 33.3, Close: 42. },
        { Open: 42., High: 44.5, Low: 41.02, Close: 44.18 },
        { Open: 44.18, High: 46.99, Low: 43.41, Close: 46.85 },
        { Open: 46.85, High: 47.95, Low: 45.47, Close: 46. },
        { Open: 46., High: 48.47, Low: 45.54, Close: 48.4 },
        { Open: 48.4, High: 48.4, Low: 36.65, Close: 44.29 },
        { Open: 44.29, High: 47.29, Low: 43.75, Close: 46.92 },
        { Open: 46.92, High: 47.99, Low: 46.05, Close: 47.17 },
        { Open: 47.17, High: 47.45, Low: 46.4, Close: 46.95 },
        { Open: 46.95, High: 47.36, Low: 46.27, Close: 47. },
        { Open: 47., High: 47.74, Low: 46.8, Close: 47.4 },
        { Open: 47.4, High: 52.87, Low: 47.12, Close: 51.6 },
        { Open: 51.6, High: 62., Low: 50., Close: 59.14 },
        { Open: 59.14, High: 66., Low: 57.7, Close: 64.49 },
        { Open: 64.49, High: 74.9, Low: 63.1, Close: 70.85 },
        { Open: 70.85, High: 73.75, Low: 65., Close: 69.86 },
        { Open: 69.86, High: 70.5, Low: 52.35, Close: 64.35 },
        { Open: 64.35, High: 72.5, Low: 62.7, Close: 71.5 },
        { Open: 71.5, High: 78., Low: 69.52, Close: 73.6 },
        { Open: 73.6, High: 79.72, Low: 73.11, Close: 78.5 },
        { Open: 78.5, High: 89.5, Low: 78.4, Close: 88.92 },
        { Open: 88.92, High: 95.7, Low: 75., Close: 86.18 },
        { Open: 86.18, High: 93.06, Low: 83.01, Close: 90.5 },
        { Open: 90.5, High: 94.98, Low: 87., Close: 92.19 },
        { Open: 92.19, High: 93.8, Low: 91., Close: 93.03 },
        { Open: 93.03, High: 106., Low: 92.24, Close: 104. },
        { Open: 104., High: 118.36, Low: 99., Close: 117.98 },
        { Open: 117.98, High: 147., Low: 110., Close: 135. },
        { Open: 135., High: 142.12, Low: 116.39, Close: 132.12 },
        { Open: 132.12, High: 144.94, Low: 130.24, Close: 142.32 },
        { Open: 142.32, High: 143.9, Low: 139.54, Close: 142.63 },
        { Open: 142.63, High: 164.9, Low: 142.63, Close: 162.3 },
        { Open: 162.3, High: 194.9, Low: 162.6, Close: 187.5 },
        { Open: 187.5, High: 240.11, Low: 186.5, Close: 230. },
        { Open: 230., High: 266., Low: 105., Close: 165. },
        { Open: 165., High: 188.7, Low: 110.2, Close: 124.9 },
        { Open: 124.9, High: 140., Low: 54.25, Close: 117. },
        { Open: 117., High: 130., Low: 85.5, Close: 93. },
        { Open: 93., High: 110., Low: 84.44, Close: 90. },
        { Open: 90., High: 102., Low: 71.51, Close: 82.39 },
        { Open: 82.39, High: 84.5, Low: 50.01, Close: 68.36 },
        { Open: 68.36, High: 98.78, Low: 63.3, Close: 93.07 },
        { Open: 93.07, High: 113., Low: 86., Close: 109.01 },
        { Open: 109.01, High: 136.43, Low: 105.54, Close: 118.48 },
        { Open: 118.48, High: 132., Low: 115., Close: 126.62 },
        { Open: 126.62, High: 130.5, Low: 110., Close: 119.2 },
        { Open: 119.2, High: 127.4, Low: 118.5, Close: 127.4 },
        { Open: 127.4, High: 144.02, Low: 124.97, Close: 143.47 },
        { Open: 143.47, High: 166.43, Low: 140.97, Close: 154.2 },
        { Open: 154.2, High: 162., Low: 120.09, Close: 141.71 },
        { Open: 141.71, High: 144.99, Low: 121.45, Close: 136.9 },
        { Open: 136.9, High: 139.88, Low: 122.71, Close: 128. },
        { Open: 128., High: 136.68, Low: 127.5, Close: 134.44 },
        { Open: 134.44, High: 149.08, Low: 133., Close: 144. },
        { Open: 144., High: 146.93, Low: 134., Close: 139.23 },
        { Open: 139.23, High: 140.06, Low: 104., Close: 116.38 },
        { Open: 116.38, High: 126.9, Low: 91.11, Close: 106.25 },
        { Open: 106.25, High: 109., Low: 79., Close: 98.1 },
        { Open: 98.1, High: 116.3, Low: 92., Close: 112.9 },
        { Open: 112.9, High: 118.85, Low: 107., Close: 115.98 },
        { Open: 115.98, High: 124.9, Low: 106.01, Close: 112.25 },
        { Open: 112.25, High: 114., Low: 97.52, Close: 109.6 },
        { Open: 109.6, High: 116.78, Low: 109.5, Close: 113.2 },
        { Open: 113.2, High: 113.72, Low: 108.8, Close: 112.8 },
        { Open: 112.8, High: 122.5, Low: 111.54, Close: 117.7 },
        { Open: 117.7, High: 118.74, Low: 113., Close: 115.64 },
        { Open: 115.64, High: 117.47, Low: 112.4, Close: 114.82 },
        { Open: 114.82, High: 118.88, Low: 114.5, Close: 117.98 },
        { Open: 117.98, High: 119.8, Low: 109.42, Close: 111.4 },
        { Open: 111.4, High: 116.44, Low: 103.02, Close: 114.22 },
        { Open: 114.22, High: 118.97, Low: 112.1, Close: 118.21 },
        { Open: 118.21, High: 125.56, Low: 116.57, Close: 123.5 },
        { Open: 123.5, High: 125.31, Low: 122.25, Close: 123.21 },
        { Open: 123.21, High: 124.5, Low: 119.5, Close: 122.5 },
        { Open: 122.5, High: 123.69, Low: 120.1, Close: 122.02 },
        { Open: 122.02, High: 123.08, Low: 121.1, Close: 122.89 },
        { Open: 122.89, High: 124.5, Low: 122., Close: 123.8 },
        { Open: 123.8, High: 126.93, Low: 123., Close: 126.3 },
        { Open: 126.3, High: 133.98, Low: 125.35, Close: 133.1 },
        { Open: 133.1, High: 133.5, Low: 128.2, Close: 131.99 },
        { Open: 131.99, High: 136., Low: 130.61, Close: 133.5 },
        { Open: 133.5, High: 135.47, Low: 124., Close: 129.77 },
        { Open: 129.77, High: 130.63, Low: 125.4, Close: 129. },
        { Open: 129., High: 132.72, Low: 127.6, Close: 132.25 },
        { Open: 132.25, High: 132.4, Low: 126.5, Close: 128.8 },
        { Open: 128.8, High: 130., Low: 126.33, Close: 128.82 },
        { Open: 128.82, High: 129.79, Low: 127.1, Close: 129.3 },
        { Open: 129.3, High: 130.1, Low: 115., Close: 122.5 },
        { Open: 122.5, High: 122.78, Low: 115.11, Close: 120.74 },
        { Open: 120.74, High: 123.99, Low: 118.79, Close: 121.4 },
        { Open: 121.4, High: 123.5, Low: 119.5, Close: 121.9 },
        { Open: 121.9, High: 123.3, Low: 117., Close: 118.97 },
        { Open: 118.97, High: 119.13, Low: 106.15, Close: 111. },
        { Open: 111., High: 113.19, Low: 107., Close: 107.89 },
        { Open: 107.89, High: 108.99, Low: 88., Close: 100.44 },
        { Open: 100.44, High: 110.63, Low: 95., Close: 106.35 },
        { Open: 106.35, High: 109.6, Low: 103.23, Close: 109. },
        { Open: 109., High: 112.25, Low: 106., Close: 108.78 },
        { Open: 108.78, High: 110.3, Low: 100.3, Close: 103.95 },
        { Open: 103.95, High: 104.7, Low: 97.1, Close: 100. },
        { Open: 100., High: 103.7, Low: 97.5, Close: 99.8 },
        { Open: 99.8, High: 101.75, Low: 98.9, Close: 99.9 },
        { Open: 99.9, High: 102.4, Low: 98.9, Close: 101.95 },
        { Open: 101.95, High: 113.3, Low: 101.03, Close: 107.35 },
        { Open: 107.35, High: 110.99, Low: 104.66, Close: 108.25 },
        { Open: 108.25, High: 114.48, Low: 107.12, Close: 111.29 },
        { Open: 111.29, High: 115., Low: 107.56, Close: 109.5 },
        { Open: 109.5, High: 109.96, Low: 107.51, Close: 108.2 },
        { Open: 108.2, High: 109., Low: 106.2, Close: 107.9 },
        { Open: 107.9, High: 108.33, Low: 100.76, Close: 102.09 },
        { Open: 102.09, High: 109.98, Low: 100., Close: 103.33 },
        { Open: 103.33, High: 105.49, Low: 101.83, Close: 104. },
        { Open: 104., High: 104., Low: 100.05, Close: 101.74 },
        { Open: 101.74, High: 101.79, Low: 92.25, Close: 94.66 },
        { Open: 94.66, High: 100.44, Low: 93., Close: 95. },
        { Open: 95., High: 98.12, Low: 93.85, Close: 97.51 },
        { Open: 90.11, High: 90.75, Low: 82.75, Close: 84.61 },
        { Open: 84.61, High: 88.69, Low: 82.4, Close: 87.66 },
        { Open: 87.66, High: 89.19, Low: 75.6, Close: 76.89 },
        { Open: 76.89, High: 79.95, Low: 72.57, Close: 77.68 },
        { Open: 77.68, High: 78.07, Low: 65.77, Close: 66.34 },
        { Open: 66.34, High: 69.88, Low: 64.25, Close: 66.85 },
        { Open: 66.85, High: 73.04, Low: 62.9, Close: 72.51 },
        { Open: 72.51, High: 76.92, Low: 72.35, Close: 74.56 },
        { Open: 74.56, High: 76.44, Low: 72.44, Close: 74.22 },
        { Open: 74.22, High: 87.43, Low: 74.22, Close: 84.51 },
        { Open: 84.51, High: 93.49, Low: 84.08, Close: 91.22 },
        { Open: 91.22, High: 98.58, Low: 85.99, Close: 88.46 },
        { Open: 88.46, High: 92.32, Low: 86.22, Close: 91.39 },
        { Open: 91.39, High: 92.78, Low: 89.58, Close: 90.37 },
        { Open: 90.37, High: 94.85, Low: 89.31, Close: 93.14 },
        { Open: 93.14, High: 94.13, Low: 90.9, Close: 92.74 },
        { Open: 92.74, High: 93.39, Low: 90.54, Close: 90.54 },
        { Open: 90.54, High: 92.14, Low: 81.28, Close: 85.43 },
        { Open: 85.43, High: 86.71, Low: 84.56, Close: 85.78 },
        { Open: 85.78, High: 86.41, Low: 85.5, Close: 85.67 },
        { Open: 85.67, High: 86.19, Low: 85.01, Close: 85.47 },
        { Open: 85.47, High: 86.45, Low: 84.49, Close: 86.09 },
        { Open: 86.09, High: 87.85, Low: 84.69, Close: 86.94 },
        { Open: 86.94, High: 87.62, Low: 86.49, Close: 87.46 },
        { Open: 87.46, High: 90.21, Low: 86.37, Close: 89.41 },
        { Open: 89.41, High: 91.67, Low: 88.76, Close: 90.63 },
        { Open: 90.63, High: 91., Low: 88.53, Close: 89.1 },
        { Open: 89.1, High: 92.86, Low: 88.2, Close: 92.1 },
        { Open: 92.1, High: 93.3, Low: 90.91, Close: 93.3 },
        { Open: 93.3, High: 97.06, Low: 92.14, Close: 96.31 },
        { Open: 96.31, High: 100.36, Low: 95.97, Close: 97.91 },
        { Open: 97.91, High: 98.53, Low: 96.32, Close: 96.42 },
        { Open: 96.42, High: 99.1, Low: 95.65, Close: 97.24 },
        { Open: 97.24, High: 97.45, Low: 95.64, Close: 96.66 },
        { Open: 96.66, High: 96.74, Low: 96.01, Close: 96.6 },
        { Open: 96.6, High: 98.24, Low: 96.06, Close: 96.92 },
        { Open: 96.92, High: 98.09, Low: 96.64, Close: 97.13 },
        { Open: 97.13, High: 98.15, Low: 96.29, Close: 96.92 },
        { Open: 96.92, High: 97.31, Low: 93.59, Close: 94.77 },
        { Open: 94.77, High: 95.46, Low: 92.46, Close: 93.36 },
        { Open: 93.36, High: 94.48, Low: 92.57, Close: 93.29 },
        { Open: 93.29, High: 94.42, Low: 93.13, Close: 94.16 },
        { Open: 94.16, High: 95.49, Low: 93.53, Close: 95.08 },
        { Open: 95.08, High: 97.99, Low: 94.64, Close: 97.9 },
        { Open: 97.9, High: 100.84, Low: 97.52, Close: 97.96 },
        { Open: 97.96, High: 99.79, Low: 97.49, Close: 97.54 },
        { Open: 97.54, High: 99., Low: 96.95, Close: 98.33 },
        { Open: 98.33, High: 99.68, Low: 97.63, Close: 99.56 },
        { Open: 99.56, High: 99.62, Low: 98.38, Close: 98.84 },
        { Open: 98.84, High: 104.01, Low: 98.75, Close: 102.3 },
        { Open: 102.3, High: 105.72, Low: 101.46, Close: 105.01 },
        { Open: 105.01, High: 112.54, Low: 103.99, Close: 111.44 },
        { Open: 111.44, High: 112.8, Low: 109.37, Close: 109.73 },
        { Open: 109.73, High: 109.9, Low: 106.04, Close: 107.55 },
        { Open: 107.55, High: 110.02, Low: 106.94, Close: 108.69 },
        { Open: 108.69, High: 112.47, Low: 108.56, Close: 111.79 },
        { Open: 111.79, High: 112.27, Low: 110.38, Close: 112.23 },
        { Open: 112.23, High: 118.07, Low: 111.77, Close: 117.45 },
        { Open: 117.45, High: 118.36, Low: 116.38, Close: 117.59 },
        { Open: 117.59, High: 117.92, Low: 116.57, Close: 117.52 },
        { Open: 117.52, High: 124.06, Low: 117.07, Close: 123.23 },
        { Open: 123.23, High: 130.15, Low: 122.2, Close: 129.46 },
        { Open: 129.46, High: 129.46, Low: 124.5, Close: 128.26 },
        { Open: 128.26, High: 130.59, Low: 126.76, Close: 127.36 },
        { Open: 127.36, High: 128.88, Low: 125.62, Close: 127.59 },
        { Open: 127.59, High: 127.76, Low: 115.57, Close: 120.57 },
        { Open: 120.57, High: 123.68, Low: 114.53, Close: 120.53 },
        { Open: 120.53, High: 122.22, Low: 115.75, Close: 116.32 },
        { Open: 116.32, High: 120.17, Low: 115.34, Close: 119.05 },
        { Open: 119.05, High: 119.86, Low: 116.59, Close: 116.59 },
        { Open: 116.59, High: 122.55, Low: 116.52, Close: 120.02 },
        { Open: 120.02, High: 123.81, Low: 119.99, Close: 121.46 },
        { Open: 121.46, High: 125.7, Low: 119.38, Close: 125.45 },
        { Open: 125.45, High: 127.92, Low: 124.12, Close: 125.76 },
        { Open: 125.76, High: 128.39, Low: 124.7, Close: 126.51 },
        { Open: 126.51, High: 126.9, Low: 123.29, Close: 124.08 },
        { Open: 124.08, High: 125.18, Low: 122.89, Close: 124.58 },
        { Open: 124.58, High: 125.74, Low: 124.18, Close: 125.06 },
        { Open: 125.06, High: 127.5, Low: 125.06, Close: 125.97 },
        { Open: 125.97, High: 128.06, Low: 125.63, Close: 126.3 },
        { Open: 126.3, High: 127.7, Low: 123.15, Close: 124.19 },
        { Open: 124.19, High: 124.93, Low: 122.59, Close: 122.9 },
        { Open: 122.9, High: 124.33, Low: 122.1, Close: 122.64 },
        { Open: 122.64, High: 123.11, Low: 121.96, Close: 122.65 },
        { Open: 122.65, High: 123.96, Low: 121.87, Close: 122.22 },
        { Open: 122.22, High: 122.93, Low: 121.37, Close: 122.54 },
        { Open: 122.54, High: 125.24, Low: 122.54, Close: 123.42 },
        { Open: 123.42, High: 124.08, Low: 122.34, Close: 123.48 },
        { Open: 123.48, High: 126.18, Low: 123.13, Close: 123.5 },
        { Open: 123.5, High: 124.91, Low: 122.1, Close: 124.75 },
        { Open: 124.75, High: 126.46, Low: 123.23, Close: 125.18 },
        { Open: 125.18, High: 125.18, Low: 120.69, Close: 123.1 },
        { Open: 123.1, High: 125.49, Low: 121.83, Close: 125.49 },
        { Open: 125.49, High: 125.76, Low: 82., Close: 99.81 },
        { Open: 99.81, High: 117.98, Low: 97., Close: 116.82 },
        { Open: 116.82, High: 123.62, Low: 116.65, Close: 121.29 },
        { Open: 121.29, High: 122.69, Low: 120.69, Close: 121.14 },
        { Open: 121.14, High: 121.77, Low: 120.43, Close: 121.68 },
        { Open: 121.68, High: 123.73, Low: 121.25, Close: 123.24 },
        { Open: 123.24, High: 124.78, Low: 122.55, Close: 124.32 },
        { Open: 124.32, High: 128.02, Low: 123.64, Close: 125.84 },
        { Open: 125.84, High: 126.44, Low: 124.11, Close: 125.7 },
        { Open: 125.7, High: 126., Low: 123.13, Close: 125.51 },
        { Open: 125.51, High: 126.57, Low: 124.75, Close: 126.52 },
        { Open: 126.52, High: 130.9, Low: 125.39, Close: 130.42 },
        { Open: 130.42, High: 136.64, Low: 128.8, Close: 133.04 },
        { Open: 133.04, High: 139.71, Low: 132.45, Close: 138.64 },
        { Open: 138.64, High: 146.68, Low: 136.32, Close: 137.42 },
        { Open: 137.42, High: 144.31, Low: 136.27, Close: 142.73 },
        { Open: 142.73, High: 149.99, Low: 141.89, Close: 149.59 },
        { Open: 149.59, High: 167.08, Low: 148.69, Close: 159.81 },
        { Open: 159.81, High: 163.8, Low: 159.18, Close: 163.06 },
        { Open: 163.06, High: 175.46, Low: 161.5, Close: 174.18 },
        { Open: 174.18, High: 186.64, Low: 170.28, Close: 183.86 },
        { Open: 183.86, High: 200.62, Low: 182.99, Close: 200.62 },
        { Open: 200.62, High: 202.34, Low: 157.71, Close: 183.15 },
        { Open: 183.15, High: 186.59, Low: 162.56, Close: 178.12 },
        { Open: 178.12, High: 182.07, Low: 174.02, Close: 175.9 },
        { Open: 175.9, High: 186.53, Low: 174.9, Close: 185.69 },
        { Open: 185.69, High: 188.19, Low: 183.75, Close: 187.87 },
        { Open: 187.87, High: 198.41, Low: 189.81, Close: 198.19 },
        { Open: 198.19, High: 198.79, Low: 192.83, Close: 194.55 },
        { Open: 194.55, High: 198.57, Low: 192.74, Close: 198.23 },
        { Open: 198.23, High: 198.92, Low: 195.48, Close: 198.51 },
        { Open: 198.51, High: 201.24, Low: 198.18, Close: 200.85 },
        { Open: 200.85, High: 207.76, Low: 198.94, Close: 207.63 },
        { Open: 207.63, High: 226.04, Low: 206.63, Close: 225.2 },
        { Open: 225.2, High: 246.78, Low: 221.85, Close: 239.29 },
        { Open: 239.29, High: 255.54, Low: 238.92, Close: 253.69 },
        { Open: 253.69, High: 292.71, Low: 253.69, Close: 283.3 },
        { Open: 283.3, High: 324.4, Low: 283.3, Close: 323.77 },
        { Open: 323.77, High: 355.23, Low: 303.29, Close: 336.14 },
        { Open: 336.14, High: 338.25, Low: 260.7, Close: 311.9 },
        { Open: 311.9, High: 339.48, Low: 303.51, Close: 332.63 },
        { Open: 332.63, High: 350.03, Low: 324.45, Close: 349.34 },
        { Open: 349.34, High: 399.47, Low: 349.34, Close: 393.28 },
        { Open: 393.28, High: 416.82, Low: 383.58, Close: 410.72 },
        { Open: 410.72, High: 427.9, Low: 386.56, Close: 409.17 },
        { Open: 409.17, High: 438.13, Low: 406.67, Close: 428.82 },
        { Open: 428.82, High: 482.98, Low: 428.54, Close: 476.29 },
        { Open: 476.29, High: 674.38, Low: 471.61, Close: 674.38 },
        { Open: 674.38, High: 781.83, Low: 394.91, Close: 541.83 },
        { Open: 541.83, High: 578.75, Low: 389.5, Close: 572.67 },
        { Open: 572.67, High: 705.5, Low: 560.35, Close: 695.87 },
        { Open: 695.87, High: 767.98, Low: 651.9, Close: 747.48 },
        { Open: 747.48, High: 823.42, Low: 698.99, Close: 776.7 },
        { Open: 776.7, High: 831.76, Low: 691.69, Close: 751.38 },
        { Open: 751.38, High: 788.3, Low: 725.48, Close: 778.68 },
        { Open: 778.68, High: 904.58, Low: 775.42, Close: 899.2 },
        { Open: 899.2, High: 961.99, Low: 866.84, Close: 948.41 },
        { Open: 948.41, High: 1106.54, Low: 912.93, Close: 1037.75 },
        { Open: 1037.75, High: 1128.32, Low: 1000.58, Close: 1120.4 },
        { Open: 1120.4, High: 1165.89, Low: 1110.21, Close: 1124.76 },
        { Open: 1124.76, High: 1128.88, Low: 783.69, Close: 946.92 },
        { Open: 946.92, High: 1054.42, Low: 929.95, Close: 1038.35 },
        { Open: 1038.35, High: 1092.83, Low: 1002.86, Close: 1068.67 },
        { Open: 1068.67, High: 1151.3, Low: 1063.76, Close: 1147.25 },
        { Open: 1147.25, High: 1149.74, Low: 870.38, Close: 1042.03 },
        { Open: 1042.03, High: 1045.96, Low: 815.29, Close: 834.03 },
        { Open: 834.03, High: 863.13, Low: 558.08, Close: 694.47 },
        { Open: 694.47, High: 801.16, Low: 668.2, Close: 795.4 },
        { Open: 795.4, High: 925.27, Low: 779.73, Close: 898.02 },
        { Open: 898.02, High: 1013.12, Low: 897.22, Close: 990. },
        { Open: 990., High: 1001.8, Low: 832.23, Close: 883.26 },
        { Open: 883.26, High: 908.38, Low: 842.68, Close: 875.75 },
        { Open: 875.75, High: 933.17, Low: 859.45, Close: 898.21 },
        { Open: 898.21, High: 909.34, Low: 857.09, Close: 867.49 },
        { Open: 867.49, High: 886.24, Low: 819.44, Close: 879.47 },
        { Open: 879.47, High: 880.51, Low: 676.02, Close: 712.51 },
        { Open: 712.51, High: 757.02, Low: 636.15, Close: 683.84 },
        { Open: 683.84, High: 683.84, Low: 422.5, Close: 522.23 },
        { Open: 522.23, High: 710.33, Low: 504.13, Close: 698.45 },
        { Open: 698.45, High: 733.24, Low: 598.06, Close: 622.84 },
        { Open: 622.84, High: 657.71, Low: 580.73, Close: 608.96 },
        { Open: 608.96, High: 671.59, Low: 589.73, Close: 617.82 },
        { Open: 617.82, High: 683.73, Low: 613.45, Close: 673.17 },
        { Open: 673.17, High: 685.37, Low: 645.78, Close: 667.62 },
        { Open: 667.62, High: 687.36, Low: 651.53, Close: 687.36 },
        { Open: 687.36, High: 780.94, Low: 687.36, Close: 765.21 },
        { Open: 765.21, High: 780.77, Low: 723.99, Close: 746.72 },
        { Open: 746.72, High: 753.83, Low: 705.1, Close: 730.47 },
        { Open: 730.47, High: 753.82, Low: 713.75, Close: 745.07 },
        { Open: 745.07, High: 763.83, Low: 743.59, Close: 754.76 },
        { Open: 754.76, High: 759.72, Low: 733.19, Close: 757.5 },
        { Open: 757.5, High: 787.63, Low: 750.53, Close: 770.44 },
        { Open: 770.44, High: 826.64, Low: 768.15, Close: 808.05 },
        { Open: 808.05, High: 840.15, Low: 794.26, Close: 830.02 },
        { Open: 830.02, High: 861.15, Low: 808.82, Close: 858.98 },
        { Open: 858.98, High: 959.33, Low: 857.64, Close: 940.1 },
        { Open: 940.1, High: 1023.31, Low: 914.77, Close: 951.39 },
        { Open: 951.39, High: 975.22, Low: 810.58, Close: 810.58 },
        { Open: 810.58, High: 886.05, Low: 788.94, Close: 859.95 },
        { Open: 859.95, High: 880.67, Low: 814.34, Close: 860.89 },
        { Open: 860.89, High: 888.87, Low: 837.88, Close: 884.67 },
        { Open: 884.67, High: 934.44, Low: 841.02, Close: 930.9 },
        { Open: 930.9, High: 940.75, Low: 860.02, Close: 873.26 },
        { Open: 873.26, High: 877.11, Low: 821.24, Close: 857.96 },
        { Open: 857.96, High: 875.08, Low: 839.18, Close: 851.83 },
        { Open: 851.83, High: 889.18, Low: 848.06, Close: 874.71 },
        { Open: 874.71, High: 893.75, Low: 847.37, Close: 847.37 },
        { Open: 847.37, High: 854.48, Low: 810.43, Close: 828.22 },
        { Open: 828.22, High: 850.6, Low: 828.22, Close: 843.76 },
        { Open: 843.76, High: 883.46, Low: 835., Close: 878.68 },
        { Open: 878.68, High: 897.56, Low: 858.11, Close: 871.05 },
        { Open: 871.05, High: 895.96, Low: 861.95, Close: 874.29 },
        { Open: 874.29, High: 884.5, Low: 854.35, Close: 863.95 },
        { Open: 863.95, High: 883.91, Low: 848.72, Close: 854.35 },
        { Open: 854.35, High: 862.21, Low: 785.01, Close: 825.12 },
        { Open: 825.12, High: 889.04, Low: 821.34, Close: 861.85 },
        { Open: 861.85, High: 899.36, Low: 851.75, Close: 880.15 },
        { Open: 880.15, High: 888.18, Low: 800.34, Close: 814.53 },
        { Open: 814.53, High: 879.1, Low: 784.08, Close: 833.94 },
        { Open: 833.94, High: 862.62, Low: 828.77, Close: 837.51 },
        { Open: 837.51, High: 875.27, Low: 816.36, Close: 845.85 },
        { Open: 845.85, High: 852.48, Low: 839.83, Close: 848.29 },
        { Open: 848.29, High: 874.36, Low: 843.35, Close: 853.02 },
        { Open: 853.02, High: 884.79, Low: 850.5, Close: 854.37 },
        { Open: 854.37, High: 874.68, Low: 843.86, Close: 846.9 },
        { Open: 846.9, High: 852.27, Low: 841.38, Close: 842.01 },
        { Open: 842.01, High: 864.59, Low: 819.85, Close: 820.87 },
        { Open: 820.87, High: 825.38, Low: 780.09, Close: 783.62 },
        { Open: 783.62, High: 784.85, Low: 658.87, Close: 703.57 },
        { Open: 703.57, High: 721.86, Low: 665.4, Close: 676.91 },
        { Open: 676.91, High: 708.79, Low: 657.94, Close: 681.94 },
        { Open: 681.94, High: 704.65, Low: 535.78, Close: 679.73 },
        { Open: 679.73, High: 713.07, Low: 635.36, Close: 669.44 },
        { Open: 669.44, High: 677.24, Low: 633.87, Close: 648.38 },
        { Open: 648.38, High: 659.76, Low: 595., Close: 598.41 },
        { Open: 598.41, High: 708.22, Low: 532.8, Close: 656.61 },
        { Open: 656.61, High: 658.63, Low: 626.86, Close: 645.43 },
        { Open: 645.43, High: 667.54, Low: 576.34, Close: 610.65 },
        { Open: 610.65, High: 653.91, Low: 603.16, Close: 621.49 },
        { Open: 621.49, High: 644.5, Low: 608.03, Close: 621.22 },
        { Open: 621.22, High: 635.42, Low: 611.23, Close: 617.71 },
        { Open: 617.71, High: 627.18, Low: 548.49, Close: 552.21 },
        { Open: 552.21, High: 581.59, Low: 525.41, Close: 569.04 },
        { Open: 569.04, High: 612.55, Low: 554.6, Close: 604.75 },
        { Open: 604.75, High: 637.49, Low: 595.6, Close: 604.58 },
        { Open: 604.58, High: 606.94, Low: 535.19, Close: 545.32 },
        { Open: 545.32, High: 545.32, Low: 418.78, Close: 534.71 },
        { Open: 534.71, High: 604.19, Low: 531.45, Close: 577.09 },
        { Open: 577.09, High: 594.1, Low: 558.49, Close: 576.7 },
        { Open: 576.7, High: 587.56, Low: 540.58, Close: 543.93 },
        { Open: 543.93, High: 573.65, Low: 536.06, Close: 563.74 },
        { Open: 563.74, High: 569.05, Low: 547.83, Close: 560.3 },
        { Open: 560.3, High: 678.5, Low: 557.75, Close: 661.12 },
        { Open: 661.12, High: 698.55, Low: 653.9, Close: 663.6 },
        { Open: 663.6, High: 669.31, Low: 643.67, Close: 661.79 },
        { Open: 661.79, High: 666., Low: 644.68, Close: 658.72 },
        { Open: 658.72, High: 658.91, Low: 611.36, Close: 625.83 },
        { Open: 625.83, High: 632.61, Low: 601.32, Close: 615.24 },
        { Open: 615.24, High: 645.3, Low: 610.07, Close: 633.18 },
        { Open: 633.18, High: 642.75, Low: 611.4, Close: 625.83 },
        { Open: 625.83, High: 634.85, Low: 615.53, Close: 628.95 },
        { Open: 628.95, High: 645.9, Low: 627.65, Close: 631.39 },
        { Open: 631.39, High: 641.77, Low: 628.02, Close: 638.16 },
        { Open: 638.16, High: 638.98, Low: 625.01, Close: 626.71 },
        { Open: 626.71, High: 636.12, Low: 625.19, Close: 633.67 },
        { Open: 633.67, High: 635.82, Low: 627.75, Close: 630.72 },
        { Open: 630.72, High: 631.01, Low: 616.43, Close: 621.22 },
        { Open: 621.22, High: 621.45, Low: 599.93, Close: 613.63 },
        { Open: 613.63, High: 621.64, Low: 607.73, Close: 608.82 },
        { Open: 608.82, High: 608.82, Low: 583.68, Close: 586.59 },
        { Open: 586.59, High: 605.31, Low: 563.79, Close: 570.77 },
        { Open: 570.77, High: 571.93, Low: 550.84, Close: 564.42 },
        { Open: 564.42, High: 570.47, Low: 560.25, Close: 561.35 },
        { Open: 561.35, High: 588.14, Low: 551.48, Close: 586.27 },
        { Open: 586.27, High: 586.27, Low: 570.6, Close: 582.28 },
        { Open: 582.28, High: 590.27, Low: 568.9, Close: 579.07 },
        { Open: 579.07, High: 580.4, Low: 471.03, Close: 478.16 },
        { Open: 478.16, High: 527.84, Low: 471.34, Close: 502.44 },
        { Open: 502.44, High: 506.46, Low: 488.71, Close: 493.18 },
        { Open: 493.18, High: 493.18, Low: 443.26, Close: 461.87 },
        { Open: 461.87, High: 483.98, Low: 442.46, Close: 458.5 },
        { Open: 458.5, High: 500.71, Low: 455.7, Close: 478.72 },
        { Open: 478.72, High: 495.08, Low: 430.17, Close: 437.51 },
        { Open: 437.51, High: 456.42, Low: 414.41, Close: 447.08 },
        { Open: 447.08, High: 456.05, Low: 428.76, Close: 448.88 },
        { Open: 448.88, High: 464.83, Low: 444.47, Close: 464.83 },
        { Open: 464.83, High: 466.53, Low: 450.92, Close: 460.7 },
        { Open: 460.7, High: 461.8, Low: 443.83, Close: 446.22 },
        { Open: 446.22, High: 456.89, Low: 444.84, Close: 450.46 },
        { Open: 450.46, High: 453.56, Low: 439.69, Close: 440.2 },
        { Open: 440.2, High: 441.15, Low: 355.41, Close: 360.84 },
        { Open: 360.84, High: 429.79, Low: 344.24, Close: 420.06 },
        { Open: 420.06, High: 438.97, Low: 413.29, Close: 420.66 },
        { Open: 420.66, High: 426.64, Low: 394.34, Close: 414.95 },
        { Open: 414.95, High: 471.04, Low: 406.95, Close: 457.63 },
        { Open: 457.63, High: 525.09, Low: 452.48, Close: 520.12 },
        { Open: 520.12, High: 543.48, Low: 493.38, Close: 529.16 },
        { Open: 529.16, High: 534.14, Low: 481.57, Close: 494.4 },
        { Open: 494.4, High: 498.01, Low: 468.33, Close: 478.23 },
        { Open: 478.23, High: 502.88, Low: 468.02, Close: 501.55 },
        { Open: 501.55, High: 511.87, Low: 489.36, Close: 497.32 },
        { Open: 497.32, High: 510.61, Low: 489.15, Close: 493.09 },
        { Open: 493.09, High: 499.39, Low: 483., Close: 484.43 },
        { Open: 484.43, High: 490.04, Low: 480.71, Close: 486.93 },
        { Open: 486.93, High: 500.76, Low: 477.66, Close: 500.26 },
        { Open: 500.26, High: 500.29, Low: 440.31, Close: 459.61 },
        { Open: 459.61, High: 463.35, Low: 447.66, Close: 456.14 },
        { Open: 456.14, High: 457.59, Low: 429.65, Close: 429.65 },
        { Open: 429.65, High: 445.78, Low: 421.33, Close: 437.06 },
        { Open: 437.06, High: 449.12, Low: 431.29, Close: 444.25 },
        { Open: 444.25, High: 448.79, Low: 433.07, Close: 445.87 },
        { Open: 445.87, High: 459.71, Low: 445.76, Close: 456.27 },
        { Open: 456.27, High: 457.08, Low: 440.12, Close: 446.64 },
        { Open: 446.64, High: 446.92, Low: 428.65, Close: 436.94 },
        { Open: 436.94, High: 438.58, Low: 428.52, Close: 434.06 },
        { Open: 434.06, High: 438.6, Low: 425.52, Close: 429.72 },
        { Open: 429.72, High: 431.56, Low: 418.11, Close: 426.99 },
        { Open: 426.99, High: 446.66, Low: 423.34, Close: 436.96 },
        { Open: 436.96, High: 445.18, Low: 435.17, Close: 435.34 },
        { Open: 435.34, High: 451.5, Low: 434.61, Close: 448.23 },
        { Open: 448.23, High: 453.66, Low: 446.5, Close: 452.71 },
        { Open: 452.71, High: 453.43, Low: 430.53, Close: 436.54 },
        { Open: 436.54, High: 440.22, Low: 431.63, Close: 438.43 },
        { Open: 438.43, High: 439.57, Low: 433.19, Close: 437.41 },
        { Open: 437.41, High: 445.12, Low: 437.08, Close: 441.75 },
        { Open: 441.75, High: 447.78, Low: 441.37, Close: 444.32 },
        { Open: 444.32, High: 447.3, Low: 442.05, Close: 445.01 },
        { Open: 445.01, High: 446.92, Low: 443.78, Close: 446.36 },
        { Open: 446.36, High: 446.54, Low: 443.38, Close: 444.81 },
        { Open: 444.81, High: 445.77, Low: 442.22, Close: 444.31 },
        { Open: 444.31, High: 494.29, Low: 443.83, Close: 485.83 },
        { Open: 485.83, High: 494.75, Low: 484.24, Close: 489.16 },
        { Open: 489.16, High: 526.9, Low: 487.71, Close: 526.06 },
        { Open: 526.06, High: 543.31, Low: 517.43, Close: 519.04 },
        { Open: 519.04, High: 525.63, Low: 511.91, Close: 525.63 },
        { Open: 525.63, High: 579.5, Low: 525.28, Close: 570.09 },
        { Open: 570.09, High: 590.11, Low: 564.79, Close: 581.83 },
        { Open: 581.83, High: 591.41, Low: 549.81, Close: 569.63 },
        { Open: 569.63, High: 577.05, Low: 560.62, Close: 574.45 },
        { Open: 574.45, High: 576.08, Low: 556.41, Close: 565.51 },
        { Open: 565.51, High: 622.61, Low: 565.25, Close: 616.47 },
        { Open: 616.47, High: 624.36, Low: 603.3, Close: 623.26 },
        { Open: 623.26, High: 676.75, Low: 618.61, Close: 629.02 },
        { Open: 629.02, High: 667.34, Low: 611.31, Close: 658.79 },
        { Open: 658.79, High: 675.91, Low: 646.35, Close: 665.73 },
        { Open: 665.73, High: 667.39, Low: 616.95, Close: 636.78 },
        { Open: 636.78, High: 665.14, Low: 635.86, Close: 656.06 },
        { Open: 656.06, High: 658.03, Low: 645.56, Close: 645.56 },
        { Open: 645.56, High: 653., Low: 635.85, Close: 652.71 },
        { Open: 652.71, High: 657.09, Low: 649.59, Close: 653.64 },
        { Open: 653.64, High: 654.42, Low: 637.63, Close: 645.34 },
        { Open: 645.34, High: 658.02, Low: 641.42, Close: 649.81 },
        { Open: 649.81, High: 654.96, Low: 626.16, Close: 627.91 },
        { Open: 627.91, High: 634.51, Low: 562.84, Close: 581.8 },
        { Open: 581.8, High: 613.73, Low: 581.38, Close: 597.43 },
        { Open: 597.43, High: 598.28, Low: 541.53, Close: 571.69 },
        { Open: 571.69, High: 592.19, Low: 551.45, Close: 591.97 },
        { Open: 591.97, High: 606.86, Low: 584.94, Close: 588.06 },
        { Open: 588.06, High: 609.3, Low: 585.96, Close: 607.34 },
        { Open: 607.34, High: 614.17, Low: 599.94, Close: 604.88 },
        { Open: 604.88, High: 606.08, Low: 591.76, Close: 592.26 },
        { Open: 592.26, High: 595.24, Low: 581.51, Close: 588.52 },
        { Open: 588.52, High: 593.72, Low: 581.31, Close: 591.03 },
        { Open: 591.03, High: 603.3, Low: 590.71, Close: 598.88 },
        { Open: 598.88, High: 599.79, Low: 581.03, Close: 587.46 },
        { Open: 587.46, High: 590.71, Low: 574.32, Close: 575.07 },
        { Open: 575.07, High: 578.55, Low: 558.69, Close: 562.13 },
        { Open: 562.13, High: 580.14, Low: 560.3, Close: 579.38 },
        { Open: 579.38, High: 600.86, Low: 576.5, Close: 600.86 },
        { Open: 600.86, High: 604.52, Low: 591.48, Close: 591.99 },
        { Open: 591.99, High: 600.65, Low: 588.34, Close: 598.6 },
        { Open: 598.6, High: 643.43, Low: 596.33, Close: 639.36 },
        { Open: 639.36, High: 654.77, Low: 635.53, Close: 635.59 },
        { Open: 635.59, High: 653.82, Low: 627.93, Close: 647.34 },
        { Open: 647.34, High: 647.72, Low: 635.45, Close: 640.69 },
        { Open: 640.69, High: 644.99, Low: 626.23, Close: 626.96 },
        { Open: 626.96, High: 630.65, Low: 624.7, Close: 628.33 },
        { Open: 628.33, High: 636.09, Low: 627.56, Close: 631.71 },
        { Open: 631.71, High: 633.29, Low: 612.28, Close: 617.99 },
        { Open: 617.99, High: 623.68, Low: 615.9, Close: 620.22 },
        { Open: 620.22, High: 624.03, Low: 616.35, Close: 620.55 },
        { Open: 620.55, High: 621.59, Low: 608.58, Close: 615.11 },
        { Open: 615.11, High: 631.58, Low: 613.08, Close: 631.18 },
        { Open: 631.18, High: 636.64, Low: 626.22, Close: 634.48 },
        { Open: 634.48, High: 635.12, Low: 625.81, Close: 627.58 },
        { Open: 627.58, High: 627.94, Low: 616.16, Close: 618.38 },
        { Open: 618.38, High: 622.6, Low: 617.87, Close: 619.36 },
        { Open: 619.36, High: 620.72, Low: 612.89, Close: 615.2 },
        { Open: 615.2, High: 627.07, Low: 612., Close: 622.62 },
        { Open: 622.62, High: 628.22, Low: 616.66, Close: 628.22 },
        { Open: 628.22, High: 628.78, Low: 623.89, Close: 625.8 },
        { Open: 625.8, High: 625.8, Low: 618.8, Close: 621.37 },
        { Open: 621.37, High: 621.66, Low: 616.25, Close: 620.01 },
        { Open: 620.01, High: 622.59, Low: 618.81, Close: 618.81 },
        { Open: 618.81, High: 619.97, Low: 617.18, Close: 617.93 },
        { Open: 617.93, High: 618.6, Low: 591.58, Close: 600.01 },
        { Open: 600.01, High: 606.22, Low: 593.79, Close: 599.93 },
        { Open: 599.93, High: 599.93, Low: 590.21, Close: 593.85 },
        { Open: 593.85, High: 598.24, Low: 590.02, Close: 590.95 },
        { Open: 590.95, High: 623.06, Low: 511.87, Close: 584.69 },
        { Open: 584.69, High: 586.76, Low: 577.41, Close: 582.2 },
        { Open: 582.2, High: 582.2, Low: 560.2, Close: 564.37 },
        { Open: 564.37, High: 588.04, Low: 559.85, Close: 581.35 },
        { Open: 581.35, High: 601.94, Low: 581.35, Close: 595.08 },
        { Open: 595.08, High: 595.15, Low: 584.09, Close: 587.29 },
        { Open: 587.29, High: 588.43, Low: 577.82, Close: 585.51 },
        { Open: 585.51, High: 592.85, Low: 582.41, Close: 586.76 },
        { Open: 586.76, High: 588.09, Low: 580.07, Close: 583.11 },
        { Open: 583.11, High: 586.97, Low: 578.58, Close: 583.04 },
        { Open: 583.04, High: 590.83, Low: 581.94, Close: 587.4 },
        { Open: 587.4, High: 598.78, Low: 587.3, Close: 590.53 },
        { Open: 590.53, High: 590.53, Low: 585.1, Close: 588.09 },
        { Open: 588.09, High: 593.72, Low: 585.86, Close: 589.45 },
        { Open: 589.45, High: 589.87, Low: 570.64, Close: 573.31 },
        { Open: 573.31, High: 573.94, Low: 563., Close: 568.21 },
        { Open: 568.21, High: 571.22, Low: 524.45, Close: 544.57 },
        { Open: 544.57, High: 544.62, Low: 495.45, Close: 508.55 },
        { Open: 508.55, High: 517.25, Low: 483.58, Close: 496.62 },
        { Open: 496.62, High: 522.25, Low: 484.45, Close: 519.83 },
        { Open: 519.83, High: 520.04, Low: 482.91, Close: 492.95 },
        { Open: 492.95, High: 500.95, Low: 435.84, Close: 460.67 },
        { Open: 460.67, High: 488.69, Low: 451.41, Close: 486.74 },
        { Open: 486.74, High: 521.15, Low: 464.61, Close: 511.93 },
        { Open: 511.93, High: 532.99, Low: 511.21, Close: 516.16 },
        { Open: 516.16, High: 522.31, Low: 500.29, Close: 513.94 },
        { Open: 513.94, High: 513.97, Low: 490.82, Close: 497.22 },
        { Open: 497.22, High: 513.46, Low: 496.36, Close: 508.57 },
        { Open: 508.57, High: 508.7, Low: 497.88, Close: 501.63 },
        { Open: 501.63, High: 513.62, Low: 501.36, Close: 513.47 },
        { Open: 513.47, High: 521.59, Low: 510.03, Close: 510.43 },
        { Open: 510.43, High: 515.91, Low: 505.14, Close: 507.02 },
        { Open: 507.02, High: 512.3, Low: 502.64, Close: 508.42 },
        { Open: 508.42, High: 508.45, Low: 499.54, Close: 501.2 },
        { Open: 501.2, High: 502.73, Low: 475.29, Close: 478.07 },
        { Open: 478.07, High: 486.06, Low: 471.96, Close: 474.13 },
        { Open: 474.13, High: 483.4, Low: 471.07, Close: 475.32 },
        { Open: 475.32, High: 479.8, Low: 472.8, Close: 474.54 },
        { Open: 474.54, High: 494.29, Low: 474.1, Close: 489.09 },
        { Open: 489.09, High: 490.51, Low: 478.89, Close: 480.5 },
        { Open: 480.5, High: 484.9, Low: 479.53, Close: 482.24 },
        { Open: 482.24, High: 485.56, Low: 479.48, Close: 479.48 },
        { Open: 479.48, High: 479.82, Low: 464.71, Close: 472.15 },
        { Open: 472.15, High: 474.51, Low: 464.78, Close: 471.56 },
        { Open: 471.56, High: 487.33, Low: 471.56, Close: 477.53 },
        { Open: 477.53, High: 480.57, Low: 471.25, Close: 476.33 },
        { Open: 476.33, High: 476.5, Low: 467.28, Close: 473.83 },
        { Open: 473.83, High: 479.26, Low: 471.21, Close: 477.09 },
        { Open: 477.09, High: 477.89, Low: 473.44, Close: 474.71 },
        { Open: 474.71, High: 476.63, Low: 471.36, Close: 471.36 },
        { Open: 471.36, High: 472.99, Low: 461.88, Close: 463.74 },
        { Open: 463.74, High: 465.57, Low: 448.28, Close: 454.91 },
        { Open: 454.91, High: 455.35, Low: 405.37, Close: 421.46 },
        { Open: 421.46, High: 426.67, Low: 380.81, Close: 391.94 },
        { Open: 391.94, High: 423.19, Low: 386.14, Close: 406.82 },
        { Open: 406.82, High: 410.28, Low: 390.89, Close: 396.57 },
        { Open: 396.57, High: 405.25, Low: 392.8, Close: 398.89 },
        { Open: 398.89, High: 443.76, Low: 391.53, Close: 435.38 },
        { Open: 435.38, High: 436.98, Low: 419.17, Close: 422.3 },
        { Open: 422.3, High: 422.85, Low: 406.75, Close: 408.8 },
        { Open: 408.8, High: 414.33, Low: 396.21, Close: 401.92 },
        { Open: 401.92, High: 405.26, Low: 394.33, Close: 398.36 },
        { Open: 398.36, High: 400.54, Low: 370.21, Close: 376.2 },
        { Open: 376.2, High: 385.72, Low: 369.33, Close: 374.73 },
        { Open: 374.73, High: 394.17, Low: 372.11, Close: 386.27 },
        { Open: 386.27, High: 390.47, Low: 377.13, Close: 381.33 },
        { Open: 381.33, High: 382.8, Low: 369.57, Close: 371.99 },
        { Open: 371.99, High: 374.63, Low: 353.87, Close: 356.56 },
        { Open: 356.56, High: 362.18, Low: 321.95, Close: 325.49 },
        { Open: 325.49, High: 339.7, Low: 286.56, Close: 319.64 },
        { Open: 319.64, High: 343.75, Low: 301.41, Close: 328.46 },
        { Open: 328.46, High: 339.33, Low: 316.97, Close: 334.09 },
        { Open: 334.09, High: 354.37, Low: 325.51, Close: 352.79 },
        { Open: 352.79, High: 382.79, Low: 347.37, Close: 363.78 },
        { Open: 363.78, High: 375.12, Low: 351.7, Close: 358.69 },
        { Open: 358.69, High: 365.97, Low: 350.66, Close: 359.2 },
        { Open: 359.2, High: 377.97, Low: 352.57, Close: 376.19 },
        { Open: 376.19, High: 395.03, Low: 366.83, Close: 388.38 },
        { Open: 388.38, High: 409.89, Low: 388.3, Close: 398.71 },
        { Open: 398.71, High: 399.03, Low: 386.6, Close: 391.84 },
        { Open: 391.84, High: 396.27, Low: 369.53, Close: 380.08 },
        { Open: 380.08, High: 382.87, Low: 371.91, Close: 380.42 },
        { Open: 380.42, High: 393.12, Low: 375.57, Close: 388.96 },
        { Open: 388.96, High: 391.79, Low: 383.67, Close: 386.59 },
        { Open: 386.59, High: 386.92, Low: 377.19, Close: 379.37 },
        { Open: 379.37, High: 388.97, Low: 377.36, Close: 382.38 },
        { Open: 382.38, High: 384.5, Low: 377.85, Close: 379.1 },
        { Open: 379.1, High: 381.03, Low: 353.79, Close: 355.86 },
        { Open: 355.86, High: 360.61, Low: 351.21, Close: 355.17 },
        { Open: 355.17, High: 356.37, Low: 339.97, Close: 346.11 },
        { Open: 346.11, High: 358.04, Low: 343.45, Close: 351.54 },
        { Open: 351.54, High: 355.63, Low: 346.14, Close: 348.96 },
        { Open: 348.96, High: 354.76, Low: 348.02, Close: 351.9 },
        { Open: 351.9, High: 352.13, Low: 332.72, Close: 333.38 },
        { Open: 333.38, High: 350.44, Low: 332.88, Close: 343.78 },
        { Open: 343.78, High: 346.88, Low: 335.7, Close: 336.8 },
        { Open: 336.8, High: 338.45, Low: 320.32, Close: 325.39 },
        { Open: 325.39, High: 328.8, Low: 319.41, Close: 323.74 },
        { Open: 323.74, High: 333.76, Low: 323.56, Close: 324.23 },
        { Open: 324.23, High: 330.28, Low: 321.01, Close: 328.28 },
        { Open: 328.28, High: 341.68, Low: 328.28, Close: 337.14 },
        { Open: 337.14, High: 351.61, Low: 336.08, Close: 348.23 },
        { Open: 348.23, High: 351.47, Low: 340.19, Close: 341.08 },
        { Open: 341.08, High: 345.91, Low: 340.76, Close: 344.03 },
        { Open: 344.03, High: 363.99, Low: 342.55, Close: 363.31 },
        { Open: 363.31, High: 374.73, Low: 357.5, Close: 365.29 },
        { Open: 365.29, High: 370.92, Low: 360.58, Close: 366.99 },
        { Open: 366.99, High: 431.99, Low: 366.99, Close: 427.24 },
        { Open: 427.24, High: 458.15, Low: 385.87, Close: 417.15 },
        { Open: 417.15, High: 418.26, Low: 381.94, Close: 398.43 },
        { Open: 398.43, High: 406.18, Low: 368.6, Close: 375.13 },
        { Open: 375.13, High: 393.29, Low: 372.79, Close: 388.55 },
        { Open: 388.55, High: 410.21, Low: 375.6, Close: 385.86 },
        { Open: 385.86, High: 390.78, Low: 369.7, Close: 372.38 },
        { Open: 372.38, High: 385.33, Low: 371.44, Close: 377.24 },
        { Open: 377.24, High: 379.2, Low: 353.52, Close: 356.14 },
        { Open: 356.14, High: 356.21, Low: 342.2, Close: 348.86 },
        { Open: 348.86, High: 363.78, Low: 348.86, Close: 352.04 },
        { Open: 352.04, High: 370.86, Low: 351.74, Close: 366.77 },
        { Open: 366.77, High: 388.73, Low: 365.15, Close: 375.24 },
        { Open: 375.24, High: 393.26, Low: 374.12, Close: 375.72 },
        { Open: 375.72, High: 377.74, Low: 365.32, Close: 368.51 },
        { Open: 368.51, High: 373.45, Low: 367.56, Close: 369.14 },
        { Open: 369.14, High: 381.61, Low: 358.18, Close: 375.85 },
        { Open: 375.85, High: 385.65, Low: 372.35, Close: 375.22 },
        { Open: 375.22, High: 381.75, Low: 373.56, Close: 377.09 },
        { Open: 377.09, High: 382.66, Low: 375.49, Close: 378.64 },
        { Open: 378.64, High: 383.72, Low: 377.71, Close: 381.54 },
        { Open: 381.54, High: 383.08, Low: 374.11, Close: 374.97 },
        { Open: 374.97, High: 378.2, Low: 367.46, Close: 369.15 },
        { Open: 369.15, High: 378.34, Low: 365.68, Close: 376.04 },
        { Open: 376.04, High: 377.78, Low: 371.03, Close: 374.02 },
        { Open: 374.02, High: 375.92, Low: 372.78, Close: 374.26 },
        { Open: 374.26, High: 375.15, Low: 360.94, Close: 360.94 },
        { Open: 360.94, High: 362.28, Low: 344.29, Close: 351.27 },
        { Open: 351.27, High: 351.77, Low: 344.62, Close: 344.62 },
        { Open: 344.62, High: 361.11, Low: 337.68, Close: 347.13 },
        { Open: 347.13, High: 354.23, Low: 346.47, Close: 350.94 },
        { Open: 350.94, High: 351.11, Low: 344.9, Close: 347.47 },
        { Open: 347.47, High: 353.23, Low: 345.75, Close: 351.14 },
        { Open: 351.14, High: 351.25, Low: 344.01, Close: 345.1 },
        { Open: 345.1, High: 345.29, Low: 325.73, Close: 326.08 },
        { Open: 326.08, High: 333.26, Low: 314.58, Close: 319.17 },
        { Open: 319.17, High: 323.41, Low: 303.92, Close: 310.75 },
        { Open: 310.75, High: 317.74, Low: 306.47, Close: 317.01 },
        { Open: 317.01, High: 330.95, Low: 315.24, Close: 329.57 },
        { Open: 329.57, High: 329.57, Low: 317.62, Close: 319.24 },
        { Open: 319.24, High: 332.5, Low: 319.04, Close: 330.67 },
        { Open: 330.67, High: 335.95, Low: 328.22, Close: 334.05 },
        { Open: 334.05, High: 334.07, Low: 320.59, Close: 321.88 },
        { Open: 321.88, High: 322.36, Low: 317.08, Close: 318.61 },
        { Open: 318.61, High: 330.61, Low: 316.31, Close: 327.16 },
        { Open: 327.16, High: 327.95, Low: 312.16, Close: 315.17 },
        { Open: 315.17, High: 318.45, Low: 310.7, Close: 316.8 },
        { Open: 316.8, High: 319.78, Low: 311.84, Close: 312.44 },
        { Open: 312.44, High: 314.53, Low: 308.95, Close: 309.87 },
        { Open: 309.87, High: 319.7, Low: 309.42, Close: 319.7 },
        { Open: 319.7, High: 319.7, Low: 313.62, Close: 313.92 },
        { Open: 313.92, High: 315.72, Low: 312.77, Close: 314.59 },
        { Open: 314.59, High: 314.9, Low: 279.85, Close: 279.85 },
        { Open: 279.85, High: 286.36, Low: 257.09, Close: 263.63 },
        { Open: 263.63, High: 278., Low: 263.63, Close: 272.95 },
        { Open: 272.95, High: 287.21, Low: 271.11, Close: 285.58 },
        { Open: 285.58, High: 300.3, Low: 283.06, Close: 294.88 },
        { Open: 294.88, High: 294.98, Low: 282.58, Close: 283.25 },
        { Open: 283.25, High: 291.45, Low: 280.41, Close: 288.84 },
        { Open: 288.84, High: 289.67, Low: 272.86, Close: 274.07 },
        { Open: 274.07, High: 279.07, Low: 263.94, Close: 265.37 },
        { Open: 265.37, High: 271.79, Low: 264.26, Close: 267.09 },
        { Open: 267.09, High: 267.3, Low: 219.69, Close: 226.98 },
        { Open: 226.98, High: 226.98, Low: 170.21, Close: 177.28 },
        { Open: 177.28, High: 229.31, Low: 174.94, Close: 210.46 },
        { Open: 210.46, High: 222.01, Low: 199.18, Close: 207.22 },
        { Open: 207.22, High: 211.51, Low: 195.19, Close: 199.62 },
        { Open: 199.62, High: 218.98, Low: 194.55, Close: 209.93 },
        { Open: 209.93, High: 216.68, Low: 206.66, Close: 213.98 },
        { Open: 213.98, High: 214.41, Low: 204.8, Close: 210.48 },
        { Open: 210.48, High: 226.9, Low: 210.48, Close: 225.98 },
        { Open: 225.98, High: 236.84, Low: 225.16, Close: 232.66 },
        { Open: 232.66, High: 235.03, Low: 224.4, Close: 232.97 },
        { Open: 232.97, High: 248.44, Low: 230.21, Close: 247.99 },
        { Open: 247.99, High: 255.76, Low: 243.3, Close: 254.51 },
        { Open: 254.51, High: 307.97, Low: 254.51, Close: 271.95 },
        { Open: 271.95, High: 274.88, Low: 250.94, Close: 262.06 },
        { Open: 262.06, High: 265.14, Low: 225.27, Close: 233.21 },
        { Open: 233.21, High: 238.06, Low: 220.1, Close: 232.4 },
        { Open: 232.4, High: 242.72, Low: 225.29, Close: 226.5 },
        { Open: 226.5, High: 233.53, Low: 216.11, Close: 216.91 },
        { Open: 216.91, High: 231.92, Low: 211.53, Close: 226.4 },
        { Open: 226.4, High: 242.22, Low: 222.22, Close: 237.54 },
        { Open: 237.54, High: 246.19, Low: 224.11, Close: 226.96 },
        { Open: 226.96, High: 230.02, Low: 220.72, Close: 226.73 },
        { Open: 226.73, High: 227.96, Low: 214.66, Close: 216.77 },
        { Open: 216.77, High: 225.54, Low: 216.37, Close: 222.48 },
        { Open: 222.48, High: 230.16, Low: 222.48, Close: 227.33 },
        { Open: 227.33, High: 229.33, Low: 219.96, Close: 222.87 },
        { Open: 222.87, High: 223.95, Low: 217.04, Close: 220.17 },
        { Open: 220.17, High: 222.21, Low: 215.45, Close: 220.08 },
        { Open: 220.08, High: 223.55, Low: 218.17, Close: 219.49 },
        { Open: 219.49, High: 222.18, Low: 217.62, Close: 221.85 },
        { Open: 221.85, High: 240.24, Low: 221.07, Close: 235.79 },
        { Open: 235.79, High: 260.46, Low: 235.75, Close: 257.47 },
        { Open: 257.47, High: 267.35, Low: 226.91, Close: 234.33 },
        { Open: 234.33, High: 239.59, Low: 228.31, Close: 233.56 },
        { Open: 233.56, High: 246.14, Low: 232.13, Close: 243.6 },
        { Open: 243.6, High: 244.35, Low: 231.75, Close: 236.21 },
        { Open: 236.21, High: 243.11, Low: 235.46, Close: 239.83 },
        { Open: 239.83, High: 247.14, Low: 239.22, Close: 243.78 },
        { Open: 243.78, High: 246.46, Low: 242.93, Close: 244.26 },
        { Open: 244.26, High: 246.23, Low: 233.07, Close: 235.53 },
        { Open: 235.53, High: 239.63, Low: 231.77, Close: 238.08 },
        { Open: 238.08, High: 239.49, Low: 235.74, Close: 238.76 },
        { Open: 238.76, High: 239.36, Low: 235.55, Close: 237.25 },
        { Open: 237.25, High: 237.77, Low: 233.86, Close: 236.1 },
        { Open: 236.1, High: 257.5, Low: 235.65, Close: 252.51 },
        { Open: 252.51, High: 254.19, Low: 248.78, Close: 253.53 },
        { Open: 253.53, High: 260.64, Low: 244.97, Close: 258.74 },
        { Open: 258.74, High: 272.47, Low: 257.06, Close: 271.35 },
        { Open: 271.35, High: 286.28, Low: 267.04, Close: 281.45 },
        { Open: 281.45, High: 283.38, Low: 266.47, Close: 271.92 },
        { Open: 271.92, High: 280.4, Low: 263.63, Close: 274.86 },
        { Open: 274.86, High: 276.7, Low: 269.39, Close: 272.21 },
        { Open: 272.21, High: 277.7, Low: 269.62, Close: 275.89 },
        { Open: 275.89, High: 277.34, Low: 271.98, Close: 274.48 },
        { Open: 274.48, High: 291.96, Low: 274., Close: 288.52 },
        { Open: 288.52, High: 300.34, Low: 288.52, Close: 290.51 },
        { Open: 290.51, High: 296.74, Low: 288.88, Close: 295.83 },
        { Open: 295.83, High: 296.74, Low: 291.83, Close: 293.87 },
        { Open: 293.87, High: 293.99, Low: 284.28, Close: 284.28 },
        { Open: 284.28, High: 286.19, Low: 280.27, Close: 281.36 },
        { Open: 281.36, High: 286.15, Low: 280.67, Close: 285.34 },
        { Open: 285.34, High: 293.93, Low: 285.31, Close: 290.38 },
        { Open: 290.38, High: 291.75, Low: 283.4, Close: 284.46 },
        { Open: 284.46, High: 284.59, Low: 248.73, Close: 255.37 },
        { Open: 255.37, High: 263.09, Low: 246.78, Close: 259.74 },
        { Open: 259.74, High: 264.24, Low: 258.39, Close: 260.84 },
        { Open: 260.84, High: 262.14, Low: 254.79, Close: 259.62 },
        { Open: 259.62, High: 269.98, Low: 259.07, Close: 267.8 },
        { Open: 267.8, High: 270.04, Low: 260.65, Close: 265.94 },
        { Open: 265.94, High: 266.4, Low: 242.88, Close: 245.44 },
        { Open: 245.44, High: 249.2, Low: 236.05, Close: 246.13 },
        { Open: 246.13, High: 254.44, Low: 244.72, Close: 247.65 },
        { Open: 247.65, High: 249.21, Low: 244.38, Close: 246.58 },
        { Open: 246.58, High: 254.11, Low: 246.18, Close: 252.25 },
        { Open: 252.25, High: 252.38, Low: 239.43, Close: 242.02 },
        { Open: 242.02, High: 248.6, Low: 236.44, Close: 246.85 },
        { Open: 246.85, High: 248.18, Low: 241.14, Close: 243.39 },
        { Open: 243.39, High: 247.06, Low: 240.13, Close: 246.55 },
        { Open: 246.55, High: 254.2, Low: 244.29, Close: 252.26 },
        { Open: 252.26, High: 255.75, Low: 251.17, Close: 253.54 },
        { Open: 253.54, High: 254.58, Low: 250.34, Close: 253.12 },
        { Open: 253.12, High: 260.09, Low: 251.12, Close: 259.95 },
        { Open: 259.95, High: 261.15, Low: 253.18, Close: 254.52 },
        { Open: 254.52, High: 255.23, Low: 251.09, Close: 252.8 },
        { Open: 252.8, High: 253.38, Low: 242.59, Close: 244.36 },
        { Open: 244.36, High: 245.72, Low: 237.9, Close: 243.26 },
        { Open: 243.26, High: 243.42, Low: 231.78, Close: 235.22 },
        { Open: 235.22, High: 239.65, Low: 233.42, Close: 236.12 },
        { Open: 236.12, High: 237.11, Low: 232.65, Close: 235.64 },
        { Open: 235.64, High: 236.79, Low: 220.58, Close: 223.41 },
        { Open: 223.41, High: 224.27, Low: 215.46, Close: 218.27 },
        { Open: 218.27, High: 223.6, Low: 217.84, Close: 223.57 },
        { Open: 223.57, High: 229.28, Low: 223.28, Close: 228.11 },
        { Open: 228.11, High: 228.37, Low: 221.11, Close: 222.23 },
        { Open: 222.23, High: 223.87, Low: 220.12, Close: 222.84 },
        { Open: 222.84, High: 226.13, Low: 221.5, Close: 221.69 },
        { Open: 221.69, High: 226.22, Low: 221.13, Close: 224.31 },
        { Open: 224.31, High: 235.92, Low: 223.7, Close: 235.81 },
        { Open: 235.81, High: 238.18, Low: 230.97, Close: 233.92 },
        { Open: 233.92, High: 236.33, Low: 232.81, Close: 235.56 },
        { Open: 235.56, High: 235.8, Low: 229.25, Close: 230.79 },
        { Open: 230.79, High: 232.11, Low: 225.8, Close: 225.85 },
        { Open: 225.85, High: 226.44, Low: 214.28, Close: 218.81 },
        { Open: 218.81, High: 232.54, Low: 217.5, Close: 228.5 },
        { Open: 228.5, High: 230.4, Low: 222.87, Close: 225.68 },
        { Open: 225.68, High: 227.17, Low: 223.21, Close: 225.98 },
        { Open: 225.98, High: 240.27, Low: 225.42, Close: 236.57 },
        { Open: 236.57, High: 239.34, Low: 231.91, Close: 232.12 },
        { Open: 232.12, High: 235.82, Low: 232.12, Close: 234.9 },
        { Open: 234.9, High: 243.62, Low: 233.82, Close: 240.12 },
        { Open: 240.12, High: 242.83, Low: 237.55, Close: 238.77 },
        { Open: 238.77, High: 239.22, Low: 231.9, Close: 236.55 },
        { Open: 236.55, High: 236.87, Low: 228.74, Close: 230.05 },
        { Open: 230.05, High: 239.93, Low: 228.72, Close: 237.78 },
        { Open: 237.78, High: 246.08, Low: 236.09, Close: 243.39 },
        { Open: 243.39, High: 247.73, Low: 238.17, Close: 240.48 },
        { Open: 240.48, High: 244.28, Low: 237.76, Close: 239.63 },
        { Open: 239.63, High: 244.07, Low: 238.78, Close: 241.85 },
        { Open: 241.85, High: 242.84, Low: 239.46, Close: 240.99 },
        { Open: 240.99, High: 243.65, Low: 234.1, Close: 235.8 },
        { Open: 235.8, High: 238.32, Low: 232.58, Close: 236.74 },
        { Open: 236.74, High: 238.64, Low: 235.64, Close: 237.31 },
        { Open: 237.31, High: 237.45, Low: 234.69, Close: 235.73 },
        { Open: 235.73, High: 237.59, Low: 235.5, Close: 236.1 },
        { Open: 236.1, High: 236.85, Low: 231.74, Close: 232.87 },
        { Open: 232.87, High: 234., Low: 231.75, Close: 231.94 },
        { Open: 231.94, High: 234.89, Low: 231.72, Close: 234.25 },
        { Open: 234.25, High: 236.45, Low: 233.84, Close: 235.3 },
        { Open: 235.3, High: 241.4, Low: 235.03, Close: 240.52 },
        { Open: 240.52, High: 241.68, Low: 238.44, Close: 239.03 },
        { Open: 239.03, High: 244.19, Low: 236.86, Close: 241.19 },
        { Open: 241.19, High: 241.58, Low: 236.67, Close: 237.49 },
        { Open: 237.49, High: 238.73, Low: 235.7, Close: 237.33 },
        { Open: 237.33, High: 238.8, Low: 236.43, Close: 237.18 },
        { Open: 237.18, High: 237.9, Low: 236.54, Close: 237.47 },
        { Open: 237.47, High: 237.56, Low: 235.44, Close: 237.1 },
        { Open: 237.1, High: 237.14, Low: 231.99, Close: 233.29 },
        { Open: 233.29, High: 233.4, Low: 229.12, Close: 230. },
        { Open: 230., High: 231.78, Low: 221.71, Close: 223.31 },
        { Open: 223.31, High: 226.67, Low: 222.85, Close: 225.75 },
        { Open: 225.75, High: 227.39, Low: 223.8, Close: 225.65 },
        { Open: 225.65, High: 226.48, Low: 223.86, Close: 224.37 },
        { Open: 224.37, High: 226.03, Low: 223.08, Close: 225.04 },
        { Open: 225.04, High: 226.01, Low: 224.43, Close: 225.68 },
        { Open: 225.68, High: 226.33, Low: 222.81, Close: 223.39 },
        { Open: 223.39, High: 229.77, Low: 223.38, Close: 228.65 },
        { Open: 228.65, High: 231.16, Low: 227.95, Close: 229.33 },
        { Open: 229.33, High: 230.15, Low: 227.95, Close: 228.95 },
        { Open: 228.95, High: 230.39, Low: 228.85, Close: 230.02 },
        { Open: 230.02, High: 231.56, Low: 229.6, Close: 230.2 },
        { Open: 230.2, High: 233.13, Low: 229.42, Close: 232.75 },
        { Open: 232.75, High: 235.53, Low: 232.39, Close: 233.85 },
        { Open: 233.85, High: 238.6, Low: 233.78, Close: 237.31 },
        { Open: 237.31, High: 254.1, Low: 236.48, Close: 250.9 },
        { Open: 250.9, High: 257.87, Low: 246.03, Close: 249.17 },
        { Open: 249.17, High: 251.67, Low: 243.47, Close: 248.87 },
        { Open: 248.87, High: 250.66, Low: 242.56, Close: 243.55 },
        { Open: 243.55, High: 246.47, Low: 239.56, Close: 245.26 },
        { Open: 245.26, High: 245.32, Low: 241.57, Close: 244.01 },
        { Open: 244.01, High: 248.21, Low: 243.52, Close: 246.77 },
        { Open: 246.77, High: 247.27, Low: 242.87, Close: 243.99 },
        { Open: 243.99, High: 244.01, Low: 239.97, Close: 240.22 },
        { Open: 240.22, High: 243.62, Low: 239.93, Close: 242.42 },
        { Open: 242.42, High: 242.92, Low: 240.67, Close: 242.64 },
        { Open: 242.64, High: 251.09, Low: 242.15, Close: 250.71 },
        { Open: 250.71, High: 250.71, Low: 246.67, Close: 248.07 },
        { Open: 248.07, High: 256.71, Low: 247.97, Close: 256.49 },
        { Open: 256.49, High: 268.23, Low: 255.38, Close: 262.48 },
        { Open: 262.48, High: 264.54, Low: 254.74, Close: 257.66 },
        { Open: 257.66, High: 260.96, Low: 253.41, Close: 254.35 },
        { Open: 254.35, High: 256.09, Low: 252.29, Close: 255.6 },
        { Open: 255.6, High: 261.06, Low: 253.01, Close: 260.35 },
        { Open: 260.35, High: 273.82, Low: 257.67, Close: 271.02 },
        { Open: 271.02, High: 276.27, Low: 266.84, Close: 268.49 },
        { Open: 268.49, High: 270.18, Low: 263.11, Close: 264.96 },
        { Open: 264.96, High: 272.38, Low: 263.56, Close: 269.65 },
        { Open: 269.65, High: 271.98, Low: 265.47, Close: 268.11 },
        { Open: 268.11, High: 295.01, Low: 267.69, Close: 283.88 },
        { Open: 283.88, High: 298.58, Low: 282.48, Close: 291.69 },
        { Open: 291.69, High: 313.77, Low: 290.9, Close: 309.98 },
        { Open: 309.98, High: 310.09, Low: 277.76, Close: 290.88 },
        { Open: 290.88, High: 295.88, Low: 285.34, Close: 286.19 },
        { Open: 286.19, High: 292.33, Low: 282.45, Close: 283.82 },
        { Open: 283.82, High: 289.94, Low: 274.43, Close: 277.83 },
        { Open: 277.83, High: 279.66, Low: 271.62, Close: 278.49 },
        { Open: 278.49, High: 282.31, Low: 273.08, Close: 274.49 },
        { Open: 274.49, High: 276.63, Low: 272.29, Close: 272.49 },
        { Open: 272.49, High: 278.47, Low: 271.63, Close: 278.41 },
        { Open: 278.41, High: 280.47, Low: 274.8, Close: 275.1 },
        { Open: 275.1, High: 277.01, Low: 273.87, Close: 276.62 },
        { Open: 276.62, High: 277.49, Low: 275.21, Close: 275.63 },
        { Open: 275.63, High: 289.58, Low: 275.09, Close: 287.97 },
        { Open: 287.97, High: 290.59, Low: 285.63, Close: 288.13 },
        { Open: 288.13, High: 292.51, Low: 287.23, Close: 291.64 },
        { Open: 291.64, High: 295.68, Low: 285.93, Close: 292.73 },
        { Open: 292.73, High: 296.15, Low: 292.11, Close: 293.79 },
        { Open: 293.79, High: 293.91, Low: 287.8, Close: 288.77 },
        { Open: 288.77, High: 289.72, Low: 285.51, Close: 287.29 },
        { Open: 287.29, High: 288.58, Low: 281.77, Close: 283.94 },
        { Open: 283.94, High: 284.31, Low: 276.98, Close: 280.04 },
        { Open: 280.04, High: 282.13, Low: 276.69, Close: 281.65 },
        { Open: 281.65, High: 284.79, Low: 279.33, Close: 280.48 },
        { Open: 280.48, High: 285.18, Low: 280.46, Close: 284.5 },
        { Open: 284.5, High: 285.04, Low: 281.02, Close: 281.38 },
        { Open: 281.38, High: 281.38, Low: 277.79, Close: 278.25 },
        { Open: 278.25, High: 279.72, Low: 275.49, Close: 279.03 },
        { Open: 279.03, High: 279.21, Low: 259.27, Close: 260.2 },
        { Open: 260.2, High: 266.8, Low: 259.7, Close: 264.44 },
        { Open: 264.44, High: 266.35, Low: 261.96, Close: 263.76 },
        { Open: 263.76, High: 270.97, Low: 263.64, Close: 270.92 },
        { Open: 270.92, High: 271.2, Low: 264.81, Close: 265.64 },
        { Open: 265.64, High: 265.95, Low: 262.17, Close: 263.34 },
        { Open: 263.34, High: 267.06, Low: 261.13, Close: 264.87 },
        { Open: 264.87, High: 265.99, Low: 260.13, Close: 260.73 },
        { Open: 260.73, High: 261.7, Low: 255.74, Close: 257.67 },
        { Open: 257.67, High: 259.64, Low: 256.05, Close: 256.98 },
        { Open: 256.98, High: 257.12, Low: 214.03, Close: 219. },
        { Open: 219., High: 236.55, Low: 219., Close: 225.39 },
        { Open: 225.39, High: 236.63, Low: 225.39, Close: 234.69 },
        { Open: 234.69, High: 235.86, Low: 230.82, Close: 231.94 },
        { Open: 231.94, High: 234.27, Low: 221.82, Close: 229.74 },
        { Open: 229.74, High: 232.03, Low: 224.98, Close: 227.59 },
        { Open: 227.59, High: 227.59, Low: 208.79, Close: 209.13 },
        { Open: 209.13, High: 226.28, Low: 198.23, Close: 221.71 },
        { Open: 221.71, High: 230.4, Low: 219.71, Close: 225.38 },
        { Open: 225.38, High: 228.03, Low: 222.85, Close: 224.26 },
        { Open: 224.26, High: 234.72, Low: 219.91, Close: 230.98 },
        { Open: 230.98, High: 232.93, Low: 227., Close: 229.76 },
        { Open: 229.76, High: 231.77, Low: 225.32, Close: 228.61 },
        { Open: 228.61, High: 231.88, Low: 224.81, Close: 230.02 },
        { Open: 230.02, High: 231.21, Low: 226.08, Close: 227.35 },
        { Open: 227.35, High: 230.06, Low: 225.67, Close: 228.86 },
        { Open: 228.86, High: 229.25, Low: 226.12, Close: 226.76 },
        { Open: 226.76, High: 230.61, Low: 226.54, Close: 230.09 },
        { Open: 230.09, High: 236.26, Low: 229.16, Close: 234.68 },
        { Open: 234.68, High: 243.14, Low: 234.4, Close: 239.44 },
        { Open: 239.44, High: 242.19, Low: 238.34, Close: 240.02 },
        { Open: 240.02, High: 245.83, Low: 239.84, Close: 243.55 },
        { Open: 243.55, High: 244.49, Low: 237.41, Close: 238.29 },
        { Open: 238.29, High: 240.72, Low: 235.68, Close: 238.59 },
        { Open: 238.59, High: 241.15, Low: 238.55, Close: 240.08 },
        { Open: 240.08, High: 240.11, Low: 234.19, Close: 234.82 },
        { Open: 234.82, High: 235.64, Low: 228.98, Close: 230.33 },
        { Open: 230.33, High: 232.49, Low: 227.78, Close: 230.24 },
        { Open: 230.24, High: 231.56, Low: 229.41, Close: 229.92 },
        { Open: 229.92, High: 231.01, Low: 226.69, Close: 228.8 },
        { Open: 228.8, High: 234.62, Low: 228.39, Close: 232.79 },
        { Open: 232.79, High: 234.31, Low: 231.76, Close: 232.72 },
        { Open: 232.72, High: 233.2, Low: 230.83, Close: 231.24 },
        { Open: 231.24, High: 232.08, Low: 230.66, Close: 230.86 },
        { Open: 230.86, High: 231.26, Low: 226.15, Close: 226.61 },
        { Open: 226.61, High: 232.11, Low: 224.6, Close: 230.52 },
        { Open: 230.52, High: 231.74, Low: 229.16, Close: 229.96 },
        { Open: 229.96, High: 235.54, Low: 229.94, Close: 234.28 },
        { Open: 234.28, High: 237.11, Low: 233.5, Close: 234.84 },
        { Open: 234.84, High: 235.14, Low: 233.18, Close: 234.21 },
        { Open: 234.21, High: 234.48, Low: 232.65, Close: 232.85 },
        { Open: 232.85, High: 239.69, Low: 232.77, Close: 239.34 },
        { Open: 239.34, High: 240.32, Low: 236.16, Close: 236.62 },
        { Open: 236.62, High: 238.12, Low: 235.44, Close: 236.25 },
        { Open: 236.25, High: 238.95, Low: 235.96, Close: 237.57 },
        { Open: 237.57, High: 238.83, Low: 236.98, Close: 237.4 },
        { Open: 237.4, High: 239.6, Low: 237.23, Close: 239.09 },
        { Open: 239.09, High: 239.5, Low: 238.45, Close: 238.69 },
        { Open: 238.69, High: 240.65, Low: 237.22, Close: 240.59 },
        { Open: 240.59, High: 247.57, Low: 240.34, Close: 246.42 },
        { Open: 246.42, High: 246.95, Low: 242.8, Close: 243.27 },
        { Open: 243.27, High: 244.71, Low: 242.58, Close: 242.69 },
        { Open: 242.69, High: 244.45, Low: 242.36, Close: 244.32 },
        { Open: 244.32, High: 245.59, Low: 243.28, Close: 245.33 },
        { Open: 245.33, High: 248.22, Low: 244.77, Close: 247.53 },
        { Open: 247.53, High: 247.77, Low: 245.07, Close: 245.59 },
        { Open: 245.59, High: 250.55, Low: 243.88, Close: 249.94 },
        { Open: 249.94, High: 254.94, Low: 249.27, Close: 252.59 },
        { Open: 252.59, High: 256.66, Low: 252.54, Close: 254.81 },
        { Open: 254.81, High: 266.96, Low: 254.57, Close: 262.94 },
        { Open: 262.94, High: 274.54, Low: 262.7, Close: 271.2 },
        { Open: 271.2, High: 272.28, Low: 261.38, Close: 262.9 },
        { Open: 262.9, High: 265.54, Low: 261.63, Close: 264.42 },
        { Open: 264.42, High: 272.22, Low: 264.02, Close: 270.22 },
        { Open: 270.22, High: 271.59, Low: 264.12, Close: 267.33 },
        { Open: 267.33, High: 278.61, Low: 267.3, Close: 274.41 },
        { Open: 274.41, High: 279.11, Low: 274.23, Close: 277.46 },
        { Open: 277.46, High: 282.96, Low: 277.45, Close: 282.66 },
        { Open: 282.66, High: 294.61, Low: 282.45, Close: 283.07 },
        { Open: 283.07, High: 286.14, Low: 280.9, Close: 286.13 },
        { Open: 286.13, High: 297.16, Low: 286.1, Close: 294.4 },
        { Open: 294.4, High: 306.59, Low: 294.4, Close: 303.89 },
        { Open: 303.89, High: 318.72, Low: 301.06, Close: 313.59 },
        { Open: 313.59, High: 333.75, Low: 313.39, Close: 326. },
        { Open: 326., High: 331.04, Low: 306.73, Close: 312.43 },
        { Open: 312.43, High: 327.72, Low: 310.32, Close: 325.08 },
        { Open: 325.08, High: 364.77, Low: 322.07, Close: 359.35 },
        { Open: 359.35, High: 416.62, Low: 355.81, Close: 400.71 },
        { Open: 400.71, High: 492.4, Low: 374.33, Close: 408.74 },
        { Open: 408.74, High: 447.25, Low: 375.47, Close: 387.51 },
        { Open: 387.51, High: 395.99, Low: 353.62, Close: 374.95 },
        { Open: 374.95, High: 392.29, Low: 372.32, Close: 384.8 },
        { Open: 384.8, High: 389.85, Low: 366.47, Close: 373.49 },
        { Open: 373.49, High: 386.63, Low: 361.54, Close: 380.04 },
        { Open: 380.04, High: 381.72, Low: 326.32, Close: 337.93 },
        { Open: 337.93, High: 341.32, Low: 298.75, Close: 312.58 },
        { Open: 312.58, High: 345.6, Low: 312.58, Close: 336.86 },
        { Open: 336.86, High: 342.57, Low: 325.74, Close: 337.29 },
        { Open: 337.29, High: 339.3, Low: 329.19, Close: 333.55 },
        { Open: 333.55, High: 335.34, Low: 316.32, Close: 319.93 },
        { Open: 319.93, High: 333.01, Low: 315.42, Close: 331.59 },
        { Open: 331.59, High: 340.35, Low: 330.5, Close: 335.77 },
        { Open: 335.77, High: 337.16, Low: 329.91, Close: 334.97 },
        { Open: 334.97, High: 335.63, Low: 324.82, Close: 326.31 },
        { Open: 326.31, High: 326.76, Low: 311.75, Close: 321.99 },
        { Open: 321.99, High: 328.37, Low: 318.82, Close: 327.17 },
        { Open: 327.17, High: 327.22, Low: 320.99, Close: 324.34 },
        { Open: 324.34, High: 326.06, Low: 321.26, Close: 323.26 },
        { Open: 323.26, High: 323.26, Low: 317.42, Close: 320.16 },
        { Open: 320.16, High: 330.56, Low: 316.26, Close: 328.98 },
        { Open: 328.98, High: 368.51, Low: 328.88, Close: 353.3 },
        { Open: 353.3, High: 364.06, Low: 347.84, Close: 358.18 },
        { Open: 358.18, High: 360.15, Low: 351.23, Close: 357.66 },
        { Open: 357.66, High: 373.64, Low: 355.13, Close: 371.86 },
        { Open: 371.86, High: 382.49, Low: 369.34, Close: 376.91 },
        { Open: 376.91, High: 379.2, Low: 355.46, Close: 362.73 },
        { Open: 362.73, High: 362.73, Low: 348.11, Close: 359.43 },
        { Open: 359.43, High: 370.8, Low: 356.24, Close: 361.31 },
        { Open: 361.31, High: 364.18, Low: 355.43, Close: 363.48 },
        { Open: 363.48, High: 390.64, Low: 363.4, Close: 388.86 },
        { Open: 388.86, High: 402.3, Low: 385.37, Close: 388.46 },
        { Open: 388.46, High: 399.84, Low: 383.67, Close: 395.86 },
        { Open: 395.86, High: 418.14, Low: 389.58, Close: 418.14 },
        { Open: 418.14, High: 423.91, Low: 405.31, Close: 418.04 },
        { Open: 418.04, High: 419.97, Low: 411.28, Close: 415.25 },
        { Open: 415.25, High: 454.2, Low: 415.22, Close: 453.9 },
        { Open: 453.9, High: 470.88, Low: 408.91, Close: 435.9 },
        { Open: 435.9, High: 442.47, Low: 422.06, Close: 433.54 },
        { Open: 433.54, High: 447.77, Low: 429.14, Close: 443.84 },
        { Open: 443.84, High: 465.65, Low: 443.73, Close: 465.5 },
        { Open: 465.5, High: 465.5, Low: 440.2, Close: 455.37 },
        { Open: 455.37, High: 458.46, Low: 449.62, Close: 455.99 },
        { Open: 455.99, High: 466.46, Low: 454.52, Close: 463.84 },
        { Open: 463.84, High: 465.99, Low: 453.31, Close: 462.23 },
        { Open: 462.23, High: 462.43, Low: 432.81, Close: 442.5 },
        { Open: 442.5, High: 445.53, Low: 425.03, Close: 437.76 },
        { Open: 437.76, High: 443.22, Low: 433.77, Close: 435.5 },
        { Open: 435.5, High: 445.19, Low: 435., Close: 442.84 },
        { Open: 442.84, High: 459.84, Low: 442.84, Close: 454.85 },
        { Open: 454.85, High: 458.67, Low: 450.65, Close: 455.31 },
        { Open: 455.31, High: 457.66, Low: 406.39, Close: 417.22 },
        { Open: 417.22, High: 425.14, Low: 408.65, Close: 422.52 },
        { Open: 422.52, High: 429.09, Low: 417.23, Close: 421.26 },
        { Open: 421.26, High: 432.78, Low: 419.16, Close: 432.62 },
        { Open: 432.62, High: 434.22, Low: 421.19, Close: 426.14 },
        { Open: 426.14, High: 433.03, Low: 417.7, Close: 430.05 },
        { Open: 430.05, High: 436.11, Low: 427.32, Close: 434.46 },
        { Open: 434.46, High: 436.19, Low: 431.57, Close: 433.59 },
        { Open: 433.59, High: 433.95, Low: 424.15, Close: 430.36 },
        { Open: 430.36, High: 435.15, Low: 429.42, Close: 433.49 },
        { Open: 433.49, High: 434.7, Low: 429.09, Close: 432.25 },
        { Open: 432.25, High: 432.25, Low: 426.17, Close: 429.46 },
        { Open: 429.46, High: 460.09, Low: 429.06, Close: 458.28 },
        { Open: 458.28, High: 463.95, Low: 447.39, Close: 453.37 },
        { Open: 453.37, High: 455.11, Low: 447.3, Close: 449.14 },
        { Open: 449.14, High: 449.84, Low: 441.19, Close: 448.96 },
        { Open: 448.96, High: 451.44, Low: 443.26, Close: 448.38 },
        { Open: 448.38, High: 448.4, Low: 432.53, Close: 432.88 },
        { Open: 432.88, High: 435.66, Low: 422.1, Close: 432.04 },
        { Open: 432.04, High: 433.67, Low: 427.03, Close: 429.73 },
        { Open: 429.73, High: 429.81, Low: 358.77, Close: 358.77 },
        { Open: 358.77, High: 390.8, Low: 353.28, Close: 387.66 },
        { Open: 387.66, High: 390.59, Low: 378.26, Close: 380.21 },
        { Open: 380.21, High: 387.48, Low: 374.48, Close: 385.84 },
        { Open: 385.84, High: 386.64, Low: 376.72, Close: 377.74 },
        { Open: 377.74, High: 424.65, Low: 374.22, Close: 418.74 },
        { Open: 418.74, High: 422.66, Low: 405.44, Close: 409.94 },
        { Open: 409.94, High: 410.46, Low: 374.14, Close: 381.76 },
        { Open: 381.76, High: 394.5, Low: 381.19, Close: 386.19 },
        { Open: 386.19, High: 405.8, Low: 386.15, Close: 402.61 },
        { Open: 402.61, High: 402.64, Low: 386.52, Close: 390.66 },
        { Open: 390.66, High: 397.57, Low: 388.03, Close: 391.43 },
        { Open: 391.43, High: 396.57, Low: 390.49, Close: 394.63 },
        { Open: 394.63, High: 394.99, Low: 377.09, Close: 379.38 },
        { Open: 379.38, High: 384.49, Low: 363.64, Close: 378.2 },
        { Open: 378.2, High: 380.7, Low: 375.43, Close: 376.94 },
        { Open: 376.94, High: 379.53, Low: 364.29, Close: 367.13 },
        { Open: 367.13, High: 378.52, Low: 365.95, Close: 371.25 },
        { Open: 371.25, High: 374.83, Low: 371.1, Close: 372.88 },
        { Open: 372.88, High: 373.79, Low: 366.32, Close: 368.93 },
        { Open: 368.93, High: 391.27, Low: 368.74, Close: 388.61 },
        { Open: 388.61, High: 390.19, Low: 384.24, Close: 385.34 },
        { Open: 385.34, High: 385.34, Low: 370.6, Close: 375.4 },
        { Open: 375.4, High: 379.56, Low: 372.88, Close: 375.28 },
        { Open: 375.28, High: 378.69, Low: 370.77, Close: 371.1 },
        { Open: 371.1, High: 376.29, Low: 370.91, Close: 373.32 },
        { Open: 373.32, High: 383.56, Low: 372.93, Close: 379.96 },
        { Open: 379.96, High: 381.2, Low: 373.22, Close: 377.72 },
        { Open: 377.72, High: 383.54, Low: 377.31, Close: 383.13 },
        { Open: 383.13, High: 392.34, Low: 383.05, Close: 392.18 },
        { Open: 392.18, High: 407.17, Low: 392.18, Close: 406.74 },
        { Open: 406.74, High: 410.24, Low: 395.48, Close: 399.48 },
        { Open: 399.48, High: 408.12, Low: 399.3, Close: 407.36 },
        { Open: 407.36, High: 421.02, Low: 405.87, Close: 415.56 },
        { Open: 415.56, High: 424.98, Low: 415.01, Close: 421.64 },
        { Open: 421.64, High: 422.43, Low: 415.68, Close: 420.33 },
        { Open: 420.33, High: 443.18, Low: 420.27, Close: 436.52 },
        { Open: 436.52, High: 448.29, Low: 427., Close: 438.98 },
        { Open: 438.98, High: 439.66, Low: 432.65, Close: 438.07 },
        { Open: 438.07, High: 440.7, Low: 415.61, Close: 419.98 },
        { Open: 419.98, High: 424.84, Low: 411.12, Close: 424.36 },
        { Open: 424.36, High: 427.03, Low: 418.19, Close: 423.52 },
        { Open: 423.52, High: 432.06, Low: 419.53, Close: 432.06 },
        { Open: 432.06, High: 434.77, Low: 429.85, Close: 432.14 },
        { Open: 432.14, High: 435.35, Low: 422.07, Close: 432.64 },
        { Open: 432.64, High: 441.65, Low: 430.08, Close: 436.61 },
        { Open: 436.61, High: 438.54, Low: 428.5, Close: 433.64 },
        { Open: 433.64, High: 434.91, Low: 420.77, Close: 421.6 },
        { Open: 421.6, High: 423.52, Low: 415.64, Close: 419.47 },
        { Open: 419.47, High: 422.57, Low: 407.55, Close: 407.98 },
        { Open: 407.98, High: 408.95, Low: 388.96, Close: 397.83 },
        { Open: 397.83, High: 409.72, Low: 391.78, Close: 404.55 },
        { Open: 404.55, High: 415.06, Low: 402.41, Close: 412.98 },
        { Open: 412.98, High: 415.51, Low: 408.48, Close: 411.76 },
        { Open: 411.76, High: 413.78, Low: 408.8, Close: 412.62 },
        { Open: 412.62, High: 416.44, Low: 410.87, Close: 416.16 },
        { Open: 416.16, High: 421.93, Low: 415.62, Close: 419.89 },
        { Open: 419.89, High: 420.82, Low: 407.3, Close: 410.13 },
        { Open: 410.13, High: 416.02, Low: 410.09, Close: 412.29 },
        { Open: 412.29, High: 415.41, Low: 412.04, Close: 415.09 },
        { Open: 415.09, High: 417.12, Low: 412.6, Close: 415.38 },
        { Open: 415.38, High: 416.6, Low: 413.8, Close: 416.25 },
        { Open: 416.25, High: 419.51, Low: 416.13, Close: 418.45 },
        { Open: 418.45, High: 418.45, Low: 403.62, Close: 408.04 },
        { Open: 408.04, High: 409.33, Low: 403.34, Close: 408.52 },
        { Open: 408.52, High: 412.43, Low: 408.09, Close: 410.75 },
        { Open: 410.75, High: 411.58, Low: 406.93, Close: 411.42 },
        { Open: 411.42, High: 417.15, Low: 410.65, Close: 416.93 },
        { Open: 416.93, High: 418.55, Low: 415.66, Close: 417.39 },
        { Open: 417.39, High: 417.44, Low: 413.49, Close: 414.34 },
        { Open: 414.34, High: 416.43, Low: 412.84, Close: 415.69 },
        { Open: 415.69, High: 417.32, Low: 414.84, Close: 416.73 },
        { Open: 416.73, High: 427., Low: 416.04, Close: 425.38 },
        { Open: 425.38, High: 425.38, Low: 421.45, Close: 422.76 },
        { Open: 422.76, High: 424.46, Low: 407.88, Close: 415.55 },
        { Open: 415.55, High: 415.61, Low: 409.19, Close: 412.69 },
        { Open: 412.69, High: 416.94, Low: 412.69, Close: 415.16 },
        { Open: 415.16, High: 417.01, Low: 414.09, Close: 417.01 },
        { Open: 417.01, High: 420.89, Low: 416.82, Close: 419.69 },
        { Open: 419.69, High: 419.83, Low: 417.2, Close: 419.38 },
        { Open: 419.38, High: 419.78, Low: 417.41, Close: 419.42 },
        { Open: 419.42, High: 423.24, Low: 418.87, Close: 422.65 },
        { Open: 422.65, High: 422.98, Low: 421.13, Close: 421.7 },
        { Open: 421.7, High: 422.01, Low: 418.75, Close: 421.2 },
        { Open: 421.2, High: 423.56, Low: 416.08, Close: 418.09 },
        { Open: 418.09, High: 418.44, Low: 413.16, Close: 418.42 },
        { Open: 418.42, High: 421.87, Low: 417.79, Close: 421.11 },
        { Open: 421.11, High: 422.99, Low: 419.38, Close: 422.99 },
        { Open: 422.99, High: 427.79, Low: 422.69, Close: 425.99 },
        { Open: 425.99, High: 427.1, Low: 422.92, Close: 424.4 },
        { Open: 424.4, High: 425.79, Low: 423.1, Close: 425.11 },
        { Open: 425.11, High: 429.99, Low: 424.71, Close: 429.98 },
        { Open: 429.98, High: 433., Low: 429.36, Close: 430.84 },
        { Open: 430.84, High: 431.68, Low: 426.27, Close: 427.86 },
        { Open: 427.86, High: 430.08, Low: 427.17, Close: 429.05 },
        { Open: 429.05, High: 437.11, Low: 428.08, Close: 436.1 },
        { Open: 436.1, High: 444.04, Low: 434.75, Close: 442.16 },
        { Open: 442.16, High: 452.8, Low: 441.3, Close: 451.1 },
        { Open: 451.1, High: 451.73, Low: 443.91, Close: 447.64 },
        { Open: 447.64, High: 452.79, Low: 445.71, Close: 452.58 },
        { Open: 452.58, High: 460.97, Low: 450.29, Close: 460.33 },
        { Open: 460.33, High: 469.28, Low: 455.96, Close: 462.51 },
        { Open: 462.51, High: 470.16, Low: 462.44, Close: 467.8 },
        { Open: 467.8, High: 468.82, Low: 443.7, Close: 445.01 },
        { Open: 445.01, High: 450.09, Low: 435.28, Close: 449.86 },
        { Open: 449.86, High: 456.84, Low: 446.13, Close: 456.35 },
        { Open: 456.35, High: 456.89, Low: 447.84, Close: 449.33 },
        { Open: 449.33, High: 453.5, Low: 448.34, Close: 453.04 },
        { Open: 453.04, High: 453.43, Low: 439.89, Close: 444.51 },
        { Open: 444.51, High: 451.44, Low: 441.99, Close: 450.27 },
        { Open: 450.27, High: 450.71, Low: 445.44, Close: 446.96 },
        { Open: 446.96, High: 449.47, Low: 445.83, Close: 448.53 },
        { Open: 448.53, High: 462.76, Low: 447.35, Close: 460.37 },
        { Open: 460.37, High: 461.73, Low: 457.96, Close: 459.46 },
        { Open: 459.46, High: 460.48, Low: 456.15, Close: 459.44 },
        { Open: 459.44, High: 464.21, Low: 457.14, Close: 461.49 },
        { Open: 461.49, High: 463.04, Low: 447.76, Close: 450.99 },
        { Open: 450.99, High: 454.94, Low: 450.84, Close: 452.11 },
        { Open: 452.11, High: 454.96, Low: 447.73, Close: 454.82 },
        { Open: 454.82, High: 456.49, Low: 452.39, Close: 455.73 },
        { Open: 455.73, High: 457.04, Low: 453.83, Close: 455.75 },
        { Open: 455.75, High: 458.87, Low: 454.91, Close: 457.85 },
        { Open: 457.85, High: 458.41, Low: 451.33, Close: 453.41 },
        { Open: 453.41, High: 454.81, Low: 452.3, Close: 452.75 },
        { Open: 452.75, High: 455.73, Low: 452.32, Close: 453.38 },
        { Open: 453.38, High: 454.08, Low: 436.28, Close: 436.73 },
        { Open: 436.73, High: 444.07, Low: 435.62, Close: 442.95 },
        { Open: 442.95, High: 443.71, Low: 439.29, Close: 443.13 },
        { Open: 443.13, High: 443.2, Low: 437.71, Close: 438.77 },
        { Open: 438.77, High: 444.09, Low: 437.38, Close: 443.73 },
        { Open: 443.73, High: 446.47, Low: 443.25, Close: 445.13 },
        { Open: 445.13, High: 449.98, Low: 445.13, Close: 449.23 },
        { Open: 449.23, High: 453.91, Low: 447.38, Close: 453.82 },
        { Open: 453.82, High: 479.39, Low: 453.82, Close: 473.47 },
        { Open: 473.47, High: 531.7, Low: 472.19, Close: 525.43 },
        { Open: 525.43, High: 545.76, Low: 508.12, Close: 524.08 },
        { Open: 524.08, High: 541.78, Low: 520.07, Close: 532.59 },
        { Open: 532.59, High: 546.85, Low: 519.93, Close: 531.8 },
        { Open: 531.8, High: 543.63, Low: 525.64, Close: 536.42 },
        { Open: 536.42, High: 541.06, Low: 532.69, Close: 538.14 },
        { Open: 538.14, High: 576.78, Low: 536.71, Close: 570.47 },
        { Open: 570.47, High: 591.03, Low: 563.15, Close: 573.45 },
        { Open: 573.45, High: 583.31, Low: 568.33, Close: 574.11 },
        { Open: 574.11, High: 586.63, Low: 574.1, Close: 585.53 },
        { Open: 585.53, High: 590.98, Low: 565.16, Close: 577.86 },
        { Open: 577.86, High: 583.99, Low: 573.44, Close: 583.1 },
        { Open: 583.1, High: 583.24, Low: 572.04, Close: 576.45 },
        { Open: 576.45, High: 579.9, Low: 573.67, Close: 579.13 },
        { Open: 579.13, High: 611.78, Low: 578.73, Close: 611.78 },
        { Open: 611.78, High: 685.27, Low: 607.66, Close: 675.34 },
        { Open: 675.34, High: 719.85, Low: 663.37, Close: 705.62 },
        { Open: 705.62, High: 705.67, Low: 661.6, Close: 685.99 },
        { Open: 685.99, High: 697.09, Low: 673.25, Close: 696.32 },
        { Open: 696.32, High: 774.35, Low: 696.32, Close: 768.24 },
        { Open: 768.24, High: 776.64, Low: 709.69, Close: 747.55 },
        { Open: 747.55, High: 781.31, Low: 727.75, Close: 755.68 },
        { Open: 755.68, High: 765.93, Low: 742.57, Close: 764.04 },
        { Open: 764.04, High: 764.04, Low: 726.09, Close: 727.95 },
        { Open: 727.95, High: 728.06, Low: 631.72, Close: 665.88 },
        { Open: 665.88, High: 678.22, Low: 587.73, Close: 602.89 },
        { Open: 602.89, High: 633.85, Low: 551.92, Close: 625.49 },
        { Open: 625.49, High: 680.19, Low: 624.94, Close: 665.16 },
        { Open: 665.16, High: 692.54, Low: 644.87, Close: 665.33 },
        { Open: 665.33, High: 666.7, Low: 615.77, Close: 630.25 },
        { Open: 630.25, High: 658.4, Low: 620.08, Close: 658.4 },
        { Open: 658.4, High: 661.35, Low: 636.7, Close: 646.3 },
        { Open: 646.3, High: 646.3, Low: 624.77, Close: 639.08 },
        { Open: 639.08, High: 674.02, Low: 634.3, Close: 672.48 },
        { Open: 672.48, High: 684.8, Low: 667.54, Close: 676.52 },
        { Open: 676.52, High: 703.69, Low: 675.49, Close: 703.69 },
        { Open: 703.69, High: 704.42, Low: 648.05, Close: 659.69 },
        { Open: 659.69, High: 682.29, Low: 646.74, Close: 681.63 },
        { Open: 681.63, High: 682.39, Low: 662.22, Close: 668.09 },
        { Open: 668.09, High: 680.23, Low: 666.93, Close: 676.11 },
        { Open: 676.11, High: 679.92, Low: 611.26, Close: 639.76 },
        { Open: 639.76, High: 665.75, Low: 636.28, Close: 664.74 },
        { Open: 664.74, High: 664.74, Low: 626.87, Close: 650.63 },
        { Open: 650.63, High: 651.84, Low: 639.62, Close: 649.96 },
        { Open: 649.96, High: 660.44, Low: 644.75, Close: 649.03 },
        { Open: 649.03, High: 675.07, Low: 646.54, Close: 664.84 },
        { Open: 664.84, High: 668.76, Low: 653.43, Close: 653.93 },
        { Open: 653.93, High: 663.65, Low: 651.49, Close: 659.64 },
        { Open: 659.64, High: 668.23, Low: 658.43, Close: 664.88 },
        { Open: 664.88, High: 667.36, Low: 658.25, Close: 663.54 },
        { Open: 663.54, High: 680.65, Low: 663.37, Close: 679.05 },
        { Open: 679.05, High: 682.19, Low: 667.44, Close: 673.59 },
        { Open: 673.59, High: 674.84, Low: 667.43, Close: 673.84 },
        { Open: 673.84, High: 674.39, Low: 662.61, Close: 666.18 },
        { Open: 666.18, High: 667.15, Low: 659.69, Close: 665.1 },
        { Open: 665.1, High: 667.2, Low: 645.15, Close: 650.82 },
        { Open: 650.82, High: 656.44, Low: 648.76, Close: 654.86 },
        { Open: 654.86, High: 663.92, Low: 652.33, Close: 661.05 },
        { Open: 661.05, High: 662.15, Low: 653.13, Close: 655.13 },
        { Open: 655.13, High: 656.73, Low: 644.65, Close: 651.08 },
        { Open: 651.08, High: 659.51, Low: 647.92, Close: 655.44 },
        { Open: 655.44, High: 658.63, Low: 654.16, Close: 655.63 },
        { Open: 655.63, High: 658.07, Low: 654.38, Close: 656.67 },
        { Open: 656.67, High: 658.28, Low: 653.51, Close: 654.98 },
        { Open: 654.98, High: 655.07, Low: 623.48, Close: 625.88 },
        { Open: 625.88, High: 627.62, Low: 604.92, Close: 607.37 },
        { Open: 607.37, High: 613.96, Low: 508.48, Close: 552.82 },
        { Open: 552.82, High: 576.76, Low: 540.3, Close: 565.26 },
        { Open: 565.26, High: 583.28, Low: 560.74, Close: 578.32 },
        { Open: 578.32, High: 579.09, Low: 566.07, Close: 574.96 },
        { Open: 574.96, High: 589.6, Low: 567.57, Close: 588.42 },
        { Open: 588.42, High: 598.64, Low: 584.45, Close: 592.78 },
        { Open: 592.78, High: 593.3, Low: 586.92, Close: 590.62 },
        { Open: 590.62, High: 590.7, Low: 583.83, Close: 584.76 },
        { Open: 584.76, High: 599.86, Low: 583.09, Close: 592.89 },
        { Open: 592.89, High: 597.48, Low: 586.33, Close: 586.52 },
        { Open: 586.52, High: 589.6, Low: 581.86, Close: 586.03 },
        { Open: 586.03, High: 589.14, Low: 583.62, Close: 585.08 },
        { Open: 585.08, High: 585.1, Low: 563.8, Close: 571.44 },
        { Open: 571.44, High: 574.4, Low: 560.2, Close: 567.2 },
        { Open: 567.2, High: 580.51, Low: 565.45, Close: 576.25 },
        { Open: 576.25, High: 578.29, Low: 568.48, Close: 571.74 },
        { Open: 571.74, High: 576.16, Low: 571.34, Close: 572.5 },
        { Open: 572.5, High: 575.89, Low: 571.54, Close: 573.66 },
        { Open: 573.66, High: 582.85, Low: 572.74, Close: 580.7 },
        { Open: 580.7, High: 583.95, Low: 579.2, Close: 580.69 },
        { Open: 580.69, High: 586.18, Low: 578.45, Close: 584.73 },
        { Open: 584.73, High: 586.72, Low: 578.11, Close: 581.28 },
        { Open: 581.28, High: 581.72, Low: 577.07, Close: 577.99 },
        { Open: 577.99, High: 578.46, Low: 573.09, Close: 575.73 },
        { Open: 575.73, High: 578.79, Low: 574.61, Close: 578.16 },
        { Open: 578.16, High: 578.39, Low: 566.45, Close: 568.67 },
        { Open: 568.67, High: 573.59, Low: 568.1, Close: 573.55 },
        { Open: 573.55, High: 575.36, Low: 571.37, Close: 572.36 },
        { Open: 572.36, High: 577.4, Low: 571.23, Close: 576. },
        { Open: 576., High: 576.45, Low: 570.8, Close: 572.33 },
        { Open: 572.33, High: 573.13, Low: 568.86, Close: 571.69 },
        { Open: 571.69, High: 575.26, Low: 569.3, Close: 574.15 },
        { Open: 574.15, High: 599.6, Low: 572.42, Close: 598.38 },
        { Open: 598.38, High: 612.39, Low: 595.81, Close: 608.92 },
        { Open: 608.92, High: 609.76, Low: 600.44, Close: 606.03 },
        { Open: 606.03, High: 611.16, Low: 604.21, Close: 611.07 },
        { Open: 611.07, High: 615.32, Low: 607.25, Close: 614.79 },
        { Open: 614.79, High: 628.75, Low: 613.13, Close: 624.95 },
        { Open: 624.95, High: 626., Low: 617.54, Close: 621.8 },
        { Open: 621.8, High: 624.32, Low: 620.34, Close: 622.21 },
        { Open: 622.21, High: 628.5, Low: 595.43, Close: 605.81 },
        { Open: 605.81, High: 606.83, Low: 603.08, Close: 606.31 },
        { Open: 606.31, High: 608.95, Low: 605.17, Close: 606.92 },
        { Open: 606.92, High: 609.63, Low: 606.33, Close: 608.22 },
        { Open: 608.22, High: 608.47, Low: 604.66, Close: 605.21 },
        { Open: 605.21, High: 608.54, Low: 605., Close: 606.33 },
        { Open: 606.33, High: 606.83, Low: 603.46, Close: 605.29 },
        { Open: 605.29, High: 609.35, Low: 604.64, Close: 608.7 },
        { Open: 608.7, High: 609.74, Low: 606.17, Close: 608.53 },
        { Open: 608.53, High: 608.72, Low: 599.47, Close: 599.47 },
        { Open: 599.47, High: 599.47, Low: 590.87, Close: 595.8 },
        { Open: 595.8, High: 596.93, Low: 594.57, Close: 595.03 },
        { Open: 595.03, High: 602.12, Low: 593.75, Close: 601.71 },
        { Open: 601.71, High: 603.54, Low: 599.63, Close: 601.34 },
        { Open: 601.34, High: 601.98, Low: 597.65, Close: 599.18 },
        { Open: 599.18, High: 607.34, Low: 598.14, Close: 606.81 },
        { Open: 606.81, High: 607.55, Low: 601.39, Close: 604.76 },
        { Open: 604.76, High: 604.79, Low: 602.27, Close: 603.52 },
        { Open: 603.52, High: 606.02, Low: 602.48, Close: 605.06 },
        { Open: 605.06, High: 608.59, Low: 603.48, Close: 608.44 },
        { Open: 608.44, High: 615.09, Low: 608.44, Close: 613.93 },
        { Open: 613.93, High: 614.28, Low: 608.27, Close: 610.29 },
        { Open: 610.29, High: 612.61, Low: 609.66, Close: 612.34 },
        { Open: 612.34, High: 612.37, Low: 607.68, Close: 609.37 },
        { Open: 609.37, High: 612.78, Low: 607.91, Close: 610.88 },
        { Open: 610.88, High: 611.61, Low: 610.09, Close: 610.9 },
        { Open: 610.9, High: 617.27, Low: 609.8, Close: 616.49 },
        { Open: 616.49, High: 618.46, Low: 615.5, Close: 616.6 },
        { Open: 616.6, High: 616.6, Low: 613.44, Close: 614.62 },
        { Open: 614.62, High: 617.42, Low: 613.82, Close: 617.42 },
        { Open: 617.42, High: 640.9, Low: 615.87, Close: 639.37 },
        { Open: 639.37, High: 640.15, Low: 634.07, Close: 635.08 },
        { Open: 635.08, High: 637.79, Low: 633.82, Close: 635.02 },
        { Open: 635.02, High: 639.24, Low: 631.96, Close: 638.37 },
        { Open: 638.37, High: 639.98, Low: 636.05, Close: 637.37 },
        { Open: 637.37, High: 641.15, Low: 636.72, Close: 639.83 },
        { Open: 639.83, High: 640.84, Low: 635.86, Close: 636.92 },
        { Open: 636.92, High: 637.8, Low: 632.77, Close: 635.51 },
        { Open: 635.51, High: 636.36, Low: 625.28, Close: 628.15 },
        { Open: 628.15, High: 629.64, Low: 626.08, Close: 628.62 },
        { Open: 628.62, High: 632.3, Low: 628.1, Close: 630.15 },
        { Open: 630.15, High: 654.56, Low: 629.65, Close: 652.71 },
        { Open: 652.71, High: 654.8, Low: 647.73, Close: 649.24 },
        { Open: 649.24, High: 650.04, Low: 645.49, Close: 648.4 },
        { Open: 648.4, High: 658.87, Low: 646.69, Close: 652.89 },
        { Open: 652.89, High: 676.54, Low: 652.33, Close: 674.36 },
        { Open: 674.36, High: 686.73, Low: 673.64, Close: 686.52 },
        { Open: 686.52, High: 688.3, Low: 681.42, Close: 688.1 },
        { Open: 688.1, High: 718.73, Low: 687.76, Close: 712.87 },
        { Open: 712.87, High: 712.87, Low: 692.21, Close: 696.35 },
        { Open: 696.35, High: 707.44, Low: 682.08, Close: 697.37 },
        { Open: 697.37, High: 735.83, Low: 697.37, Close: 729.27 },
        { Open: 729.27, High: 742.46, Low: 719.63, Close: 742.46 },
        { Open: 742.46, High: 744.89, Low: 673.73, Close: 687.51 },
        { Open: 687.51, High: 706.3, Low: 682.9, Close: 702.54 },
        { Open: 702.54, High: 706.42, Low: 696.66, Close: 704.16 },
        { Open: 704.16, High: 714.56, Low: 699.86, Close: 712.24 },
        { Open: 712.24, High: 712.24, Low: 700.19, Close: 704.02 },
        { Open: 704.02, High: 714.07, Low: 702., Close: 709.15 },
        { Open: 709.15, High: 738.98, Low: 707.79, Close: 721.19 },
        { Open: 721.19, High: 722.45, Low: 707.99, Close: 713.67 },
        { Open: 713.67, High: 718.27, Low: 713.07, Close: 716.56 },
        { Open: 716.56, High: 717.76, Low: 703.2, Close: 703.55 },
        { Open: 703.55, High: 703.96, Low: 686.02, Close: 702.5 },
        { Open: 702.5, High: 707.36, Low: 698.52, Close: 706.39 },
        { Open: 706.39, High: 716.21, Low: 705.36, Close: 711.96 },
        { Open: 711.96, High: 744.58, Low: 709.52, Close: 742.07 },
        { Open: 742.07, High: 752.04, Low: 735.41, Close: 735.41 },
        { Open: 735.41, High: 751.14, Low: 731.98, Close: 749.68 },
        { Open: 749.68, High: 754.55, Low: 740.13, Close: 750.63 },
        { Open: 750.63, High: 753.76, Low: 713.13, Close: 728.61 },
        { Open: 728.61, High: 738.63, Low: 728.01, Close: 736.72 },
        { Open: 736.72, High: 750.8, Low: 732.38, Close: 748.22 },
        { Open: 748.22, High: 748.93, Low: 732.21, Close: 741.6 },
        { Open: 741.6, High: 743.6, Low: 727.99, Close: 736.4 },
        { Open: 736.4, High: 738.51, Low: 728.38, Close: 738.28 },
        { Open: 738.28, High: 738.39, Low: 724.13, Close: 732.82 },
        { Open: 732.82, High: 735.4, Low: 727.44, Close: 728.42 },
        { Open: 728.42, High: 734.47, Low: 728.42, Close: 731.75 },
        { Open: 731.75, High: 734.43, Low: 728.6, Close: 731.76 },
        { Open: 731.76, High: 744.05, Low: 730.71, Close: 742.01 },
        { Open: 742.01, High: 754.75, Low: 741.88, Close: 753.25 },
        { Open: 753.25, High: 778.14, Low: 753.15, Close: 771.41 },
        { Open: 771.41, High: 771.47, Low: 757.83, Close: 764.97 },
        { Open: 764.97, High: 767.24, Low: 761.4, Close: 766.46 },
        { Open: 766.46, High: 766.83, Low: 745.7, Close: 750.71 },
        { Open: 750.71, High: 759.89, Low: 750.54, Close: 758.81 },
        { Open: 758.81, High: 768.32, Low: 752.16, Close: 763.9 },
        { Open: 763.9, High: 771.42, Low: 761.46, Close: 766.75 },
        { Open: 766.75, High: 772.47, Low: 766.27, Close: 770.41 },
        { Open: 770.41, High: 775.09, Low: 770.25, Close: 773.21 },
        { Open: 773.21, High: 773.31, Low: 763.32, Close: 768.62 },
        { Open: 768.62, High: 779.35, Low: 768.62, Close: 777.91 },
        { Open: 777.91, High: 788.49, Low: 766.9, Close: 775.25 },
        { Open: 775.25, High: 779.6, Low: 771.39, Close: 776.64 },
        { Open: 776.64, High: 778.22, Low: 774.94, Close: 775.48 },
        { Open: 775.48, High: 781.54, Low: 772.77, Close: 780.85 },
        { Open: 780.85, High: 790.84, Low: 780.7, Close: 788.58 },
        { Open: 788.58, High: 790.09, Low: 785.24, Close: 788.59 },
        { Open: 788.59, High: 792.28, Low: 788.57, Close: 790.16 },
        { Open: 790.16, High: 800.46, Low: 788.45, Close: 798.78 },
        { Open: 798.78, High: 833.3, Low: 797.46, Close: 833.1 },
        { Open: 833.1, High: 874.1, Low: 829.84, Close: 858.74 },
        { Open: 858.74, High: 918.95, Low: 858.62, Close: 916.79 },
        { Open: 916.79, High: 917.55, Low: 883.27, Close: 894.2 },
        { Open: 894.2, High: 896.14, Low: 858.04, Close: 894.48 },
        { Open: 894.48, High: 909.85, Low: 893.62, Close: 902.55 },
        { Open: 902.55, High: 938.13, Low: 900.03, Close: 931.11 },
        { Open: 931.11, High: 978.01, Low: 931.11, Close: 978.01 },
        { Open: 978.01, High: 982.87, Low: 949.62, Close: 969.62 },
        { Open: 969.62, High: 969.62, Low: 928.99, Close: 960.47 },
        { Open: 960.47, High: 968.23, Low: 945.74, Close: 968.23 },
        { Open: 968.23, High: 1003.25, Low: 962.58, Close: 997.69 },
        { Open: 997.69, High: 1034.1, Low: 996.44, Close: 1018.05 },
        { Open: 1018.05, High: 1036.14, Low: 1013.38, Close: 1030.82 },
        { Open: 1030.82, High: 1141.16, Low: 1030.82, Close: 1129.87 },
        { Open: 1129.87, High: 1153.02, Low: 887.46, Close: 1005.81 },
        { Open: 1005.81, High: 1029.17, Low: 867.16, Close: 895.67 },
        { Open: 895.67, High: 906.04, Low: 816.36, Close: 905.17 },
        { Open: 905.17, High: 942.06, Low: 888.2, Close: 913.52 },
        { Open: 913.52, High: 913.52, Low: 878.1, Close: 899.35 },
        { Open: 899.35, High: 914.02, Low: 897.57, Close: 904.79 },
        { Open: 904.79, High: 919.56, Low: 752.11, Close: 775.98 },
        { Open: 775.98, High: 828.09, Low: 746.68, Close: 802.83 },
        { Open: 802.83, High: 829.81, Low: 774.36, Close: 826.12 },
        { Open: 826.12, High: 839.23, Low: 810.64, Close: 818.64 },
        { Open: 818.64, High: 823.16, Low: 810.01, Close: 822.42 },
        { Open: 822.42, High: 834.7, Low: 820.05, Close: 830.26 },
        { Open: 830.26, High: 908.13, Low: 828.58, Close: 904.45 },
        { Open: 904.45, High: 914.8, Low: 848.61, Close: 884.25 },
        { Open: 884.25, High: 905.42, Low: 879.59, Close: 898.02 },
        { Open: 898.02, High: 899.38, Low: 882.3, Close: 891.62 },
        { Open: 891.62, High: 927.24, Low: 891.09, Close: 920.01 },
        { Open: 920.01, High: 939.27, Low: 893.01, Close: 925.33 },
        { Open: 925.33, High: 927., Low: 912.69, Close: 912.69 },
        { Open: 912.69, High: 922.15, Low: 884.79, Close: 885.65 },
        { Open: 885.65, High: 902.73, Low: 885.65, Close: 894.11 },
        { Open: 894.11, High: 919.13, Low: 894.02, Close: 915.1 },
        { Open: 915.1, High: 921.57, Low: 909.4, Close: 918.56 },
        { Open: 918.56, High: 921.59, Low: 917.5, Close: 920.28 },
        { Open: 920.28, High: 922.06, Low: 914., Close: 914.04 },
        { Open: 914.04, High: 921.58, Low: 912.95, Close: 920.24 },
        { Open: 920.24, High: 970.19, Low: 920.24, Close: 967.67 },
        { Open: 967.67, High: 987.35, Low: 964.41, Close: 987.35 },
        { Open: 987.35, High: 1010.08, Low: 977.52, Close: 1007.79 },
        { Open: 1007.79, High: 1024.14, Low: 995.87, Close: 1018.11 },
        { Open: 1018.11, High: 1040.09, Low: 1004.38, Close: 1033.65 },
        { Open: 1033.65, High: 1033.65, Low: 1006.52, Close: 1013.99 },
        { Open: 1013.99, High: 1030.4, Low: 1012.9, Close: 1024.61 },
        { Open: 1024.61, High: 1054.73, Low: 1023.99, Close: 1052.54 },
        { Open: 1052.54, High: 1069.99, Low: 1018.19, Close: 1054.34 },
        { Open: 1054.34, High: 1077.76, Low: 942.45, Close: 988.95 },
        { Open: 988.95, High: 1000.99, Low: 954.28, Close: 993.08 },
        { Open: 993.08, High: 1016., Low: 987.81, Close: 1010. },
        { Open: 1010., High: 1010., Low: 997.46, Close: 999.51 },
        { Open: 999.51, High: 1007.28, Low: 976.29, Close: 996.86 },
        { Open: 996.86, High: 1016.44, Low: 987.33, Close: 1009.25 },
        { Open: 1009.25, High: 1011.33, Low: 1001., Close: 1009.12 },
        { Open: 1009.12, High: 1039.85, Low: 1008.79, Close: 1034.08 },
        { Open: 1034.08, High: 1058.27, Low: 1027.99, Close: 1053.12 },
        { Open: 1053.12, High: 1066.84, Low: 1050.71, Close: 1058.41 },
        { Open: 1058.41, High: 1061.32, Low: 1045.31, Close: 1052.82 },
        { Open: 1052.82, High: 1084.5, Low: 1045.8, Close: 1083.24 },
        { Open: 1083.24, High: 1126.49, Low: 1078.02, Close: 1123.66 },
        { Open: 1123.66, High: 1135.86, Low: 1101.9, Close: 1122.19 },
        { Open: 1122.19, High: 1186.33, Low: 1119.41, Close: 1178.38 },
        { Open: 1178.38, High: 1206.6, Low: 1101.38, Close: 1180.92 },
        { Open: 1180.92, High: 1184.18, Low: 1126.26, Close: 1151.58 },
        { Open: 1151.58, High: 1183.35, Low: 1133.23, Close: 1179.97 },
        { Open: 1179.97, High: 1196.8, Low: 1173.09, Close: 1194.28 },
        { Open: 1194.28, High: 1210.16, Low: 1176.9, Close: 1190.89 },
        { Open: 1190.89, High: 1230.02, Low: 1187.33, Close: 1230.02 },
        { Open: 1230.02, High: 1284.33, Low: 1216.03, Close: 1260.92 },
        { Open: 1260.92, High: 1293.47, Low: 1258.49, Close: 1290.79 },
        { Open: 1290.79, High: 1290.79, Low: 1239.57, Close: 1267.68 },
        { Open: 1267.68, High: 1277.88, Low: 1245.91, Close: 1277.68 },
        { Open: 1277.68, High: 1285.18, Low: 1268.81, Close: 1280.87 },
        { Open: 1280.87, High: 1282.44, Low: 1188.17, Close: 1232.43 },
        { Open: 1232.43, High: 1239.75, Low: 1145.89, Close: 1150.48 },
        { Open: 1150.48, High: 1208.64, Low: 1135.09, Close: 1191.81 },
        { Open: 1191.81, High: 1325.81, Low: 1022.68, Close: 1117.02 },
        { Open: 1117.02, High: 1200.38, Low: 1112.14, Close: 1181.64 },
        { Open: 1181.64, High: 1237.78, Low: 1178.07, Close: 1229.5 },
        { Open: 1229.5, High: 1247.26, Low: 1216.21, Close: 1243.24 },
        { Open: 1243.24, High: 1257.8, Low: 1227.11, Close: 1246.31 },
        { Open: 1246.31, High: 1260.42, Low: 1245.1, Close: 1259.6 },
        { Open: 1259.6, High: 1260.63, Low: 1132.45, Close: 1172.91 },
        { Open: 1172.91, High: 1172.91, Low: 1066.8, Close: 1070.13 },
        { Open: 1070.13, High: 1096.88, Low: 944.11, Close: 970.6 },
        { Open: 970.6, High: 1058.91, Low: 970.6, Close: 1017.8 },
        { Open: 1017.8, High: 1052.21, Low: 1014.9, Close: 1041.34 },
        { Open: 1041.34, High: 1119.07, Low: 1041.3, Close: 1115.04 },
        { Open: 1115.04, High: 1115.17, Low: 990.7, Close: 1037.44 },
        { Open: 1037.44, High: 1053.24, Low: 1016.83, Close: 1029.95 },
        { Open: 1029.95, High: 1032.34, Low: 925.78, Close: 935.95 },
        { Open: 935.95, High: 972.27, Low: 891.51, Close: 964.69 },
        { Open: 964.69, High: 998.56, Low: 946.52, Close: 965.23 },
        { Open: 965.23, High: 1042.9, Low: 958.77, Close: 1040.49 },
        { Open: 1040.49, High: 1064.52, Low: 1017.17, Close: 1044.25 },
        { Open: 1044.25, High: 1056.9, Low: 1010.05, Close: 1040.39 },
        { Open: 1040.39, High: 1051.85, Low: 1023.19, Close: 1037.53 },
        { Open: 1037.53, High: 1087.73, Low: 1037.52, Close: 1079.75 },
        { Open: 1079.75, High: 1103.53, Low: 1069.78, Close: 1089.51 },
        { Open: 1089.51, High: 1111.24, Low: 1077.59, Close: 1098.78 },
        { Open: 1098.78, High: 1155.71, Low: 1098.77, Close: 1147.63 },
        { Open: 1147.63, High: 1161.36, Low: 1125.83, Close: 1143.75 },
        { Open: 1143.75, High: 1145.82, Low: 1113.08, Close: 1135. },
        { Open: 1135., High: 1202.82, Low: 1135., Close: 1190.6 },
        { Open: 1190.6, High: 1202.04, Low: 1176.37, Close: 1193.02 },
        { Open: 1193.02, High: 1196.94, Low: 1170.58, Close: 1184.82 },
        { Open: 1184.82, High: 1218.24, Low: 1178.4, Close: 1210.05 },
        { Open: 1210.05, High: 1219.06, Low: 1202.78, Close: 1213.34 },
        { Open: 1213.34, High: 1232.15, Low: 1204.36, Close: 1224.77 },
        { Open: 1224.77, High: 1228.26, Low: 1213.65, Close: 1216.5 },
        { Open: 1216.5, High: 1222.26, Low: 1154.9, Close: 1178.53 },
        { Open: 1178.53, High: 1197.39, Low: 1169.89, Close: 1183.44 },
        { Open: 1183.44, High: 1199.71, Low: 1178.35, Close: 1180.7 },
        { Open: 1180.7, High: 1190.96, Low: 1178.09, Close: 1184.79 },
        { Open: 1184.79, High: 1206.9, Low: 1181.78, Close: 1203.73 },
        { Open: 1203.73, High: 1222.36, Low: 1203.39, Close: 1217.6 },
        { Open: 1217.6, High: 1228.5, Low: 1209.18, Close: 1226.94 },
        { Open: 1226.94, High: 1262.85, Low: 1220.45, Close: 1255.4 },
        { Open: 1255.4, High: 1275.05, Low: 1247.79, Close: 1257.13 },
        { Open: 1257.13, High: 1259.06, Low: 1220., Close: 1244.37 },
        { Open: 1244.37, High: 1250.45, Low: 1230.68, Close: 1248.22 },
        { Open: 1248.22, High: 1250.47, Low: 1238.11, Close: 1248.32 },
        { Open: 1248.32, High: 1270.73, Low: 1248.19, Close: 1263.54 },
        { Open: 1263.54, High: 1307.28, Low: 1263.49, Close: 1284.84 },
        { Open: 1284.84, High: 1335.56, Low: 1283.31, Close: 1329.19 },
        { Open: 1329.19, High: 1343.59, Low: 1282.93, Close: 1320.05 },
        { Open: 1320.05, High: 1333.37, Low: 1311.25, Close: 1327.04 },
        { Open: 1327.04, High: 1352.15, Low: 1308.74, Close: 1347.96 },
        { Open: 1347.96, High: 1426.63, Low: 1346.27, Close: 1402.08 },
        { Open: 1402.08, High: 1466.88, Low: 1397.06, Close: 1443.68 },
        { Open: 1443.68, High: 1494.53, Low: 1431.18, Close: 1492. },
        { Open: 1492., High: 1594.63, Low: 1442.73, Close: 1515.63 },
        { Open: 1515.63, High: 1591.97, Low: 1491.67, Close: 1512.21 },
        { Open: 1512.21, High: 1552.44, Low: 1512.11, Close: 1548.29 },
        { Open: 1548.29, High: 1560.01, Low: 1525.89, Close: 1555.47 },
        { Open: 1555.47, High: 1639.43, Low: 1555.47, Close: 1639.32 },
        { Open: 1639.32, High: 1753.59, Low: 1615.63, Close: 1706.93 },
        { Open: 1706.93, High: 1782.89, Low: 1690.4, Close: 1756.8 },
        { Open: 1756.8, High: 1848.75, Low: 1732.13, Close: 1807.37 },
        { Open: 1807.37, High: 1808.55, Low: 1644.64, Close: 1676.99 },
        { Open: 1676.99, High: 1759.96, Low: 1587.69, Close: 1759.96 },
        { Open: 1759.96, High: 1799.65, Low: 1740.2, Close: 1772.42 },
        { Open: 1772.42, High: 1773.49, Low: 1652.16, Close: 1697.38 },
        { Open: 1697.38, High: 1737.34, Low: 1657.11, Close: 1718.2 },
        { Open: 1718.2, High: 1823.55, Low: 1688.49, Close: 1802.16 },
        { Open: 1802.16, High: 1893.63, Low: 1794.92, Close: 1887.33 },
        { Open: 1887.33, High: 1973.01, Low: 1887.15, Close: 1968.1 },
        { Open: 1968.1, High: 2061.88, Low: 1964.97, Close: 2051.73 },
        { Open: 2051.73, High: 2092.54, Low: 2001.14, Close: 2055.62 },
        { Open: 2055.62, High: 2289.21, Low: 2045.79, Close: 2139.03 },
        { Open: 2139.03, High: 2297.56, Low: 2134.64, Close: 2291.48 },
        { Open: 2291.48, High: 2524.83, Low: 2291.48, Close: 2476.3 },
        { Open: 2476.3, High: 2791.69, Low: 2298.49, Close: 2357.5 },
        { Open: 2357.5, High: 2639.9, Low: 2067.1, Close: 2247.48 },
        { Open: 2247.48, High: 2329.37, Low: 1908.99, Close: 2106.31 },
        { Open: 2106.31, High: 2320.82, Low: 2106.31, Close: 2207.58 },
        { Open: 2207.58, High: 2339.72, Low: 2135.61, Close: 2289.87 },
        { Open: 2289.87, High: 2329.64, Low: 2152.92, Close: 2197.23 },
        { Open: 2197.23, High: 2351.24, Low: 2162.23, Close: 2330.23 },
        { Open: 2330.23, High: 2489.98, Low: 2330.23, Close: 2452.18 },
        { Open: 2452.18, High: 2517.41, Low: 2418.32, Close: 2517.41 },
        { Open: 2517.41, High: 2593.64, Low: 2448.04, Close: 2555.65 },
        { Open: 2555.65, High: 2577.83, Low: 2494.29, Close: 2552.81 },
        { Open: 2552.81, High: 2736.59, Low: 2551.55, Close: 2736.59 },
        { Open: 2736.59, High: 2967.48, Low: 2732.99, Close: 2914.08 },
        { Open: 2914.08, High: 2922.7, Low: 2629.53, Close: 2694.22 },
        { Open: 2694.22, High: 2828.48, Low: 2625.08, Close: 2825.03 },
        { Open: 2825.03, High: 2874.7, Low: 2794.06, Close: 2826.7 },
        { Open: 2826.7, High: 2942.46, Low: 2821.52, Close: 2942.34 },
        { Open: 2942.34, High: 3025.47, Low: 2894.01, Close: 3018.54 },
        { Open: 3018.54, High: 3020.27, Low: 2525.24, Close: 2682.59 },
        { Open: 2682.59, High: 2802.95, Low: 2678.76, Close: 2738.93 },
        { Open: 2738.93, High: 2828.88, Low: 2385.03, Close: 2494.48 },
        { Open: 2494.48, High: 2553.68, Low: 2185.96, Close: 2456.92 },
        { Open: 2456.92, High: 2559.19, Low: 2366.49, Close: 2528.1 },
        { Open: 2528.1, High: 2707.06, Low: 2462.16, Close: 2664. },
        { Open: 2664., High: 2689.54, Low: 2522.32, Close: 2576.17 },
        { Open: 2576.17, High: 2642.28, Low: 2555.1, Close: 2641.66 },
        { Open: 2641.66, High: 2822.63, Low: 2636.06, Close: 2778.83 },
        { Open: 2778.83, High: 2828.94, Low: 2661.42, Close: 2712.16 },
        { Open: 2712.16, High: 2768.76, Low: 2637.22, Close: 2740.79 },
        { Open: 2740.79, High: 2813.31, Low: 2709.76, Close: 2738.22 },
        { Open: 2738.22, High: 2790.33, Low: 2564., Close: 2619.12 },
        { Open: 2619.12, High: 2713.9, Low: 2495.97, Close: 2594.45 },
        { Open: 2594.45, High: 2658., Low: 2387.64, Close: 2485.36 },
        { Open: 2485.36, High: 2593.17, Low: 2332.6, Close: 2593.17 },
        { Open: 2593.17, High: 2619.24, Low: 2490.21, Close: 2584.56 },
        { Open: 2584.56, High: 2623.31, Low: 2530.12, Close: 2561.56 },
        { Open: 2561.56, High: 2632.11, Low: 2485.55, Close: 2499.98 },
        { Open: 2499.98, High: 2547.05, Low: 2442.83, Close: 2460.2 },
        { Open: 2460.2, High: 2541.99, Low: 2396.01, Close: 2529.78 },
        { Open: 2529.78, High: 2620.29, Low: 2504.36, Close: 2581.07 },
        { Open: 2581.07, High: 2659.79, Low: 2580.7, Close: 2625.07 },
        { Open: 2625.07, High: 2648.68, Low: 2560.85, Close: 2629.27 },
        { Open: 2629.27, High: 2638.1, Low: 2591.98, Close: 2619.11 },
        { Open: 2619.11, High: 2622.19, Low: 2492.33, Close: 2521.24 },
        { Open: 2521.24, High: 2590.55, Low: 2482.77, Close: 2579.93 },
        { Open: 2579.93, High: 2590.75, Low: 2522.24, Close: 2525.67 },
        { Open: 2525.67, High: 2544.96, Low: 2314.08, Close: 2371.96 },
        { Open: 2371.96, High: 2428.16, Low: 2292.84, Close: 2332.19 },
        { Open: 2332.19, High: 2438.48, Low: 2272.32, Close: 2423.16 },
        { Open: 2423.16, High: 2450.99, Low: 2336.67, Close: 2364.52 },
        { Open: 2364.52, High: 2376.43, Low: 2171.81, Close: 2232.65 },
        { Open: 2232.65, High: 2238.66, Low: 1990.69, Close: 1993.26 },
        { Open: 1993.26, High: 2073.79, Low: 1836.92, Close: 1938.94 },
        { Open: 1938.94, High: 2244.26, Low: 1938.73, Close: 2244.26 },
        { Open: 2244.26, High: 2407.19, Low: 2169.64, Close: 2327.9 },
        { Open: 2327.9, High: 2413.48, Low: 2243.98, Close: 2294.4 },
        { Open: 2294.4, High: 2948.51, Low: 2276.15, Close: 2877.39 },
        { Open: 2877.39, High: 2889.42, Low: 2621.23, Close: 2694.29 },
        { Open: 2694.29, High: 2875.78, Low: 2678.04, Close: 2838.81 },
        { Open: 2838.81, High: 2860.3, Low: 2670.76, Close: 2762.63 },
        { Open: 2762.63, High: 2813.97, Low: 2720.71, Close: 2779.04 },
        { Open: 2779.04, High: 2824., Low: 2485.18, Close: 2591.22 },
        { Open: 2591.22, High: 2633.03, Low: 2433.83, Close: 2550.18 },
        { Open: 2550.18, High: 2715.69, Low: 2541.71, Close: 2697.47 },
        { Open: 2697.47, High: 2833.24, Low: 2682.87, Close: 2805.18 },
        { Open: 2805.18, High: 2809.03, Low: 2681.55, Close: 2720.08 },
        { Open: 2720.08, High: 2753.33, Low: 2615.81, Close: 2746.33 },
        { Open: 2746.33, High: 2908.29, Low: 2706.82, Close: 2873.83 },
        { Open: 2873.83, High: 2925.03, Low: 2680.85, Close: 2735.59 },
        { Open: 2735.59, High: 2772.56, Low: 2675.68, Close: 2723.58 },
        { Open: 2723.58, High: 2824.38, Low: 2715.49, Close: 2814.36 },
        { Open: 2814.36, High: 2897.79, Low: 2797.12, Close: 2883.68 },
        { Open: 2883.68, High: 3360.87, Low: 2881.85, Close: 3301.76 },
        { Open: 3301.76, High: 3330.34, Low: 3190.19, Close: 3255. },
        { Open: 3255., High: 3451.85, Low: 3222.91, Close: 3431.97 },
        { Open: 3431.97, High: 3538.04, Low: 3357.39, Close: 3453.16 },
        { Open: 3453.16, High: 3460.54, Low: 3280.32, Close: 3377.54 },
        { Open: 3377.54, High: 3481.09, Low: 3353.42, Close: 3445.28 },
        { Open: 3445.28, High: 3754.62, Low: 3427.01, Close: 3679.61 },
        { Open: 3679.61, High: 4009.89, Low: 3639.77, Close: 3917.65 },
        { Open: 3917.65, High: 4225.4, Low: 3890., Close: 4111.2 },
        { Open: 4111.2, High: 4384.05, Low: 4031.85, Close: 4382.74 },
        { Open: 4382.74, High: 4483.55, Low: 3892.72, Close: 4204.43 },
        { Open: 4204.43, High: 4434.41, Low: 3985.23, Close: 4425.3 },
        { Open: 4425.3, High: 4522.13, Low: 4235.79, Close: 4316.34 },
        { Open: 4316.34, High: 4407.8, Low: 4040.05, Close: 4159.46 },
        { Open: 4159.46, High: 4248.04, Low: 4033.54, Close: 4206.13 },
        { Open: 4206.13, High: 4227.09, Low: 4101.06, Close: 4111.22 },
        { Open: 4111.22, High: 4353.42, Low: 3964.77, Close: 4054.94 },
        { Open: 4054.94, High: 4217.67, Low: 3687.28, Close: 4137.67 },
        { Open: 4137.67, High: 4447.89, Low: 4066.62, Close: 4191.22 },
        { Open: 4191.22, High: 4400.75, Low: 4153.8, Close: 4362.47 },
        { Open: 4362.47, High: 4496.29, Low: 4311.8, Close: 4408.32 },
        { Open: 4408.32, High: 4441.48, Low: 4285.73, Close: 4387.46 },
        { Open: 4387.46, High: 4456.11, Low: 4321.57, Close: 4394.51 },
        { Open: 4394.51, High: 4475.7, Low: 4221.44, Close: 4439.66 },
        { Open: 4439.66, High: 4703.42, Low: 4365.7, Close: 4648.13 },
        { Open: 4648.13, High: 4707.55, Low: 4545.54, Close: 4630.73 },
        { Open: 4630.73, High: 4802.74, Low: 4629.78, Close: 4764.87 },
        { Open: 4764.87, High: 4950.72, Low: 4726.74, Close: 4950.72 },
        { Open: 4950.72, High: 5013.91, Low: 4529.37, Close: 4643.97 },
        { Open: 4643.97, High: 4749.03, Low: 4481.52, Close: 4631.69 },
        { Open: 4631.69, High: 4636.31, Low: 4167.53, Close: 4319.72 },
        { Open: 4319.72, High: 4494.53, Low: 4037.5, Close: 4422.12 },
        { Open: 4422.12, High: 4666.47, Low: 4421.53, Close: 4626.72 },
        { Open: 4626.72, High: 4691.98, Low: 4506.66, Close: 4638.1 },
        { Open: 4638.1, High: 4698.73, Low: 4151.64, Close: 4317.54 },
        { Open: 4317.54, High: 4394.52, Low: 4161.97, Close: 4291.88 },
        { Open: 4291.88, High: 4302.2, Low: 3976.46, Close: 4191.17 },
        { Open: 4191.17, High: 4334.51, Low: 4108.47, Close: 4188.84 },
        { Open: 4188.84, High: 4368.22, Low: 4067.41, Close: 4148.27 },
        { Open: 4148.27, High: 4152.07, Low: 3766.36, Close: 3874.26 },
        { Open: 3874.26, High: 3923.98, Low: 3209.44, Close: 3226.41 },
        { Open: 3226.41, High: 3761.18, Low: 2951.15, Close: 3686.9 },
        { Open: 3686.9, High: 3874.63, Low: 3551.76, Close: 3678.74 },
        { Open: 3678.74, High: 3784.11, Low: 3484.8, Close: 3672.57 },
        { Open: 3672.57, High: 4077.22, Low: 3672.57, Close: 4067.08 },
        { Open: 4067.08, High: 4080.5, Low: 3847.35, Close: 3897. },
        { Open: 3897., High: 4021.46, Low: 3826.36, Close: 3858.09 },
        { Open: 3858.09, High: 3890.98, Low: 3584.59, Close: 3612.68 },
        { Open: 3612.68, High: 3748.7, Low: 3519.07, Close: 3603.31 },
        { Open: 3603.31, High: 3810.54, Low: 3573.24, Close: 3777.29 },
        { Open: 3777.29, High: 3777.92, Low: 3627.53, Close: 3662.12 },
        { Open: 3662.12, High: 3970.26, Low: 3662.12, Close: 3927.5 },
        { Open: 3927.5, High: 3968.54, Low: 3865.23, Close: 3895.51 },
        { Open: 3895.51, High: 4228.08, Low: 3891.22, Close: 4208.56 },
        { Open: 4208.56, High: 4278.78, Low: 4134.75, Close: 4185.29 },
        { Open: 4185.29, High: 4227.44, Low: 4027.04, Close: 4164.1 },
        { Open: 4164.1, High: 4358.4, Low: 4157.23, Close: 4353.05 },
        { Open: 4353.05, High: 4395.23, Low: 4261.35, Close: 4394.64 },
        { Open: 4394.64, High: 4462.01, Low: 4376.08, Close: 4404.1 },
        { Open: 4404.1, High: 4429.32, Low: 4246.29, Close: 4320.09 },
        { Open: 4320.09, High: 4345.28, Low: 4189.57, Close: 4225.92 },
        { Open: 4225.92, High: 4355.89, Low: 4150.76, Close: 4322.75 },
        { Open: 4322.75, High: 4417.45, Low: 4303.48, Close: 4370.24 },
        { Open: 4370.24, High: 4461.66, Low: 4330.28, Close: 4437.03 },
        { Open: 4437.03, High: 4606.18, Low: 4419.19, Close: 4596.96 },
        { Open: 4596.96, High: 4870.04, Low: 4554.03, Close: 4772.97 },
        { Open: 4772.97, High: 4909.18, Low: 4728.41, Close: 4754.7 },
        { Open: 4754.7, High: 4882.69, Low: 4726.28, Close: 4830.77 },
        { Open: 4830.77, High: 5439.13, Low: 4809.93, Close: 5439.13 },
        { Open: 5439.13, High: 5856.1, Low: 5396.23, Close: 5640.13 },
        { Open: 5640.13, High: 5814.23, Low: 5570.04, Close: 5809.69 },
        { Open: 5809.69, High: 5844.77, Low: 5439.98, Close: 5697.39 },
        { Open: 5697.39, High: 5789.79, Low: 5569.31, Close: 5754.22 },
        { Open: 5754.22, High: 5769.51, Low: 5520.48, Close: 5595.23 },
        { Open: 5595.23, High: 5599.56, Low: 5109.7, Close: 5572.2 },
        { Open: 5572.2, High: 5735.15, Low: 5519.99, Close: 5699.58 },
        { Open: 5699.58, High: 6064.14, Low: 5611.12, Close: 5984.09 },
        { Open: 5984.09, High: 6183.98, Low: 5886.65, Close: 6013.23 },
        { Open: 6013.23, High: 6068.08, Low: 5733.02, Close: 5984.96 },
        { Open: 5984.96, High: 6050.2, Low: 5653.73, Close: 5895.3 },
        { Open: 5895.3, High: 5895.3, Low: 5463.44, Close: 5518.85 },
        { Open: 5518.85, High: 5751.68, Low: 5374.6, Close: 5733.9 },
        { Open: 5733.9, High: 5978.04, Low: 5691.05, Close: 5888.14 },
        { Open: 5888.14, High: 5995.93, Low: 5691.76, Close: 5767.68 },
        { Open: 5767.68, High: 5875.9, Low: 5667.35, Close: 5732.82 },
        { Open: 5732.82, High: 6306.58, Low: 5690.11, Close: 6140.53 },
        { Open: 6140.53, High: 6218.49, Low: 6026.69, Close: 6121.8 },
        { Open: 6121.8, High: 6458.27, Low: 6089.47, Close: 6447.67 },
        { Open: 6447.67, High: 6750.17, Low: 6357.91, Close: 6750.17 },
        { Open: 6750.17, High: 7355.35, Low: 6745.96, Close: 7030. },
        { Open: 7030., High: 7454.04, Low: 6942.29, Close: 7161.45 },
        { Open: 7161.45, High: 7503.72, Low: 6994.88, Close: 7387. },
        { Open: 7387., High: 7601.53, Low: 7297.58, Close: 7382.45 },
        { Open: 7382.45, High: 7423.06, Low: 6932.43, Close: 6958.21 },
        { Open: 6958.21, High: 7221.54, Low: 6958.21, Close: 7118.8 },
        { Open: 7118.8, High: 7879.06, Low: 7078.96, Close: 7458.79 },
        { Open: 7458.79, High: 7471.88, Low: 7058.35, Close: 7146.78 },
        { Open: 7146.78, High: 7330.06, Low: 6422.97, Close: 6570.31 },
        { Open: 6570.31, High: 6827.72, Low: 6198.56, Close: 6337. },
        { Open: 6337., High: 6466.46, Low: 5507.29, Close: 5857.32 },
        { Open: 5857.32, High: 6766.81, Low: 5823.86, Close: 6517.68 },
        { Open: 6517.68, High: 6727.76, Low: 6442.4, Close: 6598.77 },
        { Open: 6598.77, High: 7336.8, Low: 6598.77, Close: 7279. },
        { Open: 7279., High: 7983.72, Low: 7122.46, Close: 7843.94 },
        { Open: 7843.94, High: 7998.4, Low: 7541.04, Close: 7689.91 },
        { Open: 7689.91, High: 7848.94, Low: 7460.11, Close: 7776.94 },
        { Open: 7776.94, High: 8101.91, Low: 7678.37, Close: 8033.94 },
        { Open: 8033.94, High: 8286.17, Low: 7940.87, Close: 8238.2 },
        { Open: 8238.2, High: 8362.3, Low: 7818.5, Close: 8095.59 },
        { Open: 8095.59, High: 8294.49, Low: 8074.53, Close: 8230.69 },
        { Open: 8230.69, High: 8268.32, Low: 8002.64, Close: 8002.64 },
        { Open: 8002.64, High: 8333.17, Low: 7892.68, Close: 8201.46 },
        { Open: 8201.46, High: 8773.9, Low: 8156.75, Close: 8763.78 },
        { Open: 8763.78, High: 9484.91, Low: 8757.36, Close: 9326.59 },
        { Open: 9326.59, High: 9739.05, Low: 9326.59, Close: 9739.05 },
        { Open: 9739.05, High: 9969.12, Low: 9645.88, Close: 9908.23 },
        { Open: 9908.23, High: 11377.33, Low: 9290.3, Close: 9816.35 },
        { Open: 9816.35, High: 10681.85, Low: 9021.85, Close: 9916.5 },
        { Open: 9916.54, High: 10934., Low: 9421.46, Close: 10859.56 },
        { Open: 10859.56, High: 11156.14, Low: 10705.13, Close: 10890 },
        { Open: 10895.01, High: 11831.51, Low: 10495.56, Close: 11180 },
        { Open: 11180.89, High: 11616.85, Low: 10875.71, Close: 11611 },
        { Open: 11616.85, High: 11860.24, Low: 11473.51, Close: 11690 },
        { Open: 11696.06, High: 13810.72, Low: 11671.57, Close: 13701 },
        { Open: 13708.99, High: 17364.56, Low: 13336.4, Close: 16858 },
        { Open: 16858.02, High: 17153.94, Low: 13963.53, Close: 16052 },
        { Open: 16057.14, High: 16291.68, Low: 13314.56, Close: 14912 },
        { Open: 14913.4, High: 15740.25, Low: 13152.53, Close: 15036 },
        { Open: 15036.96, High: 17383.46, Low: 15036.96, Close: 16694 },
        { Open: 16699.68, High: 17631.42, Low: 16259.28, Close: 17173 },
        { Open: 17178.1, High: 17384.56, Low: 15799.87, Close: 16407 },
        { Open: 16407.2, High: 17023.04, Low: 16123.12, Close: 16531 },
        { Open: 16531.08, High: 17872.55, Low: 16522.02, Close: 17601 },
        { Open: 17601.94, High: 19521.78, Low: 17419.43, Close: 19343 },
        { Open: 19343.04, High: 19783.21, Low: 18791.76, Close: 19083 },
        { Open: 19086.64, High: 19227.08, Low: 18094.19, Close: 18965 },
        { Open: 18960.52, High: 19026.21, Low: 16837.77, Close: 17606 },
        { Open: 17608.35, High: 17822.57, Low: 15577.74, Close: 16452 },
        { Open: 16454.72, High: 17301.21, Low: 15081.5, Close: 15561 },
        { Open: 15561.05, High: 15690.81, Low: 10834.94, Close: 13852 },
        { Open: 13857.14, High: 15704.35, Low: 13583.38, Close: 14545 },
        { Open: 14548.71, High: 14610.14, Low: 12508.42, Close: 13973 },
        { Open: 13975.44, High: 14572.98, Low: 13196.83, Close: 13913 },
        { Open: 13917.03, High: 16079.32, Low: 13851.13, Close: 15747 },
        { Open: 15745.26, High: 16477.36, Low: 14533.23, Close: 15377 },
        { Open: 15378.28, High: 15470.43, Low: 13498.78, Close: 14421 },
        { Open: 14428.76, High: 15076.06, Low: 13982.93, Close: 14422 },
        { Open: 14427.87, High: 14486.45, Low: 12182.52, Close: 12628 },
        { Open: 12629.81, High: 14213.44, Low: 12496.69, Close: 13863 },
        { Open: 13860.14, High: 13887.2, Low: 14169.87, Close: 13412 },
        { Open: 13412.44, High: 15216.76, Low: 14169.87, Close: 14742 },
        { Open: 14740.76, High: 15393.97, Low: 14169.87, Close: 15134 },
        { Open: 15134.65, High: 15394.99, Low: 14169.87, Close: 15154 },
        { Open: 15155.23, High: 17118.36, Low: 14169.87, Close: 16935 },
        { Open: 16937.17, High: 17211.92, Low: 14169.87, Close: 17138 },
        { Open: 17135.84, High: 17144.85, Low: 14169.87, Close: 16173 },
        { Open: 16178.49, High: 16269.69, Low: 14169.87, Close: 14973 },
        { Open: 14970.36, High: 15360.13, Low: 14169.87, Close: 14438 },
        { Open: 14439.47, High: 14890.72, Low: 13455.7, Close: 14890 },
        { Open: 14890.72, High: 14942.61, Low: 12836.91, Close: 13288 },
        { Open: 13287.26, High: 14095.06, Low: 12878.6, Close: 13812 },
        { Open: 13812.71, High: 14536.54, Low: 13810.84, Close: 14188 },
        { Open: 14188.78, High: 14352.84, Low: 13051.59, Close: 13614 },
        { Open: 13619.03, High: 14307.53, Low: 13401.24, Close: 13581 },
        { Open: 13585.9, High: 13601.43, Low: 10063.12, Close: 11348 },
        { Open: 11348.02, High: 11751.26, Low: 9199.59, Close: 11141 },
        { Open: 11141.25, High: 12045.09, Low: 10663.94, Close: 11252 },
        { Open: 11250.65, High: 11955.44, Low: 10988.79, Close: 11517 },
        { Open: 11514.92, High: 13007.25, Low: 11498.04, Close: 12758 },
        { Open: 12759.64, High: 12759.64, Low: 11096.05, Close: 11527 },
        { Open: 11522.86, High: 11868.71, Low: 10050.79, Close: 10774 },
        { Open: 10772.15, High: 11358.34, Low: 9972.29, Close: 10839 },
        { Open: 10839.83, High: 11474.21, Low: 10497.15, Close: 11392 },
        { Open: 11399.52, High: 11711., Low: 10889.04, Close: 11137 },
        { Open: 11137.24, High: 11608.51, Low: 10321.04, Close: 11095 },
        { Open: 11090.06, High: 11574.36, Low: 10855.46, Close: 11406 },
        { Open: 11407.15, High: 11942.25, Low: 11363.25, Close: 11696 },
        { Open: 11694.47, High: 11765.4, Low: 11007.79, Close: 11158 },
        { Open: 11158.39, High: 11191.8, Low: 9810.17, Close: 10035 },
        { Open: 10035., High: 10334.42, Low: 9627.89, Close: 10166.5 },
        { Open: 10166.51, High: 10203.07, Low: 8563.93, Close: 9052 },
        { Open: 9052.58, High: 9095.8, Low: 7695.1, Close: 8827.63 },
        { Open: 8827.63, High: 9471.46, Low: 8176.46, Close: 9224.39 },
        { Open: 9224.39, High: 9363.41, Low: 7859.51, Close: 8186.65 },
        { Open: 8186.65, High: 8346.91, Low: 6583.56, Close: 6914.26 },
        { Open: 6914.26, High: 7957.34, Low: 5947.4, Close: 7700.39 },
        { Open: 7700.39, High: 8582.93, Low: 7207.97, Close: 7581.8 },
        { Open: 7581.8, High: 8621.27, Low: 7576.25, Close: 8237.24 },
        { Open: 8237.24, High: 8719.26, Low: 7754.67, Close: 8689.84 },
        { Open: 8689.84, High: 9070.64, Low: 8165.26, Close: 8556.61 },
        { Open: 8556.61, High: 8556.61, Low: 7845.13, Close: 8070.8 },
        { Open: 8070.8, High: 8977.08, Low: 8070.8, Close: 8891.21 },
        { Open: 8891.21, High: 8925.68, Low: 8370.48, Close: 8516.24 },
        { Open: 8516.24, High: 9499.05, Low: 8516.24, Close: 9477.84 },
        { Open: 9477.84, High: 10218.01, Low: 9354.53, Close: 10016. },
        { Open: 10016.49, High: 10293.44, Low: 9718.59, Close: 10178 },
        { Open: 10178.71, High: 11123.84, Low: 10067.27, Close: 11092 },
        { Open: 11092.15, High: 11279.18, Low: 10156.38, Close: 10393 },
        { Open: 10396.63, High: 11254.94, Low: 10313.55, Close: 11154 },
        { Open: 11159.72, High: 11767.58, Low: 11093.22, Close: 11224 },
        { Open: 11228.24, High: 11261.63, Low: 10244.32, Close: 10455 },
        { Open: 10456.17, High: 10913.65, Low: 9730.97, Close: 9830 },
        { Open: 9830.43, High: 10397.68, Low: 9592.96, Close: 10149 },
        { Open: 10149.46, High: 10509.62, Low: 9381.17, Close: 9682 },
        { Open: 9682.38, High: 9858.16, Low: 9304.68, Close: 9586.46 },
        { Open: 9586.46, High: 10443.28, Low: 9386.49, Close: 10313 },
        { Open: 10313.08, High: 10852.01, Low: 10146.99, Close: 10565 },
        { Open: 10564.42, High: 11044.16, Low: 10280.64, Close: 10303 },
        { Open: 10309.64, High: 11074.22, Low: 10222.43, Close: 10908 },
        { Open: 10907.59, High: 11165.66, Low: 10784.22, Close: 11015 },
        { Open: 11019.52, High: 11498.41, Low: 11019.52, Close: 11435 },
        { Open: 11438.65, High: 11510.24, Low: 11067.78, Close: 11476 },
        { Open: 11479.73, High: 11660.24, Low: 11411.97, Close: 11434 },
        { Open: 11432.98, High: 11432.98, Low: 10584.96, Close: 10704 },
        { Open: 10709.53, High: 10888.41, Low: 9468.45, Close: 9906 },
        { Open: 9906.8, High: 10101.28, Low: 9075.87, Close: 9299.28 },
        { Open: 9299.28, High: 9409.29, Low: 8370.8, Close: 9237.05 },
        { Open: 9237.05, High: 9505.26, Low: 8720.05, Close: 8787.16 },
        { Open: 8787.16, High: 9730.08, Low: 8474.54, Close: 9532.74 },
        { Open: 9532.74, High: 9885.22, Low: 8778.21, Close: 9118.27 },
        { Open: 9118.27, High: 9474.68, Low: 8860.87, Close: 9144.15 },
        { Open: 9144.15, High: 9313.03, Low: 7955.06, Close: 8196.9 },
        { Open: 8196.9, High: 8413.11, Low: 7676.52, Close: 8256.99 },
        { Open: 8256.99, High: 8599.54, Low: 7924.2, Close: 8269.33 },
        { Open: 8269.33, High: 8342.13, Low: 7755.82, Close: 7862.11 },
        { Open: 7862.11, High: 8292.98, Low: 7335.57, Close: 8196.02 },
        { Open: 8196.02, High: 8702.46, Low: 8129.48, Close: 8594.19 },
        { Open: 8594.19, High: 9035.35, Low: 8324.26, Close: 8915.9 },
        { Open: 8915.9, High: 9159.9, Low: 8765.57, Close: 8895.4 },
        { Open: 8895.4, High: 9084.77, Low: 8495.1, Close: 8712.89 },
        { Open: 8712.89, High: 8918.74, Low: 8296.33, Close: 8918.74 },
        { Open: 8918.74, High: 9000.44, Low: 8509.04, Close: 8535.89 },
        { Open: 8535.89, High: 8660.49, Low: 8380.5, Close: 8449.83 },
        { Open: 8449.83, High: 8489.61, Low: 7863.21, Close: 8138.34 },
        { Open: 8138.34, High: 8211., Low: 7751.31, Close: 7790.16 },
        { Open: 7790.16, High: 8096.02, Low: 7744.82, Close: 7937.2 },
        { Open: 7937.2, High: 7958.04, Low: 6915.55, Close: 7086.49 },
        { Open: 7086.49, High: 7266.06, Low: 6593.74, Close: 6844.32 },
        { Open: 6844.32, High: 7213.5, Low: 6796.82, Close: 6926.02 },
        { Open: 6926.02, High: 7034.93, Low: 6443.2, Close: 6816.74 },
        { Open: 6816.74, High: 7108.2, Low: 6775.71, Close: 7049.79 },
        { Open: 7049.79, High: 7506.68, Low: 7022.99, Close: 7417.89 },
        { Open: 7417.89, High: 7419.8, Low: 6715.56, Close: 6789.3 },
        { Open: 6789.3, High: 6918.7, Low: 6583.85, Close: 6774.75 },
        { Open: 6774.75, High: 6850.35, Low: 6513.1, Close: 6620.41 },
        { Open: 6620.41, High: 7050.5, Low: 6611.45, Close: 6896.28 },
        { Open: 6896.28, High: 7094.91, Low: 6893.19, Close: 7022.71 },
        { Open: 7022.71, High: 7170.76, Low: 6616.57, Close: 6773.94 },
        { Open: 6773.94, High: 6878.08, Low: 6659.51, Close: 6830.9 },
        { Open: 6830.9, High: 6964.08, Low: 6807.44, Close: 6939.55 },
        { Open: 6939.55, High: 8055.2, Low: 6766.37, Close: 7916.37 },
        { Open: 7916.37, High: 8218.7, Low: 7755.41, Close: 7889.23 },
        { Open: 7889.23, High: 8174.7, Low: 7830.98, Close: 8003.68 },
        { Open: 8003.68, High: 8388.93, Low: 8003.68, Close: 8357.04 },
        { Open: 8357.04, High: 8407.72, Low: 7909.14, Close: 8051.34 },
        { Open: 8051.34, High: 8151.1, Low: 7834.4, Close: 7890.15 },
        { Open: 7890.15, High: 8212.42, Low: 7880.34, Close: 8163.69 },
        { Open: 8163.69, High: 8293.72, Low: 8104.88, Close: 8273.74 },
        { Open: 8273.74, High: 8930.43, Low: 8221.25, Close: 8863.5 },
        { Open: 8863.5, High: 9021.07, Low: 8615.68, Close: 8917.6 },
        { Open: 8917.6, High: 9009.82, Low: 8761.88, Close: 8792.83 },
        { Open: 8792.83, High: 8986.96, Low: 8775.1, Close: 8938.3 },
        { Open: 8938.3, High: 9729.26, Low: 8932.16, Close: 9652.16 },
        { Open: 9652.16, High: 9746.82, Low: 8733.52, Close: 8864.09 },
        { Open: 8864.09, High: 9303.02, Low: 8660.87, Close: 9279. },
        { Open: 9279., High: 9372.38, Low: 8911.78, Close: 8978.33 },
        { Open: 8978.33, High: 9418.99, Low: 8886.56, Close: 9342.47 },
        { Open: 9342.47, High: 9536.64, Low: 9182.68, Close: 9392.03 },
        { Open: 9392.03, High: 9442.77, Low: 9124.61, Close: 9244.32 },
        { Open: 9244.32, High: 9244.32, Low: 8842.03, Close: 9067.71 },
        { Open: 9067.71, High: 9261.21, Low: 8983.63, Close: 9219.86 },
        { Open: 9219.86, High: 9790.94, Low: 9162.19, Close: 9734.67 },
        { Open: 9734.67, High: 9763.62, Low: 9539.99, Close: 9692.72 },
        { Open: 9692.72, High: 9954.95, Low: 9675.61, Close: 9826.6 },
        { Open: 9826.6, High: 9909.61, Low: 9409.23, Close: 9619.14 },
        { Open: 9619.14, High: 9634.83, Low: 9188.66, Close: 9362.53 },
        { Open: 9362.53, High: 9454.92, Low: 9050.35, Close: 9180.16 },
        { Open: 9180.16, High: 9187.45, Low: 9146.89, Close: 9147.83 },
        { Open: 9147.83, High: 9153.78, Low: 9126.08, Close: 9148.47 },
        { Open: 9148.47, High: 9184.6, Low: 9148.47, Close: 9160.35 },
        { Open: 9160.35, High: 9160.35, Low: 9125.2, Close: 9126.88 },
        { Open: 9126.88, High: 9156.81, Low: 9126.88, Close: 9157.55 },
        { Open: 9157.55, High: 9165.23, Low: 9157.55, Close: 9158.77 },
        { Open: 9158.77, High: 9164.36, Low: 9152.7, Close: 9154.05 },
        { Open: 9154.05, High: 9162.24, Low: 9154.05, Close: 9161.3 },
        { Open: 9161.3, High: 9161.58, Low: 9156.73, Close: 9155.81 },
        { Open: 9155.81, High: 9156.36, Low: 9111.66, Close: 9119.27 },
        { Open: 9119.27, High: 9119.27, Low: 9079.84, Close: 9106.27 },
        { Open: 9106.27, High: 9106.61, Low: 9076.02, Close: 9077.95 },
        { Open: 9077.95, High: 9079.13, Low: 9003.13, Close: 9032.28 },
        { Open: 9032.28, High: 9055.76, Low: 9021.96, Close: 9031.53 },
        { Open: 9031.53, High: 9063.57, Low: 9031.53, Close: 9063.46 },
        { Open: 9063.46, High: 9064.01, Low: 9022.63, Close: 9039.03 },
        { Open: 9039.03, High: 9039.03, Low: 8975.97, Close: 9003.35 },
        { Open: 9003.35, High: 9038.68, Low: 9003.35, Close: 9013.93 },
        { Open: 9013.93, High: 9042.2, Low: 9013.93, Close: 9050.04 },
        { Open: 9050.04, High: 9072., Low: 9049.06, Close: 9071.64 },
        { Open: 9071.64, High: 9072.46, Low: 9012.07, Close: 9021.11 },
        { Open: 9021.11, High: 9063.1, Low: 9020.82, Close: 9048.44 },
        { Open: 9048.44, High: 9049.04, Low: 9027.88, Close: 9027.82 },
        { Open: 9027.82, High: 9059.25, Low: 9027.82, Close: 9061.02 },
        { Open: 9061.02, High: 9087.05, Low: 9055.76, Close: 9065.43 }
    ];

