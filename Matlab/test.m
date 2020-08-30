clear; close all; clc;

fileID = fopen('data1.txt','r');
data=fscanf(fileID,'%f');
fclose(fileID);

fileID = fopen('Impulse_response.txt','r');
Impulse_response=fscanf(fileID,'%f');
fclose(fileID);

out = convn(data, Impulse_response, 'same');