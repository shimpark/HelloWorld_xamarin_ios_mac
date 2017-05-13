# HelloWorld_xamarin_ios_mac

http://aspdotnet.tistory.com/1882

visual studio for mac 툴을 이용하여 xamarin 의 iOS 구현하기

```csharp

//submit 시 경고창 띄우기
partial void BtnSubmit_TouchUpInside(UIButton sender)
        {
            var name = txtName.Text; //name 입력값
            var phone = txtPhone.Text; //phone 입력값

            var msg = string.Format("name : {0} , phone : {1}", name, phone);

            //경고창 생성하기
            var okAlertController = UIAlertController.Create("정보", msg, UIAlertControllerStyle.Alert);

            //경고창에 추가 버튼 생성(닫기버튼)
            okAlertController.AddAction(UIAlertAction.Create("닫기", UIAlertActionStyle.Default, null));

            // 경고창 보여주기
            PresentViewController(okAlertController, true, null);
        }

```
