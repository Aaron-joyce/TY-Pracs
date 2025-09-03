data = read.csv('tyit practical sept3.csv')

#--- PAM Method
library(cluster)
model = pam(data, 3)
# info on the cluster
model$clusinfo
# cluster of each row
model$clustering
# medoid value   of each cluster
model$medoids
#adding new col "clustering"
data$cluster = model$clustering
# data points in cluster 2
library(dplyr)
data3 = data%>%filter(cluster==2)
# plot clustering model
clusplot(model)
# plot standard model with colors
plot(data$x, data$y, col=model$clustering)

#--- DBSCAN
data = read.csv('tyit practical sept3.csv')
data = data[,-1]
library(dbscan)
model = dbscan(data, eps=.785, minPts=5)
data$cluster = model$cluster
plot(data$x, data$y, col=data$cluster)
