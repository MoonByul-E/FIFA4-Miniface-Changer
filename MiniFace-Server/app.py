from flask import Flask, render_template
from pymysql import NULL
import mysql, requests, json

app = Flask(__name__)

load_Data = requests.get("https://static.api.nexon.co.kr/fifaonline4/latest/spid.json")
load_Json = json.loads(load_Data.content)

@app.route("/board/<Code>")
def function_main(Code):
    Result = False

    if len(Code) == 9 and Code.isdigit():
        for i in range(len(load_Json)):
            if load_Json[i]["id"] == int(Code):
                Result = True

    if Result == True:
        db_Class = mysql.Database()
        sql = f"SHOW TABLES LIKE 'Board_{Code}';"
        row = db_Class.excuteAll(sql)
        
        if not row:
            #만들어졌던적이 없음
            #생성
            sql = f"""CREATE TABLE Board_{Code}(
                No int not null,
                Title longtext,
                fileLocation longtext,
                primary key(No)
            );"""
            db_Class.execute(sql)
            return "[{'No': -1, 'Title': '없음', 'fileLocation': ''}]"

        else:
            #테이블 있음
            sql = f"SELECT * FROM Board_{Code};"
            row = db_Class.excuteAll(sql)

            if not row:
                return "[{'No': -1, 'Title': '없음', 'fileLocation': ''}]"

            else:
                return str(row)

    else:
        print("NOT FOUND")
        return "Error"

@app.route("/upload/<Code>/<No>")
def function_upload():
    return "A"

if __name__ == "__main__":
    app.run(host = "127.0.0.1", port = 80)  