# NotesManagement Instruction

## How to run client app
**You will need to have Visual Studio 2019 or 2017 installed on your PC or virtual machine**

---

1. Firstly, you need to download the archive and unextract it somewhere
2. Secondly, you need to run the `NotesManagement.sln` file inside the folder with the project
3. Thirdly, wait unit all NuGet packages are restored
4. When the packages are successfully restored, go to the top toolbar and find `Debug -> Start Without Debugging`, or press `Ctrl` + `F5`
5. After that, the application should run in your browser and you can start using it

---

## Guide for application usage

1. In order to see the list of all notes, you should click the `Notes` button on the top toolbar of the page
2. In order to add new note to the list, you should click the `Create` button on the top toolbar of the page
3. In order to see the note details, you should click the 'Details' button under any of the notes on the `Notes` page
4. In order to update the note, you should repeat the 3-rd step and then click the `Update` button under the note; after that you will be redirected to the 'Update' form, where you can edit the note as you wish
5. In order to remove the note form the list, please repeat the step 3 of this list, and then click the `Delete` button under the note; after that, the note should be removed and you should be redirected to the page with all notes
6. In order to change the language on the website, you should select the language from the top toolbar select on any page, and then the language should be changed to the preferred one

---

## How to run the e2e test

1. Firstly, you will need to launch the application and it should be running on the background
2. Secondly, you will need to locate to the `Test Explorer` tab on the bottom toolbar
> You can open it by clicking on `Test -> Windows -> Test Explorer` on the top toolbar.
3. Thirdly, you will need choose the `Run All` icon in the `Test Explorer` and click it
> If some warning windows appear, please click `No`, thus you'll skip to test start
4. When the `Run All` button is pressed, a new Chrome browser window should appear and it will be closed by itself after the successfull test run
5. After that, you should see the green checkmark next to the E2E-Test in the test explorer