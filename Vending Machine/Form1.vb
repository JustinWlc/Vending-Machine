Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Dim totalCost As Decimal
        totalCost = 0

        If chkCocaCola.Checked Then
            totalCost += 2 * numCoke.Value
            lstOrders.Items.Add("Coca Cola" & numCoke.Value)
        End If
        If chkPrime.Checked Then
            totalCost += 2.5 * numPrime.Value
            lstOrders.Items.Add("Prime" & numPrime.Value)
        End If
        If chkSprite.Checked Then
            totalCost += 2.5 * numSprite.Value
            lstOrders.Items.Add("Sprite" & numSprite.Value)
        End If
        If chkWater.Checked Then
            totalCost += 1 * numWater.Value
            lstOrders.Items.Add("Water" & numWater.Value)
        End If
        If chkTango.Checked Then
            totalCost += 2.5 * numTango.Value
            lstOrders.Items.Add("Tango" & numTango.Value)
        End If
        If chkAqua.Checked Then
            totalCost += 1.5 * numAqua.Value
            lstOrders.Items.Add("Aqua" & numAqua.Value)
        End If
        If chkPepsi.Checked Then
            totalCost += 2 * numPepsi.Value
            lstOrders.Items.Add("Pepsi" & numPepsi.Value)
        End If
        If chkRedBull.Checked Then
            totalCost += 3 * numRebBull.Value
            lstOrders.Items.Add("RedBull" & numRebBull.Value)
        End If

        If totalCost < 3 Then
            lblCost.Text = "Minimun order is £3.00 - buy more"
        Else lblCost.Text = totalCost
        End If

    End Sub
End Class
