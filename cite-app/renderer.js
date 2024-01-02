const infomation = document.getElementById("info");
infomation.innerText = `This app is using chrome (v${versions.chrome()}), Node.js (v${versions.node()}), and Electron (v${versions.electron()})`;

const button = document.getElementById("but");

button.addEventListener("click", async () => {
  button.innerText = await versions.ping();
  console.log(await versions.ping());
});
