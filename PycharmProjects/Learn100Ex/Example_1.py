# -*- coding: UTF-8 -*-

for i in range(1,5):
    for j in range(1,5):
        for k in range(1,5):
            if (i!=k) and (i!=j) and (j!=k):
                print i,j,k,"Owencai"

print "======================================"

d=[]
for i in range(1,5):
    for j in range(1,5):
        for k in range(1,5):
            if (i!=k) and (i!=j) and (j!=k):
                d.append([i,j,k])

print "总数量：", len(d)
print d


print "======================================"

list_sum=[1,2,3,4]

list = [i*100 + j*10 + k for i in list_sum for j in list_sum for k in list_sum if
        ( j != i and k != j and i!=k)]
print (list)

print "======================================"

list01 = ['runoob', 786, 2.23, 'john', 70.2]
list02 = [123, 'john']

print list01
print list02

print list01[0]
print "-1 : ", list01[-1]  #从后计算向前
print list01[0:3]











