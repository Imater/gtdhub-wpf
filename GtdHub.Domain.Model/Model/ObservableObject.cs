using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;


namespace GtdHub.Domain.Model
{
    public abstract class ObservableObject<T> : INotifyPropertyChanged
    {
        #region Implementation of INotifyPropertyChanged

        /// <summary>
        ///     Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        /// <summary>
        ///     Called when [property changed].
        /// </summary>
        /// <param name="property">The property.</param>
        public void OnPropertyChanged(Expression<Func<T, object>> property)
        {
            string propertyName = GetPropertyName(property);
            if (PropertyChanged != null)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        ///     Gets the name of the property.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        private string GetPropertyName(Expression<Func<T, object>> expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null)
            {
                throw new ArgumentException("The expression is not a member access expression.");
            }
            var property = memberExpression.Member as PropertyInfo;
            if (property == null)
            {
                throw new ArgumentException("The member access expression does not access");
            }
            var getMethod = property.GetGetMethod(true);
            if (getMethod.IsStatic)
            {
                throw new ArgumentException("The referenced property is a static property.");
            }
            return memberExpression.Member.Name;
        }
    }
}