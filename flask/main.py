from flask import Flask, render_template
app = Flask(__name__)


@app.route('/')
def main():
    user_name = ['Anna', 'Filip', 'Kesha', 'Igor', 'Stas']
    return render_template('base.html', title='Главная', user_name=user_name)


@app.route('/about_me')
def about_me():
    return render_template('about_me.html', title='О себе')


@app.route('/hobbies')
def hobbies():
    return render_template('hobbies.html', title='Хобби')


@app.route('/plans_for_life')
def plans_for_life():
    return render_template('plans_for_life.html', title='Планы на жизнь')


if __name__ == '__main__':
    app.run()
