Page({
  onReady: function () {
    wx.playBackgroundAudio({
      dataUrl: 'http://music.163.com/song/media/outer/url?id=767946.mp3',
    })
  }

})