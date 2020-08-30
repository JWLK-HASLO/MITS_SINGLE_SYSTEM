clear all; close all; clc;

fs = 100e6;
fc = 18e6;

HPF = fir1(64, 0.05, 'high');
LPF = fir1(64, fc/fs);

fileID = fopen('HPF.txt','wt');
fprintf(fileID,'%f\n',HPF);
fclose(fileID);

fileID = fopen('LPF_18.txt','wt');
fprintf(fileID,'%f\n',LPF);
fclose(fileID);

deci_fector = 2;
LPF = fir1(64, 1/deci_fector);
fileID = fopen('LPF_DECI2.txt','wt');
fprintf(fileID,'%f\n',LPF);
fclose(fileID);

deci_fector = 3;
LPF = fir1(64, 1/deci_fector);
fileID = fopen('LPF_DECI3.txt','wt');
fprintf(fileID,'%f\n',LPF);
fclose(fileID);

deci_fector = 4;
LPF = fir1(64, 1/deci_fector);
fileID = fopen('LPF_DECI4.txt','wt');
fprintf(fileID,'%f\n',LPF);
fclose(fileID);