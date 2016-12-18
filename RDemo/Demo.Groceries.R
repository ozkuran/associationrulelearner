#install.packages("arules");
library(arules);

## Create transaction data set.
data <- readLines("groceries.csv")     
data <- strsplit(data, ",", fixed=TRUE)

t <- as(data, "transactions")

## Mine itemsets with tidLists.
f <- eclat(data, parameter = list(support = 0.05, tidLists = TRUE))

## Get dimensions of the tidLists.
dim(tidLists(f))

## Coerce tidLists to list.
as(tidLists(f), "list")

## Inspect visually.
image(tidLists(f))

##Show the Frequent itemsets and respectives supports
inspect(f)