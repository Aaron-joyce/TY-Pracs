import requests
from bs4 import BeautifulSoup
import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
import seaborn as sns

url = 'http://books.toscrape.com/catalogue/page-1.html'
response = requests.get(url)
soup = BeautifulSoup(response.text, "html.parser")

books = soup.find_all('article', class_="product_pod")

data = []
for book in books:
    title = book.h3.a['title']
    price = float(book.find('p', class_='price_color').text[2:])
    rating_str = book.p['class'][1]
    ratings = {'One':1, "Two":2, 'Three':3, "Four":4, "Five":5}
    rating = ratings.get(rating_str,0)
    data.append([title, price, rating])
    
df = pd.DataFrame(data, columns=['Title', 'Price', 'Rating'])
print("Summary Statistics:", df.describe())

# Price distribution
sns.set_theme(style='whitegrid')
plt.figure(figsize=(8, 5))
sns.histplot(df['Price'], bins=10, kde=True)
plt.title('Price Distribution of Books')
plt.xlabel('Price (£)')
plt.ylabel('Count')
plt.show()

# Rating distribution
plt.figure(figsize=(8, 5))
sns.countplot(x='Rating', data=df, palette='viridis')
plt.title('Rating Distribution of Books')
plt.xlabel('Rating (1-5)')
plt.ylabel('Count')
plt.show()

# Price vs Rating
plt.figure(figsize=(8, 5))
sns.boxplot(x='Rating', y='Price', data=df)
plt.title('Price vs Rating')
plt.xlabel('Rating')
plt.ylabel('Price (£)')
plt.show()
