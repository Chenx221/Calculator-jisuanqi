Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, d, e1, f As Long
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)
        d = Val(TextBox4.Text)
        e1 = Val(TextBox5.Text)
        f = Val(TextBox6.Text)
        If CheckBox1.Checked = True Then
            If CheckBox2.Checked = True Then
                If CheckBox3.Checked = True Then
                    If CheckBox4.Checked = True Then
                        If CheckBox5.Checked = True Then
                            If CheckBox6.Checked = True Then
                                MsgBox("恶意使用", 16, "程序已崩溃")
                                Me.Close()
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "" Then
            MsgBox("请选择公式", 16, "警告")

        ElseIf ComboBox1.Text = "----------力----------" Then
            MsgBox("请选择正确的公式", 16, "警告")

        ElseIf ComboBox1.Text = "重力G=mg [G=a,m=b,g=c] [N,kg,n/kg]" Then
            If CheckBox1.Checked = True Then
                'a为需要求出的值;b,c是已知数值
                TextBox1.Text = Str(b * c).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b不知道;a,c知道
                TextBox2.Text = Str(a / c).Replace(" ", "")
            Else
                TextBox3.Text = Str(a / b).Replace(" ", "")
            End If

        ElseIf ComboBox1.Text = "滑动摩擦力f=μF [f=a,μ=b,F=c] [N,?,N]" Then
            If CheckBox1.Checked = True Then
                'a为需要求出的值;b,c是已知数值
                TextBox1.Text = Str(b * c).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b不知道;a,c知道
                TextBox2.Text = Str(a / c).Replace(" ", "")
            Else
                TextBox3.Text = Str(a / b).Replace(" ", "")
            End If

        ElseIf ComboBox1.Text = "弹力F=kx [F=a,k=b,x=c] [N,N/m,m]" Then
            If CheckBox1.Checked = True Then
                'a为需要求出的值;b,c是已知数值
                TextBox1.Text = Str(b * c).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b不知道;a,c知道
                TextBox2.Text = Str(a / c).Replace(" ", "")
            Else
                TextBox3.Text = Str(a / b).Replace(" ", "")
            End If

        ElseIf ComboBox1.Text = "速度v=s/t [v=a,s=b,t=c] [m/s,m,s]" Then
            If CheckBox1.Checked = True Then
                'a为需要求出的值;b,c是已知数值
                TextBox1.Text = Str(b / c).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b不知道;a,c知道
                TextBox2.Text = Str(a * c).Replace(" ", "")
            Else
                TextBox3.Text = Str(b / a).Replace(" ", "")
            End If

        ElseIf ComboBox1.Text = "位移s=v0t+1/2at^2 [s=a,v0=b,t=c,a=d] [m,m/s,s,m/s^2]" Then
            If CheckBox1.Checked = True Then
                'a为需要求出的值;b,c,d,e1是已知数值
                TextBox1.Text = Str(b * c + (1 / 2) * d * (c ^ 2)).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b不知道;a,c,d,e1知道
                TextBox2.Text = Str(((1 / 2) * d * (c ^ 2) - a) / c).Replace(" ", "")
            ElseIf CheckBox3.Checked = True Then
                'c不知道;a,b,d,e1知道,暂不支持
                MsgBox("暂不支持")
            Else
                'd不知道;a,b,c,e1知道
                TextBox4.Text = Str((a - b * c) / ((1 / 2) * (c ^ 2))).Replace(" ", "")
            End If

        ElseIf ComboBox1.Text = "末速度V=v0+at [V=a,v0=b,a=c,t=d] [m/s,m/s,m/s^2,s]" Then
            If CheckBox1.Checked = True Then
                'a为需要求出的值;b,c是已知数值
                TextBox1.Text = Str(b + c * d).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b不知道;a,c知道
                TextBox2.Text = Str(a - c * d).Replace(" ", "")
            ElseIf CheckBox3.Checked = True Then
                TextBox3.Text = Str((a - b) / d).Replace(" ", "")
            Else
                TextBox4.Text = Str((a - b) / c).Replace(" ", "")
            End If

        ElseIf ComboBox1.Text = "末速度V^2-v0^2=2ax [V=a,v0=b,a=c,x=d] [m/s,m/s,m/s^2,m]" Then
            If CheckBox1.Checked = True Then
                'a为需要求出的值;b,c是已知数值
                TextBox1.Text = Str(Math.Sqrt(2 * c * d + b ^ 2)).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b不知道;a,c知道
                TextBox2.Text = Str(Math.Sqrt(a ^ 2 - 2 * c * d)).Replace(" ", "")
            ElseIf CheckBox3.Checked = True Then
                TextBox3.Text = Str((a ^ 2 - b ^ 2) / (2 * d)).Replace(" ", "")
            Else
                TextBox4.Text = Str((a ^ 2 - b ^ 2) / (2 * c)).Replace(" ", "")
            End If

        ElseIf ComboBox1.Text = "平均速度V=(v1+v2)/2 [V=a,v1=b,v2=c] [m/s,m/s,m/s]" Then
            If CheckBox1.Checked = True Then
                'a为需要求出的值;b,c是已知数值
                TextBox1.Text = Str((b + c) / 2).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b不知道;a,c知道
                TextBox2.Text = Str(2 * a - c).Replace(" ", "")
            Else
                TextBox3.Text = Str(2 * a - b).Replace(" ", "")
            End If

        Else
            MsgBox("那个...底下的功能还在开发中,请尝试检查更新或访问作者的Github&博客", 64, "Oops!")
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("尚未制作")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        CheckBox5.Checked = True
        CheckBox6.Checked = True
        MsgBox("已重置", 64, "ojbk")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class