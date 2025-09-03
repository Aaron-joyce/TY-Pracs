data = iris
data = data[,-5]

library(cluster)

model = pam(data, 3)

# info on the cluster
model$clusinfo

# cluster of each row
model$clustering

# medoid value   of each cluster
model$medoids

data$cluster = model$clustering

# data points in cluster 2
library(dplyr)
data3 = data%>%filter(cluster==2)

clusplot(model)

plot(data$Sepal.Length, data$Sepal.Width, col=model$clustering)
