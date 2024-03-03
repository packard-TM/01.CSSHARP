from flask import Flask


app = Flask(__name__)


@app.route("/")
def index():
    return "<h3>Hello, world!</h3>"


@app.route("/info")
def info():
    return "<h3>Сайт создан компанией GeekBrains</h3>"



if __name__ == "__main__":
    app.run()