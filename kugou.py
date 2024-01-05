import hashlib
import time
import requests
import json
print('作者:自游')
print('酷狗音乐爬虫程序')
name = input('请输入:')
text = [
    "NVPh5oo715z5DIWAeQlhMDsWXXQV4hwt",
    "appid=1014",
    "bitrate=0",
    "callback=callback123",
    "clienttime={}".format(int(time.time() * 1000)),
    "clientver=1000",
    "dfid=4XSnWz14ZQos2PYFIl2MiDLH",
    "filter=10",
    "inputtype=0",
    "iscorrection=1",
    "isfuzzy=0",
    "keyword={}".format(name),
    "mid=8a6709b0f4f0674f12dabeb3a710313a",
    "page=1",
    "pagesize=30",
    "platform=WebFilter",
    "privilege_filter=0",
    "srcappid=2919",
    "token=",
    "userid=0",
    "uuid=8a6709b0f4f0674f12dabeb3a710313a",
    "NVPh5oo715z5DIWAeQlhMDsWXXQV4hwt"
]
data = "".join(text)#变成字符串
md5 = hashlib.md5(data.encode(encoding='utf-8')).hexdigest()#md5加密
url = "https://complexsearch.kugou.com/v2/search/song"
headers = {
    "cookie": "",#这里加上自己的cookie，有会员就可以下载付费音乐，自己充还是白嫖别人的就看各位了
    "authority": "complexsearch.kugou.com",
    "referer": "https://www.kugou.com/",
    "user-agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/109.0.0.0 Safari/537.36"
}
params = {
    "callback": "callback123",
    "srcappid": "2919",
    "clientver": "1000",
    "clienttime": int(time.time() * 1000),
    "mid": "8a6709b0f4f0674f12dabeb3a710313a",
    "uuid": "8a6709b0f4f0674f12dabeb3a710313a",
    "dfid": "4XSnWz14ZQos2PYFIl2MiDLH",
    "keyword": f"{name}",
    "page": "1",
    "pagesize": "30",
    "bitrate": "0",
    "isfuzzy": "0",
    "inputtype": "0",
    "platform": "WebFilter",
    "userid": "0",
    "iscorrection": "1",
    "privilege_filter": "0",
    "filter": "10",
    "token": "",
    "appid": "1014",
    "signature": md5
}
lll = json.loads(requests.get(url=url, headers=headers, params=params).text[12:-2])
kkk = lll['data']['lists']
for s, li in enumerate(kkk):
    ids = li['EMixSongID']
    AlbumName = li['SongName']
    singername = li['SingerName']
    print(s + 1, AlbumName, singername)
num = input('下载哪一个:')
ID = lll['data']['lists'][int(num) - 1]['EMixSongID']
name = lll['data']['lists'][int(num) - 1]['SongName']
urls = f'https://wwwapi.kugou.com/yy/index.php?r=play/getdata&callback=jQuery191015294419033165485_1674051666168&dfid=4XSnWz14ZQos2PYFIl2MiDLH&appid=1014&mid=8a6709b0f4f0674f12dabeb3a710313a&platid=4&encode_album_audio_id={ID}&_=1674051666169'
params = {
    "r": "play/getdata",
    "callback": "jQuery19101351666471912658_1674051302167",
    "dfid": "4XSnWz14ZQos2PYFIl2MiDLH",
    "appid": "1014",
    "mid": "8a6709b0f4f0674f12dabeb3a710313a",
    "platid": "4",
    "encode_album_audio_id": f"{ID}",
    "_": "1674051302168"
}
respons = json.loads(requests.get(url=urls, headers=headers, params=params).text[41:-2])
last = respons['data']['play_url']
downlode=requests.get(url=last,headers=headers).content
with open(f'{name}.mp3','wb')as sp:
    sp.write(downlode)
    print(last)
    print(f'{name}下载完成')