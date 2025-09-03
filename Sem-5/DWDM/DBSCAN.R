data= iris
data = data[,-5]

library(dbscan)

model = dbscan(data, eps=1, minPts=5)

model$cluster