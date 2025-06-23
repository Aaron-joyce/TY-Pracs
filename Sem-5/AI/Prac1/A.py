# Aim: Demonstrate a simple web scraping process using Python.

import requests
from bs4 import BeautifulSoup

url = "https://www.xaviers.ac"

reponse = requests.get(url)

if reponse.status_code==200:
    bfsp = BeautifulSoup(reponse.text, 'html.parser')
    
    text_content = bfsp.get_text()
    
    print(text_content)
    
else:
    print(f"Unable to fetch content. status code:{reponse.status_code}")