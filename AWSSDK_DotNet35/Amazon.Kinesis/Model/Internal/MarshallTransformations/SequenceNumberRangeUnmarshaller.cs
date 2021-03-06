/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
    using System;
    using System.Collections.Generic;
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.Kinesis.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// SequenceNumberRangeUnmarshaller
      /// </summary>
      internal class SequenceNumberRangeUnmarshaller : IUnmarshaller<SequenceNumberRange, XmlUnmarshallerContext>, IUnmarshaller<SequenceNumberRange, JsonUnmarshallerContext>
      {
        SequenceNumberRange IUnmarshaller<SequenceNumberRange, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public SequenceNumberRange Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            SequenceNumberRange sequenceNumberRange = new SequenceNumberRange();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("StartingSequenceNumber", targetDepth))
              {
                context.Read();
                sequenceNumberRange.StartingSequenceNumber = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("EndingSequenceNumber", targetDepth))
              {
                context.Read();
                sequenceNumberRange.EndingSequenceNumber = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return sequenceNumberRange;
                }
            }
          

            return sequenceNumberRange;
        }

        private static SequenceNumberRangeUnmarshaller instance;
        public static SequenceNumberRangeUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new SequenceNumberRangeUnmarshaller();
            return instance;
        }
    }
}
  
