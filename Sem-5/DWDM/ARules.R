library(arules)
transaction_data = list(c('A','B'), 
                        c('A','B', 'P', 'C'),
                        c('A','D', 'P', 'C'),
                        c('R', 'P', 'Q'),
                        c('L','N', 'M'),
                        c('A','D', 'B', 'C'),
                        c('D', 'B', 'C'),
                        c('L','M','N','A','D', 'B', 'C')
                        )
trans = as(transaction_data, 'transactions')
inspect(trans)
itemFrequencyPlot(trans)
rules = apriori(trans, parameter = list(support=.3, confidence=.75))

inspect(sort(rules, by='confidence')[1:5])
#-----------------------------------------------------------
data = read.csv('arules.csv')
data$TID = as.factor(data$TID)
data$ITEMS =as.character(data$ITEMS)
transactionData_new = split(data$ITEMS, data$TID)

trans_new = as(transactionData_new, 'transactions')
inspect(trans_new)

itemFrequencyPlot(trans)

rules_new = apriori(trans_new, parameter = list(support=.3, confidence=.75))

inspect(sort(rules_new, by='confidence')[1:5])