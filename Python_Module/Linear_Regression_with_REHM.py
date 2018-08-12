from sklearn.linear_model import LinearRegression
import numpy as np
import matplotlib.pyplot as plt
from sklearn.preprocessing import PolynomialFeatures
poly = PolynomialFeatures(degree=4,include_bias=False)
import pandas as pd


#https://github.com/sachinruk/deepschool.io/blob/master/DL-Keras_Tensorflow/Lesson%200%20-%20LinRegression.ipynb

# Set the Input File.
#input_file = "C:\\Users\\ian-h\\Documents\\MscSoftware_Dev\\YEAR-2\\COMP9028 - Comp Research Project Implem\\Resources\\Python\\training1.txt"
input_file = "C:\\GEM\\machine_Learning\\training\\training.txt"

# Read the Input File into a Pandas Data Frame/Array
df = pd.read_csv(input_file,sep=',\s+', delimiter=',', encoding="utf-8", skipinitialspace=True, nrows=50)

y1 = df.P1TOPTEMPMIN
y2 = df.P2TOPTEMPMIN
y3 = df.P3TOPTEMPMIN

#print (y.shape)
y1.values.reshape(50, -1)
y2.values.reshape(50, -1)
y3.values.reshape(50, -1)


#print (y)
x = [[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31],[32],[33],[34],[35],[36],[37],[38],[39],[40],[41],[42],[43],[44],[45],[46],[47],[48],[49],[50]]


model = LinearRegression() # 

model.fit(x,y1)
#print (model.coef_)
#print (model.intercept_)
res1 = model.predict(51)

plt.scatter(x,y1)
#plt.scatter(x,z)
plt.plot(x,y1,'r')
plt.scatter(51,model.predict(51),c='r', label='prediction')
#plt.plot(x,z, 'b')

model.fit(x,y2)
#print (model.coef_)
#print (model.intercept_)
res2 = model.predict(51)

plt.scatter(x,y2)
#plt.scatter(x,z)
plt.plot(x,y2,'g')
plt.scatter(51,model.predict(51),c='g', label='prediction')

model.fit(x,y3)
#print (model.coef_)
#print (model.intercept_)
res3 = model.predict(51)

plt.scatter(x,y3)
#plt.scatter(x,z)
plt.plot(x,y3,'y')
plt.scatter(51,model.predict(51),c='y', label='prediction')


print (res1,res2,res3)
plt.ylabel('Temperature')
plt.xlabel('Heating Zone 1,2 & 3')
plt.title('Zone Temperature')
plt.ylim(200, 300)
#plt.show()



