import matplotlib.pyplot as plt
import numpy as np
import math
from typing import Any


def fun(x):
    i=2
    flag=1
    while i<=math.sqrt(x):
        y=x/i
        if y==int(y):
            flag=0
            break
        else:
            i+=1
    return flag

z=1000
a=[]
i=2
while i<z:
    if fun(i):
        a.append(i)
    i+=1
distance=[]
j=0
while j<len(a)-1:
    distance.append(a[j+1]-a[j])
    j+=1

x=[]
for k in range(j):
    x=x+[k]

count=[]
m = 2
n = 0
while m<=z:
    if fun(m):
        n+=1;
    count.append(n)
    m+=1

y=[]
for k in range(m-2):
    y=y+[k+2]


plt.figure(figsize=(10,5))
plt.subplot(121)
plt.xlabel('NO.')
plt.ylabel('distance')
plt.scatter(x,distance, color='k', s=25, marker="o")
plt.subplot(122)
plt.xlabel('z')
plt.ylabel('count')
plt.scatter(y,count, color='k', s=25, marker="o")
plt.savefig("10000.png")
plt.show()