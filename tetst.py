from distutils.spawn import find_executable
from lib2to3.pgen2 import driver
import time
from selenium import webdriver
from selenium.webdriver.chrome.service import Service
from selenium.webdriver.common.by import By
from webdriver_manager.chrome import ChromeDriverManager

bongeszo = webdriver.Chrome(executable_path=ChromeDriverManager().install())

#Oldal megnyitás
bongeszo.get('https://szallas.sulla.hu/')
bongeszo.maximize_window()
time.sleep(3)

#Email beírása
email = bongeszo.find_element(By.NAME, 'email')
email.send_keys("user@kodbazis.hu")

#Jelszó beírás
password = bongeszo.find_element(By.NAME, 'password')
password.send_keys("teszt")

#Bejelentkezés gombra kattintás
btn = bongeszo.find_element(By.TAG_NAME, 'button')
btn.click()
time.sleep(1)
bongeszo.save_screenshot('printscreen1.png')

#Szállás keresés
szallas = bongeszo.find_element(By.XPATH, '//*[@id="root"]/div/ul/a[18]/div/div[1]/h4')
bongeszo.execute_script("arguments[0].scrollIntoView();", szallas)
time.sleep(1)
bongeszo.save_screenshot('printscreen2.png')

#Keresettre kattintás
bongeszo.execute_script("arguments[0].click();", szallas)
time.sleep(1)
bongeszo.save_screenshot('printscreen3.png')

#Kijelentkezés az oldalból
logout = bongeszo.find_element(By.CLASS_NAME, 'btn')
logout.click()
time.sleep(1)
bongeszo.save_screenshot('printscreen4.png')
bongeszo.close()