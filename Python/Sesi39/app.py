from flask import Flask
from markupsafe import escape


app = Flask(__name__)

@app.route('/books')
@app.route('/')
def hello_world():
    sum = 40
    return f'Hello, World! {sum} !!!'


@app.route('/<name>')
def heelo(name):
    # return 'Hello, {name}'
    return f"Hello, {escape(name)}!"

if __name__ == '__main__':    
    app.run(debug=True)
