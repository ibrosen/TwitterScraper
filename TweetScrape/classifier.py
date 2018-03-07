import nltk.classify.util
from nltk.classify import NaiveBayesClassifier
from nltk.corpus import movie_reviews
from nltk.corpus import stopwords
from nltk.tokenize import word_tokenize
from nltk.corpus import wordnet
nltk.download()

print("Xd")
with open("cleanedtweets.txt",encoding="utf8") as f:
    for line in f:
        line = f.read()
        lineTokenized = word_tokenize(line)
        #clean tweets dickhead
        print(lineTokenized)
