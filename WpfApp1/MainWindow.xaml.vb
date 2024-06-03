Imports System.Data
Imports System.Data.SqlClient

Class MainWindow
    Private Sub insertButton_Click(sender As Object, e As RoutedEventArgs) Handles insertButton.Click
        Dim nome_pessoa As String = nomeInput.Text
        Dim sobrnome_pessoa As String = sobrenomeInput.Text
        Using sql_connection As New SqlConnection("Server=DESKTOP-Q5LSC3P\;Database=projeto-vbnet;User Id=sa;Password=123")
            sql_connection.Open()
            Using cmd_sql As New SqlCommand("INSERT INTO Pessoas (nome, sobrenome) VALUES (@nome, @sobrenome)", sql_connection)
                cmd_sql.Parameters.AddWithValue("nome", nome_pessoa)
                cmd_sql.Parameters.AddWithValue("sobrenome", sobrnome_pessoa)
                cmd_sql.ExecuteNonQuery()
            End Using
        End Using

        dados_tabela()
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As RoutedEventArgs) Handles btnDeletar.Click
        Dim pessoa_encontrada As Object = procurarpessoaInput.Text
        Using sql_connection As New SqlConnection("Server=DESKTOP-Q5LSC3P\;Database=projeto-vbnet;User Id=sa;Password=123")
            sql_connection.Open()
            Using cmd_sql As New SqlCommand("DELETE FROM Pessoas WHERE id = @id", sql_connection)
                cmd_sql.Parameters.AddWithValue("id", pessoa_encontrada)
                cmd_sql.ExecuteNonQuery()
            End Using
        End Using

        dados_tabela()
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As RoutedEventArgs) Handles updatebtn.Click
        Dim nome_pessoa As String = nomeInput.Text
        Dim sobrnome_pessoa As String = sobrenomeInput.Text
        Dim pessoa_encontrada As Object = procurarpessoaInput.Text
        Using sql_connection As New SqlConnection("Server=DESKTOP-Q5LSC3P\;Database=projeto-vbnet;User Id=sa;Password=123")
            sql_connection.Open()
            Using cmd_sql As New SqlCommand("UPDATE Pessoas SET nome = @nome, sobrenome = @sobrenome WHERE id = @id", sql_connection)
                cmd_sql.Parameters.AddWithValue("id", pessoa_encontrada)
                cmd_sql.Parameters.AddWithValue("nome", nome_pessoa)
                cmd_sql.Parameters.AddWithValue("sobrenome", sobrnome_pessoa)
                cmd_sql.ExecuteNonQuery()
            End Using
        End Using

        dados_tabela()
    End Sub

    Private Sub dados_tabela()
        Using sql_connection As New SqlConnection("Server=DESKTOP-Q5LSC3P;Database=projeto-vbnet;User Id=sa;Password=123")
            sql_connection.Open()
            Using sql_cmd As New SqlCommand("SELECT * FROM Pessoas", sql_connection)
                Using sql_adapt As New SqlDataAdapter(sql_cmd)
                    Using sql_datatable As New DataTable()
                        sql_adapt.Fill(sql_datatable)
                        dados.ItemsSource = sql_datatable.DefaultView
                    End Using
                End Using
            End Using
        End Using
    End Sub


    Private Sub dados_Initialized(sender As Object, e As EventArgs) Handles dados.Initialized
        dados_tabela()
    End Sub

    Private Sub procurarBtn_Click(sender As Object, e As RoutedEventArgs) Handles procurarBtn.Click
        Dim pessoa_encontrada As Object = procurarpessoaInput.Text
        Using sql_connection As New SqlConnection("Server=DESKTOP-Q5LSC3P;Database=projeto-vbnet;User Id=sa;Password=123")
            sql_connection.Open()
            Using sql_cmd As New SqlCommand("SELECT * FROM Pessoas WHERE (id=@pessoa OR sobrenome=@pessoa OR nome=@pessoa)", sql_connection)
                sql_cmd.Parameters.AddWithValue("pessoa", pessoa_encontrada)
                Using sql_adapt As New SqlDataAdapter(sql_cmd)
                    Using sql_datatable As New DataTable()
                        sql_adapt.Fill(sql_datatable)
                        dados.ItemsSource = sql_datatable.DefaultView
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class
