let count = 0;

function updateCounter() {
    document.getElementById("counter").innerHTML = count;

}

function increaseCounter() {
    count++;
    updateCounter();

}

function decreaseCounter() {
    count--;

    // Conditional for practice.
    if (count < 0) {
    count = 0;
    }
    updateCounter();

}

function resetCounter() {
    count = 0;
    updateCounter();

}

function saveCounter() {
    localStorage.setItem("count", count);

}

function loadCounter() {
    let savedCounter = localStorage.getItem("count");

    if (savedCounter !== null) {
        count = savedCounter;
        updateCounter();
    }
    else {
        window.alert("Failed to get value.");
    }
}
