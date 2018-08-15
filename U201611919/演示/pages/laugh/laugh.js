Page({
  onReady: function () {
    wx.playBackgroundAudio({
      dataUrl: 'http://music.163.com/song/media/outer/url?id=477980.mp3',
    })
  }

})