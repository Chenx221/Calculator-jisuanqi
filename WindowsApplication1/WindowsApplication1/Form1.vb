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
                                MsgBox("����ʹ��", 16, "�����ѱ���")
                                Me.Close()
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ComboBox1.Text = "" Then
            MsgBox("��ѡ��ʽ", 16, "����")

        ElseIf ComboBox1.Text = "----------��----------" Then
            MsgBox("��ѡ����ȷ�Ĺ�ʽ", 16, "����")

        ElseIf ComboBox1.Text = "����G=mg [G=a,m=b,g=c] [N,kg,n/kg]" Then
            If CheckBox1.Checked = True Then
                'aΪ��Ҫ�����ֵ;b,c����֪��ֵ
                TextBox1.Text = Str(b * c).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b��֪��;a,c֪��
                TextBox2.Text = Str(a / c).Replace(" ", "")
            Else
                TextBox3.Text = Str(a / b).Replace(" ", "")
            End If

        ElseIf ComboBox1.Text = "����Ħ����f=��F [f=a,��=b,F=c] [N,?,N]" Then
            If CheckBox1.Checked = True Then
                'aΪ��Ҫ�����ֵ;b,c����֪��ֵ
                TextBox1.Text = Str(b * c).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b��֪��;a,c֪��
                TextBox2.Text = Str(a / c).Replace(" ", "")
            Else
                TextBox3.Text = Str(a / b).Replace(" ", "")
            End If

        ElseIf ComboBox1.Text = "����F=kx [F=a,k=b,x=c] [N,N/m,m]" Then
            If CheckBox1.Checked = True Then
                'aΪ��Ҫ�����ֵ;b,c����֪��ֵ
                TextBox1.Text = Str(b * c).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b��֪��;a,c֪��
                TextBox2.Text = Str(a / c).Replace(" ", "")
            Else
                TextBox3.Text = Str(a / b).Replace(" ", "")
            End If

        ElseIf ComboBox1.Text = "�ٶ�v=s/t [v=a,s=b,t=c] [m/s,m,s]" Then
            If CheckBox1.Checked = True Then
                'aΪ��Ҫ�����ֵ;b,c����֪��ֵ
                TextBox1.Text = Str(b / c).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b��֪��;a,c֪��
                TextBox2.Text = Str(a * c).Replace(" ", "")
            Else
                TextBox3.Text = Str(b / a).Replace(" ", "")
            End If

        ElseIf ComboBox1.Text = "λ��s=v0t+1/2at^2 [s=a,v0=b,t=c,a=d] [m,m/s,s,m/s^2]" Then
            If CheckBox1.Checked = True Then
                'aΪ��Ҫ�����ֵ;b,c,d,e1����֪��ֵ
                TextBox1.Text = Str(b * c + (1 / 2) * d * (c ^ 2)).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b��֪��;a,c,d,e1֪��
                TextBox2.Text = Str(((1 / 2) * d * (c ^ 2) - a) / c).Replace(" ", "")
            ElseIf CheckBox3.Checked = True Then
                'c��֪��;a,b,d,e1֪��,�ݲ�֧��
                MsgBox("�ݲ�֧��")
            Else
                'd��֪��;a,b,c,e1֪��
                TextBox4.Text = Str((a - b * c) / ((1 / 2) * (c ^ 2))).Replace(" ", "")
            End If

        ElseIf ComboBox1.Text = "ĩ�ٶ�V=v0+at [V=a,v0=b,a=c,t=d] [m/s,m/s,m/s^2,s]" Then
            If CheckBox1.Checked = True Then
                'aΪ��Ҫ�����ֵ;b,c����֪��ֵ
                TextBox1.Text = Str(b + c * d).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b��֪��;a,c֪��
                TextBox2.Text = Str(a - c * d).Replace(" ", "")
            ElseIf CheckBox3.Checked = True Then
                TextBox3.Text = Str((a - b) / d).Replace(" ", "")
            Else
                TextBox4.Text = Str((a - b) / c).Replace(" ", "")
            End If

        ElseIf ComboBox1.Text = "ĩ�ٶ�V^2-v0^2=2ax [V=a,v0=b,a=c,x=d] [m/s,m/s,m/s^2,m]" Then
            If CheckBox1.Checked = True Then
                'aΪ��Ҫ�����ֵ;b,c����֪��ֵ
                TextBox1.Text = Str(Math.Sqrt(2 * c * d + b ^ 2)).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b��֪��;a,c֪��
                TextBox2.Text = Str(Math.Sqrt(a ^ 2 - 2 * c * d)).Replace(" ", "")
            ElseIf CheckBox3.Checked = True Then
                TextBox3.Text = Str((a ^ 2 - b ^ 2) / (2 * d)).Replace(" ", "")
            Else
                TextBox4.Text = Str((a ^ 2 - b ^ 2) / (2 * c)).Replace(" ", "")
            End If

        ElseIf ComboBox1.Text = "ƽ���ٶ�V=(v1+v2)/2 [V=a,v1=b,v2=c] [m/s,m/s,m/s]" Then
            If CheckBox1.Checked = True Then
                'aΪ��Ҫ�����ֵ;b,c����֪��ֵ
                TextBox1.Text = Str((b + c) / 2).Replace(" ", "")
            ElseIf CheckBox2.Checked = True Then
                'b��֪��;a,c֪��
                TextBox2.Text = Str(2 * a - c).Replace(" ", "")
            Else
                TextBox3.Text = Str(2 * a - b).Replace(" ", "")
            End If

        Else
            MsgBox("�Ǹ�...���µĹ��ܻ��ڿ�����,�볢�Լ����»�������ߵ�Github&����", 64, "Oops!")
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("��δ����")
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
        MsgBox("������", 64, "ojbk")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class