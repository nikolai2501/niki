
var timer = null;
            var startTimer = null;
            var elapsedTime = 0;
            function startTimer() {
                if (timer === null) {
                    startTime = new Date().getTime() - elapsedTime;
                    timer = setInterval(updateTimer, 1000);
                }
            }

            function stopTimer(){
                if (timer !== null) {
                    clearInterval(timer);
                    timer = null;
                }
            }
            function updateTimer() {
                var currentTime = new Date().getTime();
                elapsedTime = currentTime - startTimer;
                var seconds = Math.floor(elapsedTime / 1000) % 60;
                var minutes = Math.floor(elapsedTime / 1000 * 60) % 60;
                var hours = Math.floor(elapsedTime / 1000 * 60 * 60);
            }
            function formatTime(time){
                return time < 10 ? '0' + time : time;
            }
