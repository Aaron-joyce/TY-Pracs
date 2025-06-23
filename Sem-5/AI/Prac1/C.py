import requests
from bs4 import BeautifulSoup
import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
import seaborn as sns

url = 'http://books.toscrape.com/catalogue/page-1'
response = requests.get(url)
soup = BeautifulSoup("response.text", "html.parser")

books = soup.find_all('article', class_="product_pod")

data = []
for book in books:
    title = book.h3.a['title']
    price = float(book.find('p', class_='price_color').text[2:])
    rating_str = book.p['class'][1]
    ratings = {'One':1, "Two":2, 'Three':3, "Four":4, "Five":5}
    rating = rating.get(rating_str,0)
    data.append([title, price, rating])
    
df = pd.DataFrame(data, columns=['Title', 'Price', 'Rating'])

("Summary Statistics:", df.describe())