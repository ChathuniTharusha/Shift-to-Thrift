// Shrinking banner script
document.addEventListener("scroll", function () {
    const banner = document.querySelector(".banner");
    if (window.scrollY > 50) {
        banner.classList.add("shrink");
    } else {
        banner.classList.remove("shrink");
    }
});
